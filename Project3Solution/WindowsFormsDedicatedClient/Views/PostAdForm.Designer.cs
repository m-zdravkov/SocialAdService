namespace WindowsFormsDedicatedClient.Views
{
    partial class PostAdForm
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
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.RtbContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(78, 59);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(256, 20);
            this.TbTitle.TabIndex = 2;
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(78, 6);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(256, 21);
            this.CbCategory.TabIndex = 3;
            // 
            // RtbContent
            // 
            this.RtbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbContent.Location = new System.Drawing.Point(78, 85);
            this.RtbContent.Name = "RtbContent";
            this.RtbContent.Size = new System.Drawing.Size(256, 123);
            this.RtbContent.TabIndex = 4;
            this.RtbContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your ad";
            // 
            // TbLocation
            // 
            this.TbLocation.Location = new System.Drawing.Point(78, 33);
            this.TbLocation.Name = "TbLocation";
            this.TbLocation.Size = new System.Drawing.Size(256, 20);
            this.TbLocation.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Location";
            // 
            // BtnPost
            // 
            this.BtnPost.Location = new System.Drawing.Point(78, 214);
            this.BtnPost.Name = "BtnPost";
            this.BtnPost.Size = new System.Drawing.Size(256, 23);
            this.BtnPost.TabIndex = 8;
            this.BtnPost.Text = "Post";
            this.BtnPost.UseVisualStyleBackColor = true;
            this.BtnPost.Click += new System.EventHandler(this.BtnPost_Click);
            // 
            // PostAdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 246);
            this.Controls.Add(this.BtnPost);
            this.Controls.Add(this.TbLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RtbContent);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PostAdForm";
            this.Text = "Post ad - Social Ad Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.RichTextBox RtbContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPost;
    }
}