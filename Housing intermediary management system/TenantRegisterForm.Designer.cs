namespace Housing_intermediary_management_system
{
    partial class TenantRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbtnCancel = new System.Windows.Forms.Button();
            this.TbtnRegister = new System.Windows.Forms.Button();
            this.TtxtboxPhone = new System.Windows.Forms.TextBox();
            this.TtxtboxName = new System.Windows.Forms.TextBox();
            this.TtxtboxPasswordComfirmed = new System.Windows.Forms.TextBox();
            this.TtxtboxPassword = new System.Windows.Forms.TextBox();
            this.TtxtboxAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbtnCancel
            // 
            this.TbtnCancel.Location = new System.Drawing.Point(285, 311);
            this.TbtnCancel.Name = "TbtnCancel";
            this.TbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.TbtnCancel.TabIndex = 28;
            this.TbtnCancel.Text = "取消";
            this.TbtnCancel.UseVisualStyleBackColor = true;
            this.TbtnCancel.Click += new System.EventHandler(this.TbtnCancel_Click);
            // 
            // TbtnRegister
            // 
            this.TbtnRegister.Location = new System.Drawing.Point(130, 312);
            this.TbtnRegister.Name = "TbtnRegister";
            this.TbtnRegister.Size = new System.Drawing.Size(75, 23);
            this.TbtnRegister.TabIndex = 27;
            this.TbtnRegister.Text = "注册";
            this.TbtnRegister.UseVisualStyleBackColor = true;
            this.TbtnRegister.Click += new System.EventHandler(this.TbtnRegister_Click);
            // 
            // TtxtboxPhone
            // 
            this.TtxtboxPhone.Location = new System.Drawing.Point(187, 209);
            this.TtxtboxPhone.Name = "TtxtboxPhone";
            this.TtxtboxPhone.Size = new System.Drawing.Size(177, 21);
            this.TtxtboxPhone.TabIndex = 22;
            // 
            // TtxtboxName
            // 
            this.TtxtboxName.Location = new System.Drawing.Point(187, 184);
            this.TtxtboxName.Name = "TtxtboxName";
            this.TtxtboxName.Size = new System.Drawing.Size(177, 21);
            this.TtxtboxName.TabIndex = 23;
            // 
            // TtxtboxPasswordComfirmed
            // 
            this.TtxtboxPasswordComfirmed.Location = new System.Drawing.Point(187, 154);
            this.TtxtboxPasswordComfirmed.Name = "TtxtboxPasswordComfirmed";
            this.TtxtboxPasswordComfirmed.Size = new System.Drawing.Size(177, 21);
            this.TtxtboxPasswordComfirmed.TabIndex = 24;
            // 
            // TtxtboxPassword
            // 
            this.TtxtboxPassword.Location = new System.Drawing.Point(187, 128);
            this.TtxtboxPassword.Name = "TtxtboxPassword";
            this.TtxtboxPassword.PasswordChar = '*';
            this.TtxtboxPassword.Size = new System.Drawing.Size(177, 21);
            this.TtxtboxPassword.TabIndex = 25;
            // 
            // TtxtboxAccount
            // 
            this.TtxtboxAccount.Location = new System.Drawing.Point(187, 102);
            this.TtxtboxAccount.Name = "TtxtboxAccount";
            this.TtxtboxAccount.Size = new System.Drawing.Size(177, 21);
            this.TtxtboxAccount.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "联系电话：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "昵称：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "确认密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "密码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(128, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "用户名：";
            // 
            // TenantRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.TbtnCancel);
            this.Controls.Add(this.TbtnRegister);
            this.Controls.Add(this.TtxtboxPhone);
            this.Controls.Add(this.TtxtboxName);
            this.Controls.Add(this.TtxtboxPasswordComfirmed);
            this.Controls.Add(this.TtxtboxPassword);
            this.Controls.Add(this.TtxtboxAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "TenantRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房主注册窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TenantRegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TbtnCancel;
        private System.Windows.Forms.Button TbtnRegister;
        private System.Windows.Forms.TextBox TtxtboxPhone;
        private System.Windows.Forms.TextBox TtxtboxName;
        private System.Windows.Forms.TextBox TtxtboxPasswordComfirmed;
        private System.Windows.Forms.TextBox TtxtboxPassword;
        private System.Windows.Forms.TextBox TtxtboxAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}