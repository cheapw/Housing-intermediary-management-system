namespace Housing_intermediary_management_system
{
    partial class RenterRegisterForm
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
            this.RbtnCancel = new System.Windows.Forms.Button();
            this.RbtnRegister = new System.Windows.Forms.Button();
            this.RtxtboxPhone = new System.Windows.Forms.TextBox();
            this.RtxtboxName = new System.Windows.Forms.TextBox();
            this.RtxtboxPasswordComfirmed = new System.Windows.Forms.TextBox();
            this.RtxtboxPassword = new System.Windows.Forms.TextBox();
            this.RtxtboxAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RbtnCancel
            // 
            this.RbtnCancel.Location = new System.Drawing.Point(345, 305);
            this.RbtnCancel.Name = "RbtnCancel";
            this.RbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.RbtnCancel.TabIndex = 16;
            this.RbtnCancel.Text = "取消";
            this.RbtnCancel.UseVisualStyleBackColor = true;
            this.RbtnCancel.Click += new System.EventHandler(this.RbtnCancel_Click);
            // 
            // RbtnRegister
            // 
            this.RbtnRegister.Location = new System.Drawing.Point(190, 306);
            this.RbtnRegister.Name = "RbtnRegister";
            this.RbtnRegister.Size = new System.Drawing.Size(75, 23);
            this.RbtnRegister.TabIndex = 15;
            this.RbtnRegister.Text = "注册";
            this.RbtnRegister.UseVisualStyleBackColor = true;
            this.RbtnRegister.Click += new System.EventHandler(this.RbtnRegister_Click);
            // 
            // RtxtboxPhone
            // 
            this.RtxtboxPhone.Location = new System.Drawing.Point(247, 203);
            this.RtxtboxPhone.Name = "RtxtboxPhone";
            this.RtxtboxPhone.Size = new System.Drawing.Size(177, 21);
            this.RtxtboxPhone.TabIndex = 10;
            // 
            // RtxtboxName
            // 
            this.RtxtboxName.Location = new System.Drawing.Point(247, 178);
            this.RtxtboxName.Name = "RtxtboxName";
            this.RtxtboxName.Size = new System.Drawing.Size(177, 21);
            this.RtxtboxName.TabIndex = 11;
            // 
            // RtxtboxPasswordComfirmed
            // 
            this.RtxtboxPasswordComfirmed.Location = new System.Drawing.Point(247, 148);
            this.RtxtboxPasswordComfirmed.Name = "RtxtboxPasswordComfirmed";
            this.RtxtboxPasswordComfirmed.Size = new System.Drawing.Size(177, 21);
            this.RtxtboxPasswordComfirmed.TabIndex = 12;
            // 
            // RtxtboxPassword
            // 
            this.RtxtboxPassword.Location = new System.Drawing.Point(247, 122);
            this.RtxtboxPassword.Name = "RtxtboxPassword";
            this.RtxtboxPassword.PasswordChar = '*';
            this.RtxtboxPassword.Size = new System.Drawing.Size(177, 21);
            this.RtxtboxPassword.TabIndex = 13;
            // 
            // RtxtboxAccount
            // 
            this.RtxtboxAccount.Location = new System.Drawing.Point(247, 96);
            this.RtxtboxAccount.Name = "RtxtboxAccount";
            this.RtxtboxAccount.Size = new System.Drawing.Size(177, 21);
            this.RtxtboxAccount.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "联系电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "昵称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "确认密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名：";
            // 
            // RenterRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.RbtnCancel);
            this.Controls.Add(this.RbtnRegister);
            this.Controls.Add(this.RtxtboxPhone);
            this.Controls.Add(this.RtxtboxName);
            this.Controls.Add(this.RtxtboxPasswordComfirmed);
            this.Controls.Add(this.RtxtboxPassword);
            this.Controls.Add(this.RtxtboxAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RenterRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "租客注册窗口";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenterRegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RbtnCancel;
        private System.Windows.Forms.Button RbtnRegister;
        private System.Windows.Forms.TextBox RtxtboxPhone;
        private System.Windows.Forms.TextBox RtxtboxName;
        private System.Windows.Forms.TextBox RtxtboxPasswordComfirmed;
        private System.Windows.Forms.TextBox RtxtboxPassword;
        private System.Windows.Forms.TextBox RtxtboxAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}