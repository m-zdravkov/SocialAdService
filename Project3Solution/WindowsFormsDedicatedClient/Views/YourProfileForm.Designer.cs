namespace WindowsFormsDedicatedClient.Views
{
    partial class YourProfileForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuyReservations = new System.Windows.Forms.Button();
            this.BtnBuyBoosts = new System.Windows.Forms.Button();
            this.LblReservations = new System.Windows.Forms.Label();
            this.LblBoosts = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDateRegistered = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PanelReservedAds = new System.Windows.Forms.Panel();
            this.PanelYourAds = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available reservations: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available boosts:";
            // 
            // BtnBuyReservations
            // 
            this.BtnBuyReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuyReservations.Location = new System.Drawing.Point(320, 11);
            this.BtnBuyReservations.Name = "BtnBuyReservations";
            this.BtnBuyReservations.Size = new System.Drawing.Size(106, 23);
            this.BtnBuyReservations.TabIndex = 2;
            this.BtnBuyReservations.Text = "Buy more!";
            this.BtnBuyReservations.UseVisualStyleBackColor = true;
            // 
            // BtnBuyBoosts
            // 
            this.BtnBuyBoosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuyBoosts.Location = new System.Drawing.Point(320, 34);
            this.BtnBuyBoosts.Name = "BtnBuyBoosts";
            this.BtnBuyBoosts.Size = new System.Drawing.Size(106, 23);
            this.BtnBuyBoosts.TabIndex = 3;
            this.BtnBuyBoosts.Text = "Buy more!";
            this.BtnBuyBoosts.UseVisualStyleBackColor = true;
            // 
            // LblReservations
            // 
            this.LblReservations.AutoSize = true;
            this.LblReservations.Location = new System.Drawing.Point(122, 16);
            this.LblReservations.Name = "LblReservations";
            this.LblReservations.Size = new System.Drawing.Size(13, 13);
            this.LblReservations.TabIndex = 4;
            this.LblReservations.Text = "0";
            // 
            // LblBoosts
            // 
            this.LblBoosts.AutoSize = true;
            this.LblBoosts.Location = new System.Drawing.Point(122, 39);
            this.LblBoosts.Name = "LblBoosts";
            this.LblBoosts.Size = new System.Drawing.Size(13, 13);
            this.LblBoosts.TabIndex = 5;
            this.LblBoosts.Text = "0";
            // 
            // LblUserName
            // 
            this.LblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(8, 9);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(114, 24);
            this.LblUserName.TabIndex = 7;
            this.LblUserName.Text = "User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblReservations);
            this.groupBox1.Controls.Add(this.LblBoosts);
            this.groupBox1.Controls.Add(this.BtnBuyBoosts);
            this.groupBox1.Controls.Add(this.BtnBuyReservations);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Extras";
            // 
            // LblUserEmail
            // 
            this.LblUserEmail.AutoSize = true;
            this.LblUserEmail.Location = new System.Drawing.Point(12, 33);
            this.LblUserEmail.Name = "LblUserEmail";
            this.LblUserEmail.Size = new System.Drawing.Size(62, 13);
            this.LblUserEmail.TabIndex = 10;
            this.LblUserEmail.Text = "user@email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Joined:";
            // 
            // LblDateRegistered
            // 
            this.LblDateRegistered.AutoSize = true;
            this.LblDateRegistered.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblDateRegistered.Location = new System.Drawing.Point(50, 46);
            this.LblDateRegistered.Name = "LblDateRegistered";
            this.LblDateRegistered.Size = new System.Drawing.Size(49, 13);
            this.LblDateRegistered.TabIndex = 12;
            this.LblDateRegistered.Text = "00.00.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.PanelReservedAds);
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 124);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your reserved ads";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.PanelYourAds);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 125);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Your ads";
            // 
            // PanelReservedAds
            // 
            this.PanelReservedAds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelReservedAds.AutoScroll = true;
            this.PanelReservedAds.Location = new System.Drawing.Point(7, 20);
            this.PanelReservedAds.Name = "PanelReservedAds";
            this.PanelReservedAds.Size = new System.Drawing.Size(419, 100);
            this.PanelReservedAds.TabIndex = 0;
            // 
            // PanelYourAds
            // 
            this.PanelYourAds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelYourAds.AutoScroll = true;
            this.PanelYourAds.Location = new System.Drawing.Point(7, 20);
            this.PanelYourAds.Name = "PanelYourAds";
            this.PanelYourAds.Size = new System.Drawing.Size(419, 100);
            this.PanelYourAds.TabIndex = 0;
            // 
            // YourProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(456, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblDateRegistered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblUserEmail);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.groupBox1);
            this.Name = "YourProfileForm";
            this.Text = "Your Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuyReservations;
        private System.Windows.Forms.Button BtnBuyBoosts;
        private System.Windows.Forms.Label LblReservations;
        private System.Windows.Forms.Label LblBoosts;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblUserEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDateRegistered;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel PanelReservedAds;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel PanelYourAds;
    }
}