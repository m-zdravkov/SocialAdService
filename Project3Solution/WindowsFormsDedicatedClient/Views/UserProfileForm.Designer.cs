namespace WindowsFormsDedicatedClient.Views
{
    partial class UserProfileForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.BtnBuyReservations.Location = new System.Drawing.Point(266, 11);
            this.BtnBuyReservations.Name = "BtnBuyReservations";
            this.BtnBuyReservations.Size = new System.Drawing.Size(75, 23);
            this.BtnBuyReservations.TabIndex = 2;
            this.BtnBuyReservations.Text = "Buy more!";
            this.BtnBuyReservations.UseVisualStyleBackColor = true;
            // 
            // BtnBuyBoosts
            // 
            this.BtnBuyBoosts.Location = new System.Drawing.Point(266, 34);
            this.BtnBuyBoosts.Name = "BtnBuyBoosts";
            this.BtnBuyBoosts.Size = new System.Drawing.Size(75, 23);
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 169);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 154);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // LblUserName
            // 
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblReservations);
            this.groupBox1.Controls.Add(this.LblBoosts);
            this.groupBox1.Controls.Add(this.BtnBuyBoosts);
            this.groupBox1.Controls.Add(this.BtnBuyReservations);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Related ads";
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
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 334);
            this.Controls.Add(this.LblUserEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUserProfile";
            this.Text = "Your Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblUserEmail;
    }
}