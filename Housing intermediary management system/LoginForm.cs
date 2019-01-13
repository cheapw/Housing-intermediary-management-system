using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_intermediary_management_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // 注册按钮的点击事件
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // 判断是否选定了用户类型
            if (cboxUserType.SelectedItem==null)
            {
                MessageBox.Show("请选择用户类型后再进行注册操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 将下拉列表的背景设为醒目的红色
                this.cboxUserType.BackColor = Color.Red;
                return;
            }

            // 打开注册窗口，同时锁定登录窗口
            DialogResult dialogResult = ShowRegisterForm();
            // 根据返回的DialogResult判断注册操作是否被取消
            if (dialogResult!=DialogResult.OK)
            {
                MessageBox.Show("注册操作被取消！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 打开注册窗口方法,根据注册的成功与否从注册窗口返回一个DialogResult
        private DialogResult ShowRegisterForm()
        {
            switch (this.cboxUserType.Text)
            {
                case "租客":
                    RenterRegisterForm renter = new RenterRegisterForm();
                    DialogResult dialogFromRenter = renter.ShowDialog();
                    return dialogFromRenter;
                case "房主":
                    TenantRegisterForm tenant = new TenantRegisterForm();
                    DialogResult dialogFromTenant = tenant.ShowDialog();
                    return dialogFromTenant;
                case "管理员":
                    AdminRegisterForm admin = new AdminRegisterForm();
                    DialogResult dialogFromAdmin = admin.ShowDialog();
                    return dialogFromAdmin;
                default:
                    throw new Exception("未知用户类型！");
            }
        }

        // 用户类型选择下拉框获得焦点的事件
        private void cboxUserType_Enter(object sender, EventArgs e)
        {
            // 如果下拉框的背景为红色，则设为默认颜色
            if (this.cboxUserType.BackColor==Color.Red)
            {
                this.cboxUserType.BackColor = DefaultBackColor;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 判断是否选定了用户类型
            if (cboxUserType.SelectedItem == null)
            {
                MessageBox.Show("请选择用户类型后再进行注册操作！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 将下拉列表的背景设为醒目的红色
                this.cboxUserType.BackColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtboxAccount.Text))
            {
                MessageBox.Show("用户名不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtboxPassword.Text))
            {
                MessageBox.Show("密码不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string account = this.txtboxAccount.Text.Trim();
            string password = this.txtboxPassword.Text.Trim();

            // 登录
            Login(account, password);
        }

        private void Login(string account, string password)
        {
            string cmdStr = string.Empty;

            // 获取用户的类型, 根据类型确定SQL查询语句
            switch (this.cboxUserType.Text)
            {
                case "租客":
                    cmdStr=string.Format("Select Count(*) From Renter Where Rpassword='{0}' and Raccount='{1}';", password, account);
                    break;
                case "房主":
                    cmdStr = string.Format("Select Count(*) From Tenant Where Tpassword='{0}' and Taccount='{1}';", password, account);
                    break;
                case "管理员":
                    cmdStr = string.Format("Select Count(*) From Admin Where Apassword='{0}' and Aaccount='{1}';", password, account);
                    break;
                default:
                    throw new Exception("未知用户类型！");
            }


            int records = SqlHelper.VerifyLoginInfo(cmdStr);

            if (records == 1)
            {
                switch (this.cboxUserType.Text)
                {
                    case "租客":
                        RenterMain renter = new RenterMain(account);
                        this.Hide();
                        renter.Show();
                        break;
                    case "房主":
                        TenantMain tenant = new TenantMain(account);
                        this.Hide();
                        tenant.Show();
                        break;
                    case "管理员":
                        AdminMain admin = new AdminMain(account);
                        this.Hide();
                        admin.Show();
                        break;
                    default:
                        throw new Exception("未知用户类型！");
                }
                MessageBox.Show("登录成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("用户名或密码错误，亦或者系统连接配置出现问题，请重试！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
