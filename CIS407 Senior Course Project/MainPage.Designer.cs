namespace CIS407_Senior_Course_Project
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkCustomerInformation = new System.Windows.Forms.LinkLabel();
            this.linkUserAccessInfo = new System.Windows.Forms.LinkLabel();
            this.linkQualityAssuranceChecklist = new System.Windows.Forms.LinkLabel();
            this.linkOrderInfo = new System.Windows.Forms.LinkLabel();
            this.linkInventoryInformation = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkCustomerInformation);
            this.panel1.Controls.Add(this.linkUserAccessInfo);
            this.panel1.Controls.Add(this.linkQualityAssuranceChecklist);
            this.panel1.Controls.Add(this.linkOrderInfo);
            this.panel1.Controls.Add(this.linkInventoryInformation);
            this.panel1.Location = new System.Drawing.Point(90, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 367);
            this.panel1.TabIndex = 0;
            // 
            // linkCustomerInformation
            // 
            this.linkCustomerInformation.AutoSize = true;
            this.linkCustomerInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkCustomerInformation.LinkColor = System.Drawing.Color.Black;
            this.linkCustomerInformation.Location = new System.Drawing.Point(132, 60);
            this.linkCustomerInformation.Name = "linkCustomerInformation";
            this.linkCustomerInformation.Size = new System.Drawing.Size(106, 13);
            this.linkCustomerInformation.TabIndex = 10;
            this.linkCustomerInformation.TabStop = true;
            this.linkCustomerInformation.Text = "Customer Information";
            // 
            // linkUserAccessInfo
            // 
            this.linkUserAccessInfo.AutoSize = true;
            this.linkUserAccessInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkUserAccessInfo.LinkColor = System.Drawing.Color.Black;
            this.linkUserAccessInfo.Location = new System.Drawing.Point(132, 325);
            this.linkUserAccessInfo.Name = "linkUserAccessInfo";
            this.linkUserAccessInfo.Size = new System.Drawing.Size(122, 13);
            this.linkUserAccessInfo.TabIndex = 9;
            this.linkUserAccessInfo.TabStop = true;
            this.linkUserAccessInfo.Text = "User Access Information";
            // 
            // linkQualityAssuranceChecklist
            // 
            this.linkQualityAssuranceChecklist.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkQualityAssuranceChecklist.AutoSize = true;
            this.linkQualityAssuranceChecklist.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkQualityAssuranceChecklist.LinkColor = System.Drawing.Color.Black;
            this.linkQualityAssuranceChecklist.Location = new System.Drawing.Point(132, 263);
            this.linkQualityAssuranceChecklist.Name = "linkQualityAssuranceChecklist";
            this.linkQualityAssuranceChecklist.Size = new System.Drawing.Size(138, 13);
            this.linkQualityAssuranceChecklist.TabIndex = 8;
            this.linkQualityAssuranceChecklist.TabStop = true;
            this.linkQualityAssuranceChecklist.Text = "Quality Assurance Checklist";
            this.linkQualityAssuranceChecklist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQualityAssuranceChecklist_LinkClicked);
            // 
            // linkOrderInfo
            // 
            this.linkOrderInfo.AutoSize = true;
            this.linkOrderInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkOrderInfo.LinkColor = System.Drawing.Color.Black;
            this.linkOrderInfo.Location = new System.Drawing.Point(132, 129);
            this.linkOrderInfo.Name = "linkOrderInfo";
            this.linkOrderInfo.Size = new System.Drawing.Size(88, 13);
            this.linkOrderInfo.TabIndex = 3;
            this.linkOrderInfo.TabStop = true;
            this.linkOrderInfo.Text = "Order Information";
            this.linkOrderInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPurchaseOrderInfo_LinkClicked);
            // 
            // linkInventoryInformation
            // 
            this.linkInventoryInformation.AutoSize = true;
            this.linkInventoryInformation.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkInventoryInformation.LinkColor = System.Drawing.Color.Black;
            this.linkInventoryInformation.Location = new System.Drawing.Point(132, 200);
            this.linkInventoryInformation.Name = "linkInventoryInformation";
            this.linkInventoryInformation.Size = new System.Drawing.Size(106, 13);
            this.linkInventoryInformation.TabIndex = 2;
            this.linkInventoryInformation.TabStop = true;
            this.linkInventoryInformation.Text = "Inventory Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 217);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Tag = "aaaadBBBBBBB";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.User1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkOrderInfo;
        private System.Windows.Forms.LinkLabel linkInventoryInformation;
        private System.Windows.Forms.LinkLabel linkQualityAssuranceChecklist;
        private System.Windows.Forms.LinkLabel linkUserAccessInfo;
        private System.Windows.Forms.LinkLabel linkCustomerInformation;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

