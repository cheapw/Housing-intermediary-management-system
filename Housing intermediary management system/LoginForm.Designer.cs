namespace Housing_intermediary_management_system
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboxUserType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtboxAccount = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F);
            this.label1.Location = new System.Drawing.Point(315, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户登录";
            // 
            // cboxUserType
            // 
            this.cboxUserType.BackColor = System.Drawing.SystemColors.Window;
            this.cboxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUserType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboxUserType.Font = new System.Drawing.Font("宋体", 15F);
            this.cboxUserType.FormattingEnabled = true;
            this.cboxUserType.Items.AddRange(new object[] {
            "租客",
            "房主",
            "管理员"});
            this.cboxUserType.Location = new System.Drawing.Point(305, 134);
            this.cboxUserType.Name = "cboxUserType";
            this.cboxUserType.Size = new System.Drawing.Size(221, 28);
            this.cboxUserType.TabIndex = 1;
            this.cboxUserType.Enter += new System.EventHandler(this.cboxUserType_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(190, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(190, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(190, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "密码：";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 15F);
            this.btnLogin.Location = new System.Drawing.Point(243, 295);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AutoSize = true;
            this.btnRegister.Font = new System.Drawing.Font("宋体", 15F);
            this.btnRegister.Location = new System.Drawing.Point(398, 295);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtboxAccount
            // 
            this.txtboxAccount.Font = new System.Drawing.Font("宋体", 15F);
            this.txtboxAccount.Location = new System.Drawing.Point(305, 176);
            this.txtboxAccount.Name = "txtboxAccount";
            this.txtboxAccount.Size = new System.Drawing.Size(221, 30);
            this.txtboxAccount.TabIndex = 7;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("宋体", 15F);
            this.txtboxPassword.Location = new System.Drawing.Point(305, 220);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(221, 30);
            this.txtboxPassword.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 376);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxAccount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxUserType);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtboxAccount;
        private System.Windows.Forms.TextBox txtboxPassword;
    }
}

