namespace WindowsFormsDedicatedClient.Views
{
    partial class CommentUserControl
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
            this.LblAuthor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelComment = new System.Windows.Forms.Panel();
            this.RtbComment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDatePosted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTimePosted = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PanelComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(3, 0);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(52, 16);
            this.LblAuthor.TabIndex = 0;
            this.LblAuthor.Text = "Author";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PanelComment);
            this.groupBox1.Location = new System.Drawing.Point(4, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // PanelComment
            // 
            this.PanelComment.AutoScroll = true;
            this.PanelComment.Controls.Add(this.RtbComment);
            this.PanelComment.Location = new System.Drawing.Point(5, 9);
            this.PanelComment.Name = "PanelComment";
            this.PanelComment.Size = new System.Drawing.Size(320, 63);
            this.PanelComment.TabIndex = 0;
            // 
            // RtbComment
            // 
            this.RtbComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbComment.Location = new System.Drawing.Point(0, 4);
            this.RtbComment.Name = "RtbComment";
            this.RtbComment.ReadOnly = true;
            this.RtbComment.Size = new System.Drawing.Size(317, 56);
            this.RtbComment.TabIndex = 0;
            this.RtbComment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Posted on";
            // 
            // LblDatePosted
            // 
            this.LblDatePosted.AutoSize = true;
            this.LblDatePosted.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblDatePosted.Location = new System.Drawing.Point(55, 16);
            this.LblDatePosted.Name = "LblDatePosted";
            this.LblDatePosted.Size = new System.Drawing.Size(49, 13);
            this.LblDatePosted.TabIndex = 3;
            this.LblDatePosted.Text = "00.00.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(101, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "at";
            // 
            // LblTimePosted
            // 
            this.LblTimePosted.AutoSize = true;
            this.LblTimePosted.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblTimePosted.Location = new System.Drawing.Point(113, 16);
            this.LblTimePosted.Name = "LblTimePosted";
            this.LblTimePosted.Size = new System.Drawing.Size(53, 13);
            this.LblTimePosted.TabIndex = 5;
            this.LblTimePosted.Text = "00:00 AM";
            // 
            // CommentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.LblTimePosted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblDatePosted);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.groupBox1);
            this.Name = "CommentUserControl";
            this.Size = new System.Drawing.Size(338, 113);
            this.groupBox1.ResumeLayout(false);
            this.PanelComment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDatePosted;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTimePosted;
        private System.Windows.Forms.Panel PanelComment;
        private System.Windows.Forms.RichTextBox RtbComment;
    }
}
