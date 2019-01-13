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
    public partial class AdminMain : Form
    {
        // 当前用户的账号
        private string _account;
        public AdminMain(string account)
        {
            InitializeComponent();
            _account = account;
        }

        // 一下三个事件处理程序跳到指定的选项卡页面
        private void btnSearchAllTenant_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabControl1.TabPages[1];
        }

        private void btnSearchAllRenter_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabControl1.TabPages[2];
        }

        private void btnSearchAllHouse_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabControl1.TabPages[3];
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            // 加载所有房主信息
            string cmdStr = "Select Tid,Taccount,Tname,telephone From Tenant";
            DataTable tenantInfoTable = SqlHelper.Select(cmdStr);
            this.dgvTenantInfo.DataSource = tenantInfoTable;

            // 加载所有租客信息
            string cmdStr2 = "Select Rid,Raccount,Rname,telephone From Renter";
            DataTable renterInfoTable = SqlHelper.Select(cmdStr2);
            this.dgvRenterInfo.DataSource = renterInfoTable;

            // 加载所有房源信息
            string cmdStr3 = "Select houseId,housePrice,houseArea,houseState,address,tenantId,renterId,offerPrice From Room";
            DataTable houseInfoTable = SqlHelper.Select(cmdStr3);

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
            //将所有相关信息存入列表中
            List<HouseInfo> houseInfos = new List<HouseInfo>();
            for (int i = 0; i < houseInfoTable.Rows.Count; i++)
            {
                HouseInfo houseInfo = new HouseInfo
                {
                    HouseId = houseInfoTable.Rows[i]["houseId"].ToString(),
                    HouseArea = houseInfoTable.Rows[i]["houseArea"].ToString(),
                    Address = houseInfoTable.Rows[i]["address"].ToString(),
                    HouseState = houseStateList[i],
                    HousePrice = houseInfoTable.Rows[i]["housePrice"].ToString(),
                    OfferPrice= houseInfoTable.Rows[i]["offerPrice"].ToString(),
                    RenterId= houseInfoTable.Rows[i]["renterId"].ToString(),
                    TenantId= houseInfoTable.Rows[i]["tenantId"].ToString()
                };
                houseInfos.Add(houseInfo);
            }
            this.dgvHouseInfo.DataSource = houseInfos;
        }

        // 一下三个处理程序实现查找功能
        private void btnSearchTenant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtboxTenantId.Text))
            {
                MessageBox.Show("查询文本框不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FindId(this.dgvTenantInfo, this.txtboxTenantId.Text);
        }
        private void btnSearchRenter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtboxRenterId.Text))
            {
                MessageBox.Show("查询文本框不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FindId(this.dgvRenterInfo, this.txtboxRenterId.Text);
        }
        private void btnSearchHouse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtboxHouseId.Text))
            {
                MessageBox.Show("查询文本框不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FindId(this.dgvHouseInfo, this.txtboxHouseId.Text);
        }

        private void FindId(DataGridView dgv,string searchText)
        {
            // 循环遍历datagridView第一列的id数据
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[0].Value != null)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString() == searchText)
                    {
                        dgv.CurrentCell = dgv.Rows[i].Cells[0];
                    }
                }
            }
        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    class HouseInfo
    {
        public string HouseId { get; set; }
        public string HousePrice { get; set; }
        public string HouseArea { get; set; }
        public string HouseState { get; set; }
        public  string Address { get; set; }
        public string TenantId { get; set; }
        public string RenterId { get; set; }
        public string OfferPrice { get; set; }
    }
}
