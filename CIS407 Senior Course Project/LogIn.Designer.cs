namespace CIS407_Senior_Course_Project
{
    partial class LogIn
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.linkCustomerInformation = new System.Windows.Forms.LinkLabel();
            this.linkOrderInfo = new System.Windows.Forms.LinkLabel();
            this.linkInventoryInformation = new System.Windows.Forms.LinkLabel();
            this.linkUserAccessInfo = new System.Windows.Forms.LinkLabel();
            this.linkQualityAssuranceChecklist = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkCustomerInformation
            // 
            this.linkCustomerInformation.AutoSize = true;
            this.linkCustomerInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCustomerInformation.LinkColor = System.Drawing.Color.Black;
            this.linkCustomerInformation.Location = new System.Drawing.Point(107, 84);
            this.linkCustomerInformation.Name = "linkCustomerInformation";
            this.linkCustomerInformation.Size = new System.Drawing.Size(106, 13);
            this.linkCustomerInformation.TabIndex = 2;
            this.linkCustomerInformation.TabStop = true;
            this.linkCustomerInformation.Text = "Customer Information";
            // 
            // linkOrderInfo
            // 
            this.linkOrderInfo.AutoSize = true;
            this.linkOrderInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkOrderInfo.LinkColor = System.Drawing.Color.Black;
            this.linkOrderInfo.Location = new System.Drawing.Point(107, 142);
            this.linkOrderInfo.Name = "linkOrderInfo";
            this.linkOrderInfo.Size = new System.Drawing.Size(88, 13);
            this.linkOrderInfo.TabIndex = 4;
            this.linkOrderInfo.TabStop = true;
            this.linkOrderInfo.Text = "Order Information";
            // 
            // linkInventoryInformation
            // 
            this.linkInventoryInformation.AutoSize = true;
            this.linkInventoryInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkInventoryInformation.LinkColor = System.Drawing.Color.Black;
            this.linkInventoryInformation.Location = new System.Drawing.Point(107, 204);
            this.linkInventoryInformation.Name = "linkInventoryInformation";
            this.linkInventoryInformation.Size = new System.Drawing.Size(106, 13);
            this.linkInventoryInformation.TabIndex = 5;
            this.linkInventoryInformation.TabStop = true;
            this.linkInventoryInformation.Text = "Inventory Information";
            // 
            // linkUserAccessInfo
            // 
            this.linkUserAccessInfo.AutoSize = true;
            this.linkUserAccessInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkUserAccessInfo.LinkColor = System.Drawing.Color.Black;
            this.linkUserAccessInfo.Location = new System.Drawing.Point(107, 267);
            this.linkUserAccessInfo.Name = "linkUserAccessInfo";
            this.linkUserAccessInfo.Size = new System.Drawing.Size(122, 13);
            this.linkUserAccessInfo.TabIndex = 6;
            this.linkUserAccessInfo.TabStop = true;
            this.linkUserAccessInfo.Text = "User Access Information";
            // 
            // linkQualityAssuranceChecklist
            // 
            this.linkQualityAssuranceChecklist.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkQualityAssuranceChecklist.AutoSize = true;
            this.linkQualityAssuranceChecklist.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkQualityAssuranceChecklist.LinkColor = System.Drawing.Color.Black;
            this.linkQualityAssuranceChecklist.Location = new System.Drawing.Point(107, 339);
            this.linkQualityAssuranceChecklist.Name = "linkQualityAssuranceChecklist";
            this.linkQualityAssuranceChecklist.Size = new System.Drawing.Size(138, 13);
            this.linkQualityAssuranceChecklist.TabIndex = 7;
            this.linkQualityAssuranceChecklist.TabStop = true;
            this.linkQualityAssuranceChecklist.Text = "Quality Assurance Checklist";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkQualityAssuranceChecklist);
            this.Controls.Add(this.linkUserAccessInfo);
            this.Controls.Add(this.linkInventoryInformation);
            this.Controls.Add(this.linkOrderInfo);
            this.Controls.Add(this.linkCustomerInformation);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.LinkLabel linkCustomerInformation;
        private System.Windows.Forms.LinkLabel linkOrderInfo;
        private System.Windows.Forms.LinkLabel linkInventoryInformation;
        private System.Windows.Forms.LinkLabel linkUserAccessInfo;
        private System.Windows.Forms.LinkLabel linkQualityAssuranceChecklist;
    }
}