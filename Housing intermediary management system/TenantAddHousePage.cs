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
    public partial class TenantAddHousePage : Form
    {
        private string _account;
        public TenantAddHousePage(string account)
        {
            InitializeComponent();
            this._account = account;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region 数据校验
            if (string.IsNullOrWhiteSpace(this.txtboxPrice.Text))
            {
                MessageBox.Show("房屋价格不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtboxArea.Text))
            {
                MessageBox.Show("房屋面积不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtboxAddress.Text))
            {
                MessageBox.Show("房屋地址不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            string price = this.txtboxPrice.Text.Trim();
            string area = this.txtboxArea.Text.Trim();
            string address = this.txtboxAddress.Text.Trim();
            // 通过当前用户账号查询出用户Id
            string cmdStr = "Select Tid From Tenant Where Taccount = '" + _account + "';";
            int id = SqlHelper.ExecuteScalar(cmdStr);

            // 拼接Sql语句
            string cmdStr2 = string.Format("Insert Into Room (housePrice,houseArea,houseState,address,tenantId)Values('{0}','{1}','{2}','{3}','{4}');", price, area, 4, address,id);
            int influencedLines = SqlHelper.Insert(cmdStr2);

            if (influencedLines == 1)
            {
                // 将注册窗口的DialogResult设为OK
                this.DialogResult = DialogResult.OK;

                // 提示用户注册成功，关闭注册窗口，显示登录窗口
                MessageBox.Show("房源发布成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("数据库操作出现错误，请重试！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
