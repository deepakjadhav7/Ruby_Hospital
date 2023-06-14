
namespace Ruby_Hospital
{
    partial class MSI_REPORT
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
            this.panel_admin_misReport = new System.Windows.Forms.Panel();
            this.btnipdadmin = new System.Windows.Forms.Button();
            this.btnreferrallist = new System.Windows.Forms.Button();
            this.btnbillingadmin = new System.Windows.Forms.Button();
            this.btnopdd = new System.Windows.Forms.Button();
            this.panel_admin_misReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_admin_misReport
            // 
            this.panel_admin_misReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_admin_misReport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_admin_misReport.Controls.Add(this.btnipdadmin);
            this.panel_admin_misReport.Controls.Add(this.btnreferrallist);
            this.panel_admin_misReport.Controls.Add(this.btnbillingadmin);
            this.panel_admin_misReport.Controls.Add(this.btnopdd);
            this.panel_admin_misReport.Location = new System.Drawing.Point(0, -1);
            this.panel_admin_misReport.Name = "panel_admin_misReport";
            this.panel_admin_misReport.Size = new System.Drawing.Size(233, 192);
            this.panel_admin_misReport.TabIndex = 7;
            // 
            // btnipdadmin
            // 
            this.btnipdadmin.FlatAppearance.BorderSize = 0;
            this.btnipdadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnipdadmin.ForeColor = System.Drawing.Color.White;
            this.btnipdadmin.Location = new System.Drawing.Point(0, 47);
            this.btnipdadmin.Name = "btnipdadmin";
            this.btnipdadmin.Size = new System.Drawing.Size(225, 47);
            this.btnipdadmin.TabIndex = 1;
            this.btnipdadmin.Text = "IPD";
            this.btnipdadmin.UseVisualStyleBackColor = true;
            // 
            // btnreferrallist
            // 
            this.btnreferrallist.FlatAppearance.BorderSize = 0;
            this.btnreferrallist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreferrallist.ForeColor = System.Drawing.Color.White;
            this.btnreferrallist.Location = new System.Drawing.Point(0, 134);
            this.btnreferrallist.Name = "btnreferrallist";
            this.btnreferrallist.Size = new System.Drawing.Size(225, 50);
            this.btnreferrallist.TabIndex = 3;
            this.btnreferrallist.Text = "Referral list";
            this.btnreferrallist.UseVisualStyleBackColor = true;
            // 
            // btnbillingadmin
            // 
            this.btnbillingadmin.FlatAppearance.BorderSize = 0;
            this.btnbillingadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbillingadmin.ForeColor = System.Drawing.Color.White;
            this.btnbillingadmin.Location = new System.Drawing.Point(0, 91);
            this.btnbillingadmin.Name = "btnbillingadmin";
            this.btnbillingadmin.Size = new System.Drawing.Size(225, 47);
            this.btnbillingadmin.TabIndex = 2;
            this.btnbillingadmin.Text = "Billing";
            this.btnbillingadmin.UseVisualStyleBackColor = true;
            // 
            // btnopdd
            // 
            this.btnopdd.FlatAppearance.BorderSize = 0;
            this.btnopdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopdd.ForeColor = System.Drawing.Color.White;
            this.btnopdd.Location = new System.Drawing.Point(0, 1);
            this.btnopdd.Name = "btnopdd";
            this.btnopdd.Size = new System.Drawing.Size(225, 47);
            this.btnopdd.TabIndex = 0;
            this.btnopdd.Text = "OPD ";
            this.btnopdd.UseVisualStyleBackColor = true;
            // 
            // MSI_REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 191);
            this.Controls.Add(this.panel_admin_misReport);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(7, 56);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MSI_REPORT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSI_REPORT";
            this.panel_admin_misReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_admin_misReport;
        private System.Windows.Forms.Button btnipdadmin;
        private System.Windows.Forms.Button btnreferrallist;
        private System.Windows.Forms.Button btnbillingadmin;
        private System.Windows.Forms.Button btnopdd;
    }
}