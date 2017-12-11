namespace WindowsFormsDedicatedClient
{
    partial class AdForm
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
            this.TbComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPostComment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RtbContent = new System.Windows.Forms.RichTextBox();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelComments = new System.Windows.Forms.Panel();
            this.BtnReserve = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblReservedBy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbComment
            // 
            this.TbComment.Location = new System.Drawing.Point(13, 368);
            this.TbComment.Multiline = true;
            this.TbComment.Name = "TbComment";
            this.TbComment.Size = new System.Drawing.Size(435, 68);
            this.TbComment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your comment";
            // 
            // btnPostComment
            // 
            this.btnPostComment.Location = new System.Drawing.Point(373, 442);
            this.btnPostComment.Name = "btnPostComment";
            this.btnPostComment.Size = new System.Drawing.Size(75, 23);
            this.btnPostComment.TabIndex = 3;
            this.btnPostComment.Text = "Post";
            this.btnPostComment.UseVisualStyleBackColor = true;
            this.btnPostComment.Click += new System.EventHandler(this.BtnPostComment_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.LblReservedBy);
            this.panel1.Controls.Add(this.RtbContent);
            this.panel1.Controls.Add(this.LblAuthor);
            this.panel1.Controls.Add(this.LblLocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LblTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 182);
            this.panel1.TabIndex = 4;
            // 
            // RtbContent
            // 
            this.RtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbContent.Location = new System.Drawing.Point(4, 54);
            this.RtbContent.Name = "RtbContent";
            this.RtbContent.ReadOnly = true;
            this.RtbContent.Size = new System.Drawing.Size(428, 123);
            this.RtbContent.TabIndex = 17;
            this.RtbContent.Text = "Ad content";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblAuthor.Location = new System.Drawing.Point(3, 24);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(38, 13);
            this.LblAuthor.TabIndex = 16;
            this.LblAuthor.Text = "Author";
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLocation.Location = new System.Drawing.Point(184, 38);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(48, 13);
            this.LblLocation.TabIndex = 13;
            this.LblLocation.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(172, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "in";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblDate.Location = new System.Drawing.Point(55, 38);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(49, 13);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = "00.00.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(101, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "at";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LblTime.Location = new System.Drawing.Point(113, 38);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(53, 13);
            this.LblTime.TabIndex = 11;
            this.LblTime.Text = "00:00 AM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Posted on";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PanelComments);
            this.groupBox1.Location = new System.Drawing.Point(13, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // PanelComments
            // 
            this.PanelComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelComments.AutoScroll = true;
            this.PanelComments.Location = new System.Drawing.Point(6, 12);
            this.PanelComments.Name = "PanelComments";
            this.PanelComments.Size = new System.Drawing.Size(420, 105);
            this.PanelComments.TabIndex = 0;
            // 
            // BtnReserve
            // 
            this.BtnReserve.Location = new System.Drawing.Point(326, 201);
            this.BtnReserve.Name = "BtnReserve";
            this.BtnReserve.Size = new System.Drawing.Size(119, 23);
            this.BtnReserve.TabIndex = 18;
            this.BtnReserve.Text = "Reserve";
            this.BtnReserve.UseVisualStyleBackColor = true;
            this.BtnReserve.Click += new System.EventHandler(this.BtnReserve_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(19, 201);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblReservedBy
            // 
            this.LblReservedBy.AutoSize = true;
            this.LblReservedBy.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LblReservedBy.Location = new System.Drawing.Point(303, 24);
            this.LblReservedBy.Name = "LblReservedBy";
            this.LblReservedBy.Size = new System.Drawing.Size(123, 13);
            this.LblReservedBy.TabIndex = 18;
            this.LblReservedBy.Text = "Reserved by User Name";
            this.LblReservedBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 477);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnReserve);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPostComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbComment);
            this.Name = "AdForm";
            this.Text = "AdForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPostComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RtbContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelComments;
        private System.Windows.Forms.Button BtnReserve;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblReservedBy;
    }
}