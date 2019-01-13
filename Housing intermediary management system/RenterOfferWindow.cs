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
    public partial class RenterOfferWindow : Form
    {
        private string _houseId;
        private string _account;
        public RenterOfferWindow(string houseId,string account)
        {
            InitializeComponent();
            this._houseId = houseId;
            this._account = account;
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            // 通过当前用户账号查询出用户Id
            string cmdStr = "Select Rid From Renter Where Raccount = '" + _account + "';";
            int id = SqlHelper.ExecuteScalar(cmdStr);

            if (string.IsNullOrWhiteSpace(this.txtboxOffer.Text))
            {
                MessageBox.Show("报价文本框不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 根据房屋id 将房屋的报价设为目标值，同时将房屋的状态设为有意向
            // 拼接Sql语句
            string cmdstr = "Update Room Set offerPrice=" + txtboxOffer.Text.Trim() + ", houseState =" + 2.ToString() + ", renterId="+id+" Where houseId=" + _houseId;
            int influencedLines = SqlHelper.Update(cmdstr);
            if (influencedLines == 1)
            {
                // 将注册窗口的DialogResult设为OK
                this.DialogResult = DialogResult.OK;

                // 提示用户提交报价成功
                MessageBox.Show("报价已经提交，请等待房主回复！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
