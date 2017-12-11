namespace WindowsFormsDedicatedClient.Views
{
    partial class ShortAdUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(102, 24);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Title of ad";
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(2, 54);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(75, 23);
            this.BtnView.TabIndex = 1;
            this.BtnView.Text = "View full ad";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Posted on";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblDate.Location = new System.Drawing.Point(55, 38);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(49, 13);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "00.00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(101, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "at";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblTime.Location = new System.Drawing.Point(113, 38);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(53, 13);
            this.LblTime.TabIndex = 5;
            this.LblTime.Text = "00:00 AM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(172, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "in";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLocation.Location = new System.Drawing.Point(184, 38);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(48, 13);
            this.LblLocation.TabIndex = 7;
            this.LblLocation.Text = "Location";
            // 
            // GroupBox
            // 
            this.GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox.Controls.Add(this.panel1);
            this.GroupBox.Location = new System.Drawing.Point(3, 3);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(366, 118);
            this.GroupBox.TabIndex = 8;
            this.GroupBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.BtnReserve);
            this.panel1.Controls.Add(this.LblAuthor);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.LblLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblTime);
            this.panel1.Controls.Add(this.BtnView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 102);
            this.panel1.TabIndex = 8;
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblAuthor.Location = new System.Drawing.Point(3, 24);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 18;
            this.LblAuthor.Text = "Author";
            // 
            // BtnReserve
            // 
            this.BtnReserve.Location = new System.Drawing.Point(83, 54);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(75, 23);
            this.BtnReserve.TabIndex = 19;
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = true;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // ShortAdUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.GroupBox);
            this.Name = "ShortAdUserControl";
            this.Size = new System.Drawing.Size(372, 124);
            this.GroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Button BtnReserve;
    }
}
