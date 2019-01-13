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
    public partial class RenterMain : Form
    {
        // 当前用户的账号
        private string _account;
        public RenterMain(string account)
        {
            InitializeComponent();
            _account = account;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region 数据校验
            if (string.IsNullOrWhiteSpace(this.txtboxPriceFrom.Text)&&(!string.IsNullOrWhiteSpace(this.txtboxPriceTo.Text)))
            {
                MessageBox.Show("房屋价格范围的起始值不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((!string.IsNullOrWhiteSpace(this.txtboxPriceFrom.Text)) && string.IsNullOrWhiteSpace(this.txtboxPriceTo.Text))
            {
                MessageBox.Show("房屋价格范围的终值不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtboxAreaFrom.Text)&&(!string.IsNullOrWhiteSpace(this.txtboxAreaTo.Text)))
            {
                MessageBox.Show("房屋面积范围的起始值不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(string.IsNullOrWhiteSpace(this.txtboxAreaFrom.Text)) && string.IsNullOrWhiteSpace(this.txtboxAreaTo.Text))
            {
                MessageBox.Show("房屋面积范围的终值不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            // 根据用户的查询条件拼接SQL字符串
            string priceRange = string.Empty;
            string areaRange = string.Empty;
            string hopedAddress = string.Empty;
            if (!string.IsNullOrWhiteSpace(this.txtboxPriceFrom.Text))
            {
                priceRange = string.Format("(housePrice Between {0} and {1}) and", this.txtboxPriceFrom.Text.Trim(), this.txtboxPriceTo.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(this.txtboxAreaFrom.Text))
            {
                areaRange = string.Format("(houseArea Between {0} and {1}) and", this.txtboxAreaFrom.Text.Trim(), this.txtboxAreaTo.Text.Trim());
            }
            if (!string.IsNullOrWhiteSpace(this.txtboxAddress.Text))
            {
                hopedAddress = string.Format(" address Like '%{0}%'", this.txtboxAddress.Text.Trim());
            }
            string cmdStr = string.Format("Select houseId,housePrice,houseState,houseArea,address,tenantId From Room Where {0}{1}{2}", priceRange, areaRange, hopedAddress);
            // 可能用户并不想通过地址查询，此时查询字符串末尾会多出字符串and, 判断这种情况并去掉and
            if (cmdStr.EndsWith("and"))
            {
                cmdStr = cmdStr.Substring(0, cmdStr.Length - 4);
            }
            // 如果用户不输入任何查询条件，则输出全部待出租的房源
            if (cmdStr.EndsWith("Where "))
            {
                cmdStr = cmdStr.Substring(0, cmdStr.Length - 7);
            }

            // 执行查询
            DataTable houseInfoTable = SqlHelper.Select(cmdStr);
            // 定义一个列表，将查询结果转为列表中的对象
            List<HouseInfoForRenterMain> houseInfos = new List<HouseInfoForRenterMain>();
            for (int i = 0; i < houseInfoTable.Rows.Count; i++)
            {
                if ((int)houseInfoTable.Rows[i]["houseState"] == 1)
                {
                    HouseInfoForRenterMain houseInfo = new HouseInfoForRenterMain
                    {
                        HouseId = houseInfoTable.Rows[i]["houseId"].ToString(),
                        HousePrice = houseInfoTable.Rows[i]["housePrice"].ToString(),
                        HouseArea = houseInfoTable.Rows[i]["houseArea"].ToString(),
                        Address = houseInfoTable.Rows[i]["address"].ToString()
                    };
                    // 通过房主id查询房主名称和联系电话
                    string cmdStr3 = "Select Tname,telephone From Tenant Where Tid = " + houseInfoTable.Rows[i]["tenantId"].ToString();
                    DataTable renterInfo = SqlHelper.Select(cmdStr3);
                    houseInfo.TenantName = renterInfo.Rows[0]["Tname"].ToString();
                    houseInfo.Telephone = renterInfo.Rows[0]["telephone"].ToString();

                    houseInfos.Add(houseInfo);
                }
            }
            // 将数据添加到dataGridView中
            this.dgvHouseInfo.DataSource = houseInfos;
        }

        private void RenterMain_Load(object sender, EventArgs e)
        {
            // 通过当前用户账号查询出用户Id
            string cmdStr = "Select Rid From Renter Where Raccount = '" + _account + "';";
            int id = SqlHelper.ExecuteScalar(cmdStr);
            // 查询与当前租客相关的房源信息
            string cmdStr2 = "Select houseId,housePrice,houseArea,address,houseState,renterId,tenantId, offerPrice from Room Where renterId=" + id.ToString();
            DataTable houseInfoTable = SqlHelper.Select(cmdStr2);

            // 加载租客有购买意向的房屋
            List<HouseInfoInterestForRenterMain> houseInfoInterests = new List<HouseInfoInterestForRenterMain>();
            for (int i = 0; i < houseInfoTable.Rows.Count; i++)
            {
                if ((int)houseInfoTable.Rows[i]["houseState"] == 2|| (int)houseInfoTable.Rows[i]["houseState"] == 3)
                {
                    HouseInfoInterestForRenterMain houseInfo = new HouseInfoInterestForRenterMain
                    {
                        HouseId = houseInfoTable.Rows[i]["houseId"].ToString(),
                        HousePrice = houseInfoTable.Rows[i]["housePrice"].ToString(),
                        MyOfferPrice = houseInfoTable.Rows[i]["offerPrice"].ToString(),
                        HouseArea = houseInfoTable.Rows[i]["houseArea"].ToString(),
                        Address = houseInfoTable.Rows[i]["address"].ToString(),
                        HouseStatus = (int)houseInfoTable.Rows[i]["houseState"] == 2?"等待房主回复":"交易成功"
                    };
                    // 通过租客id查询租客名称和联系电话
                    string cmdStr3 = "Select Tname,telephone From Tenant Where Tid = " + houseInfoTable.Rows[i]["tenantId"].ToString();
                    DataTable renterInfo = SqlHelper.Select(cmdStr3);
                    houseInfo.TenantName = renterInfo.Rows[0]["Tname"].ToString();
                    houseInfo.Telephone = renterInfo.Rows[0]["telephone"].ToString();

                    houseInfoInterests.Add(houseInfo);
                }
            }
            this.dgvTransactionStatus.DataSource = houseInfoInterests;
        }

        private void dgvHouseInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取房屋id
            string id = this.dgvHouseInfo.Rows[e.RowIndex].Cells[0].Value.ToString();

            int CIndex = e.ColumnIndex;

            if (CIndex == 6)
            {
                // 显示报价窗口
                RenterOfferWindow offerWindow = new RenterOfferWindow(id,_account);
                DialogResult dialogResult = offerWindow.ShowDialog();

                // 根据返回的DialogResult判断是否添加成功
                if (dialogResult == DialogResult.OK)
                {
                    // 由于数据变动，重新执行一次查询
                    btnSearch_Click(sender, e);
                    RenterMain_Load(sender, e);
                    return;
                }
                else
                {
                    MessageBox.Show("提交报价操作被取消！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabControl1.TabPages[1];
        }

        private void RenterMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    // 定义一个类存储查询结果的字段
    class HouseInfoForRenterMain
    {
        public string HouseId { get; set; }
        public string HousePrice { get; set; }
        public string HouseArea { get; set; }
        public string Address { get; set; }
        public string TenantName { get; set; }
        public string Telephone { get; set; }
        public string Offer { get; set; } = "报价";
    }
    class HouseInfoInterestForRenterMain
    {
        public string HouseId { get; set; }
        public string HousePrice { get; set; }
        public string MyOfferPrice { get; set; }
        public string HouseArea { get; set; }
        public string Address { get; set; }
        public string TenantName { get; set; }
        public string Telephone { get; set; }
        public string HouseStatus { get;set; }
    }
}
