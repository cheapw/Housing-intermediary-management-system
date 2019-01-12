namespace Housing_intermediary_management_system
{
    partial class AdminRegisterForm
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
            this.AtxtboxPasswordComfirmed = new System.Windows.Forms.TextBox();
            this.AtxtboxPassword = new System.Windows.Forms.TextBox();
            this.AtxtboxAccount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbtnCancel
            // 
            this.TbtnCancel.Location = new System.Drawing.Point(262, 300);
            this.TbtnCancel.Name = "TbtnCancel";
            this.TbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.TbtnCancel.TabIndex = 40;
            this.TbtnCancel.Text = "取消";
            this.TbtnCancel.UseVisualStyleBackColor = true;
            this.TbtnCancel.Click += new System.EventHandler(this.TbtnCancel_Click);
            // 
            // TbtnRegister
            // 
            this.TbtnRegister.Location = new System.Drawing.Point(103, 300);
            this.TbtnRegister.Name = "TbtnRegister";
            this.TbtnRegister.Size = new System.Drawing.Size(75, 23);
            this.TbtnRegister.TabIndex = 39;
            this.TbtnRegister.Text = "注册";
            this.TbtnRegister.UseVisualStyleBackColor = true;
            this.TbtnRegister.Click += new System.EventHandler(this.TbtnRegister_Click);
            // 
            // AtxtboxPasswordComfirmed
            // 
            this.AtxtboxPasswordComfirmed.Location = new System.Drawing.Point(160, 161);
            this.AtxtboxPasswordComfirmed.Name = "AtxtboxPasswordComfirmed";
            this.AtxtboxPasswordComfirmed.Size = new System.Drawing.Size(177, 21);
            this.AtxtboxPasswordComfirmed.TabIndex = 36;
            // 
            // AtxtboxPassword
            // 
            this.AtxtboxPassword.Location = new System.Drawing.Point(160, 135);
            this.AtxtboxPassword.Name = "AtxtboxPassword";
            this.AtxtboxPassword.PasswordChar = '*';
            this.AtxtboxPassword.Size = new System.Drawing.Size(177, 21);
            this.AtxtboxPassword.TabIndex = 37;
            // 
            // AtxtboxAccount
            // 
            this.AtxtboxAccount.Location = new System.Drawing.Point(160, 109);
            this.AtxtboxAccount.Name = "AtxtboxAccount";
            this.AtxtboxAccount.Size = new System.Drawing.Size(177, 21);
            this.AtxtboxAccount.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "确认密码：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "密码：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "用户名：";
            // 
            // AdminRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.TbtnCancel);
            this.Controls.Add(this.TbtnRegister);
            this.Controls.Add(this.AtxtboxPasswordComfirmed);
            this.Controls.Add(this.AtxtboxPassword);
            this.Controls.Add(this.AtxtboxAccount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Name = "AdminRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员注册窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminRegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TbtnCancel;
        private System.Windows.Forms.Button TbtnRegister;
        private System.Windows.Forms.TextBox AtxtboxPasswordComfirmed;
        private System.Windows.Forms.TextBox AtxtboxPassword;
        private System.Windows.Forms.TextBox AtxtboxAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}