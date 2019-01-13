namespace Housing_intermediary_management_system
{
    partial class RenterOfferWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxOffer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(122, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入您的报价：";
            // 
            // txtboxOffer
            // 
            this.txtboxOffer.Font = new System.Drawing.Font("宋体", 15F);
            this.txtboxOffer.Location = new System.Drawing.Point(297, 75);
            this.txtboxOffer.Name = "txtboxOffer";
            this.txtboxOffer.Size = new System.Drawing.Size(212, 30);
            this.txtboxOffer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(515, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "元";
            // 
            // btnComfirm
            // 
            this.btnComfirm.AutoSize = true;
            this.btnComfirm.Font = new System.Drawing.Font("宋体", 12F);
            this.btnComfirm.Location = new System.Drawing.Point(178, 145);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(75, 26);
            this.btnComfirm.TabIndex = 2;
            this.btnComfirm.Text = "确认";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 12F);
            this.btnCancel.Location = new System.Drawing.Point(402, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RenterOfferWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.txtboxOffer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RenterOfferWindow";
            this.Text = "RenterOfferWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxOffer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}