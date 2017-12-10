namespace WindowsFormsDedicatedClient
{
    partial class HomeForm
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
            this.GbViewing = new System.Windows.Forms.GroupBox();
            this.RbOther = new System.Windows.Forms.RadioButton();
            this.RbEvents = new System.Windows.Forms.RadioButton();
            this.RbServiceRequests = new System.Windows.Forms.RadioButton();
            this.RbServiceOffers = new System.Windows.Forms.RadioButton();
            this.RbBuying = new System.Windows.Forms.RadioButton();
            this.RbSelling = new System.Windows.Forms.RadioButton();
            this.RbAll = new System.Windows.Forms.RadioButton();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelDashboard = new System.Windows.Forms.Panel();
            this.AdPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GbViewing.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbViewing
            // 
            this.GbViewing.Controls.Add(this.RbOther);
            this.GbViewing.Controls.Add(this.RbEvents);
            this.GbViewing.Controls.Add(this.RbServiceRequests);
            this.GbViewing.Controls.Add(this.RbServiceOffers);
            this.GbViewing.Controls.Add(this.RbBuying);
            this.GbViewing.Controls.Add(this.RbSelling);
            this.GbViewing.Controls.Add(this.RbAll);
            this.GbViewing.Location = new System.Drawing.Point(15, 37);
            this.GbViewing.Name = "GbViewing";
            this.GbViewing.Size = new System.Drawing.Size(122, 187);
            this.GbViewing.TabIndex = 2;
            this.GbViewing.TabStop = false;
            this.GbViewing.Text = "Viewing";
            // 
            // RbOther
            // 
            this.RbOther.AutoSize = true;
            this.RbOther.Location = new System.Drawing.Point(6, 161);
            this.RbOther.Name = "RbOther";
            this.RbOther.Size = new System.Drawing.Size(51, 17);
            this.RbOther.TabIndex = 6;
            this.RbOther.TabStop = true;
            this.RbOther.Text = "Other";
            this.RbOther.UseVisualStyleBackColor = true;
            // 
            // RbEvents
            // 
            this.RbEvents.AutoSize = true;
            this.RbEvents.Location = new System.Drawing.Point(6, 138);
            this.RbEvents.Name = "RbEvents";
            this.RbEvents.Size = new System.Drawing.Size(58, 17);
            this.RbEvents.TabIndex = 5;
            this.RbEvents.TabStop = true;
            this.RbEvents.Text = "Events";
            this.RbEvents.UseVisualStyleBackColor = true;
            // 
            // RbServiceRequests
            // 
            this.RbServiceRequests.AutoSize = true;
            this.RbServiceRequests.Location = new System.Drawing.Point(6, 115);
            this.RbServiceRequests.Name = "RbServiceRequests";
            this.RbServiceRequests.Size = new System.Drawing.Size(104, 17);
            this.RbServiceRequests.TabIndex = 4;
            this.RbServiceRequests.TabStop = true;
            this.RbServiceRequests.Text = "Service requests";
            this.RbServiceRequests.UseVisualStyleBackColor = true;
            // 
            // RbServiceOffers
            // 
            this.RbServiceOffers.AutoSize = true;
            this.RbServiceOffers.Location = new System.Drawing.Point(6, 91);
            this.RbServiceOffers.Name = "RbServiceOffers";
            this.RbServiceOffers.Size = new System.Drawing.Size(90, 17);
            this.RbServiceOffers.TabIndex = 3;
            this.RbServiceOffers.TabStop = true;
            this.RbServiceOffers.Text = "Service offers";
            this.RbServiceOffers.UseVisualStyleBackColor = true;
            // 
            // RbBuying
            // 
            this.RbBuying.AutoSize = true;
            this.RbBuying.Location = new System.Drawing.Point(6, 67);
            this.RbBuying.Name = "RbBuying";
            this.RbBuying.Size = new System.Drawing.Size(77, 17);
            this.RbBuying.TabIndex = 2;
            this.RbBuying.TabStop = true;
            this.RbBuying.Text = "Buying ads";
            this.RbBuying.UseVisualStyleBackColor = true;
            // 
            // RbSelling
            // 
            this.RbSelling.AutoSize = true;
            this.RbSelling.Location = new System.Drawing.Point(6, 43);
            this.RbSelling.Name = "RbSelling";
            this.RbSelling.Size = new System.Drawing.Size(76, 17);
            this.RbSelling.TabIndex = 1;
            this.RbSelling.TabStop = true;
            this.RbSelling.Text = "Selling ads";
            this.RbSelling.UseVisualStyleBackColor = true;
            // 
            // RbAll
            // 
            this.RbAll.AutoSize = true;
            this.RbAll.Location = new System.Drawing.Point(6, 19);
            this.RbAll.Name = "RbAll";
            this.RbAll.Size = new System.Drawing.Size(56, 17);
            this.RbAll.TabIndex = 0;
            this.RbAll.TabStop = true;
            this.RbAll.Text = "All ads";
            this.RbAll.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(15, 230);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(122, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // PanelDashboard
            // 
            this.PanelDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDashboard.Location = new System.Drawing.Point(12, 3);
            this.PanelDashboard.Name = "PanelDashboard";
            this.PanelDashboard.Size = new System.Drawing.Size(531, 28);
            this.PanelDashboard.TabIndex = 0;
            // 
            // AdPanel
            // 
            this.AdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdPanel.AutoScroll = true;
            this.AdPanel.Location = new System.Drawing.Point(143, 37);
            this.AdPanel.Name = "AdPanel";
            this.AdPanel.Size = new System.Drawing.Size(400, 246);
            this.AdPanel.TabIndex = 0;
            this.AdPanel.MouseEnter += new System.EventHandler(this.AdPanel_MouseEnter);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 295);
            this.Controls.Add(this.AdPanel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.GbViewing);
            this.Controls.Add(this.PanelDashboard);
            this.Name = "HomeForm";
            this.Text = "Social Ad Service for Windows";
            this.GbViewing.ResumeLayout(false);
            this.GbViewing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GbViewing;
        private System.Windows.Forms.RadioButton RbServiceRequests;
        private System.Windows.Forms.RadioButton RbServiceOffers;
        private System.Windows.Forms.RadioButton RbBuying;
        private System.Windows.Forms.RadioButton RbSelling;
        private System.Windows.Forms.RadioButton RbAll;
        private System.Windows.Forms.RadioButton RbOther;
        private System.Windows.Forms.RadioButton RbEvents;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel PanelDashboard;
        private System.Windows.Forms.FlowLayoutPanel AdPanel;
    }
}

