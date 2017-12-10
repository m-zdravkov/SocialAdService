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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TbComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPostComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(435, 240);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // TbComment
            // 
            this.TbComment.Location = new System.Drawing.Point(13, 281);
            this.TbComment.Multiline = true;
            this.TbComment.Name = "TbComment";
            this.TbComment.Size = new System.Drawing.Size(435, 68);
            this.TbComment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your comment";
            // 
            // btnPostComment
            // 
            this.btnPostComment.Location = new System.Drawing.Point(373, 355);
            this.btnPostComment.Name = "btnPostComment";
            this.btnPostComment.Size = new System.Drawing.Size(75, 23);
            this.btnPostComment.TabIndex = 3;
            this.btnPostComment.Text = "Post";
            this.btnPostComment.UseVisualStyleBackColor = true;
            // 
            // FormAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.btnPostComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbComment);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormAd";
            this.Text = "AdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TbComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPostComment;
    }
}