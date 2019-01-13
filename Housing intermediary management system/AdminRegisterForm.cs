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
    public partial class AdminRegisterForm : Form
    {
        public AdminRegisterForm()
        {
            InitializeComponent();
        }

        private void TbtnRegister_Click(object sender, EventArgs e)
        {
            #region 检验文本框输入是否为空
            if (string.IsNullOrWhiteSpace(this.AtxtboxAccount.Text))
            {
                MessageBox.Show("用户名不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.AtxtboxPassword.Text))
            {
                MessageBox.Show("密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.AtxtboxPasswordComfirmed.Text))
            {
                MessageBox.Show("请再次确认密码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion

            if (this.AtxtboxPassword.Text != this.AtxtboxPasswordComfirmed.Text)
            {
                MessageBox.Show("确认密码与第一次输入的密码不一致！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string account = this.AtxtboxAccount.Text.Trim();
            string password = this.AtxtboxPassword.Text.Trim();

            // 拼接Sql语句
            string cmdStr = string.Format("Insert Into Admin (Apassword,Aaccount)Values('{0}','{1}');", password, account);
            try
            {
                int influencedLines = SqlHelper.Insert(cmdStr);

                if (influencedLines==1)
                {
                    // 将注册窗口的DialogResult设为OK
                    this.DialogResult = DialogResult.OK;

                    // 提示用户注册成功，关闭注册窗口，显示登录窗口
                    MessageBox.Show("账号注册成功！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("数据库操作出现错误，请重试！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("执行Sql操作时出现错误，可能使用了系统中已有的用户名！\n请尝试使用其他用户名进行注册！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
