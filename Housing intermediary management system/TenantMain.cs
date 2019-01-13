using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_intermediary_management_system
{
    public partial class TenantMain : Form
    {
        // 当前用户的账号
        private string _account;
        public TenantMain(string account)
        {
            InitializeComponent();
            _account = account;
        }

        // 房主界面加载的事件
        private void TenantMain_Load(object sender, EventArgs e)
        {
            #region // 加载当前用户发布的房源信息
            // 加载当前用户发布的房源信息
            // 通过当前用户账号查询出用户Id
            string cmdStr = "Select Tid From Tenant Where Taccount = '" + _account + "';";
            int id = SqlHelper.ExecuteScalar(cmdStr);

            // 查询当前用户发布的房源信息
            string cmdStr2 = "Select houseId,housePrice,houseArea,address,houseState,renterId, offerPrice from Room Where tenantId=" + id.ToString();
            DataTable houseInfoTable = SqlHelper.Select(cmdStr2);

            // 声明一个列表用于存储房屋状态
            List<string> houseStateList = new List<string>();
            // 将使用数字表示的房屋状态转换为字符串形式
            for (int i = 0; i < houseInfoTable.Rows.Count; i++)
            {
                switch ((int)houseInfoTable.Rows[i]["houseState"])
                {
                    case 1:
                        houseStateList.Add("待租");
                        break;
                    case 2:
                        houseStateList.Add("有意向");
                        break;
                    case 3:
                        houseStateList.Add("已租出");
                        break;
                    default:
                        break;
                }
            }

            // 根据租客的Id获取租客的名称和联系电话，并将所有相关信息存入列表中
            List<HouseInfoForTenantMain> houseInfos = new List<HouseInfoForTenantMain>();
            for (int i = 0; i < houseInfoTable.Rows.Count; i++)
            {
                HouseInfoForTenantMain houseInfo = new HouseInfoForTenantMain
                {
                    HouseId = houseInfoTable.Rows[i]["houseId"].ToString(),
                    HouseArea = houseInfoTable.Rows[i]["houseArea"].ToString(),
                    Address = houseInfoTable.Rows[i]["address"].ToString(),
                    HouseState = houseStateList[i],
                    HousePrice = houseInfoTable.Rows[i]["housePrice"].ToString()
                };

                if (houseInfoTable.Rows[i]["renterId"].ToString() != string.Empty)
                {
                    string cmdStr3 = "Select Rname,telephone From Renter Where Rid = " + houseInfoTable.Rows[i]["renterId"].ToString();
                    DataTable renterInfo = SqlHelper.Select(cmdStr3);
                    houseInfo.RenterName = renterInfo.Rows[0]["Rname"].ToString();
                    houseInfo.Telephone = renterInfo.Rows[0]["telephone"].ToString();
                }
                houseInfos.Add(houseInfo);
            }
            // 将房源列表显示在界面上
            dgvHouseInfo.DataSource = houseInfos;
            #endregion

            #region 加载租客有购买意向的房屋
            // 加载租客有购买意向的房屋
            List<HouseInfoInterestForTenant> houseInfoInterests = new List<HouseInfoInterestForTenant>();
            for (int i = 0; i < houseInfoTable.Rows.Count; i++)
            {
                if ((int)houseInfoTable.Rows[i]["houseState"] == 2)
                {
                    HouseInfoInterestForTenant houseInfo = new HouseInfoInterestForTenant
                    {
                        HouseId = houseInfoTable.Rows[i]["houseId"].ToString(),
                        HousePrice = houseInfoTable.Rows[i]["housePrice"].ToString(),
                        OfferPrice = houseInfoTable.Rows[i]["offerPrice"].ToString(),
                    };
                    // 通过租客id查询租客名称和联系电话
                    string cmdStr3 = "Select Rname,telephone From Renter Where Rid = " + houseInfoTable.Rows[i]["renterId"].ToString();
                    DataTable renterInfo = SqlHelper.Select(cmdStr3);
                    houseInfo.RenterName = renterInfo.Rows[0]["Rname"].ToString();
                    houseInfo.Telephone = renterInfo.Rows[0]["telephone"].ToString();

                    houseInfoInterests.Add(houseInfo);
                }
            }
            // 将有意向的房源显示在界面上
            this.dgvHouseInfoInterested.DataSource = houseInfoInterests;
            #endregion
        }

        // 同意和拒绝按钮的处理
        private void dgvHouseInfoInterested_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取房屋id
            string id = this.dgvHouseInfoInterested.Rows[e.RowIndex].Cells[0].Value.ToString();
            // 获取对方出价，在同意出租后，将租金替换为对方出价
            string price = this.dgvHouseInfoInterested.Rows[e.RowIndex].Cells[2].Value.ToString();

            int CIndex = e.ColumnIndex;

            // 接受报价达成交易的处理
            // 房屋状态设为已租出
            // 讲房屋租金替换为对方出价
            // 对方出价清空
            if (CIndex == 5)
            {
                // 拼接Sql语句
                string cmdstr = "Update Room Set housePrice="+price.ToString()+", houseState =" + 3.ToString() + ", offerPrice=null Where houseId=" + id.ToString();
                int influencedLines = SqlHelper.Update(cmdstr);
                if (influencedLines==1)
                {
                    TenantMain_Load(sender, e);
                    MessageBox.Show("租赁交易已确认！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // 不接受报价
            // 房屋状态设为待租
            // 租客id清空
            // 对方出价清空
            if (CIndex ==6)
            {
                // 拼接Sql语句
                string cmdstr = "Update Room Set  houseState =" + 1.ToString() + ", offerPrice=null, renterId=null Where houseId=" + id.ToString();
                int influencedLines = SqlHelper.Update(cmdstr);
                if (influencedLines == 1)
                {
                    TenantMain_Load(sender, e);
                    MessageBox.Show("交易已拒绝！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[1];
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            TenantAddHousePage tenantAddHouse = new TenantAddHousePage(_account);
            // 显示添加房源的窗口
            DialogResult dialogResult = tenantAddHouse.ShowDialog();
            // 根据返回的DialogResult判断是否添加成功
            if (dialogResult==DialogResult.OK)
            {
                // 重新加载两个dataGridView 中的数据
                TenantMain_Load(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("房源发布操作被取消！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TenantMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    class HouseInfoForTenantMain
    {
        public string HouseId { get; set; }
        public string HousePrice { get; set; }
        public string HouseArea { get; set; }
        public string Address { get; set; }
        public string HouseState { get; set; }
        public string RenterName { get; set; }
        public string Telephone { get; set; }
    }
    class HouseInfoInterestForTenant
    {
        public string HouseId { get; set; }
        public string HousePrice { get; set; }
        public string OfferPrice { get; set; }
        public string RenterName { get; set; }
        public string Telephone { get; set; }
        public string Agree { get; set; } = "同意";
        public string Reject { get; set; } = "拒绝";
    }
}
