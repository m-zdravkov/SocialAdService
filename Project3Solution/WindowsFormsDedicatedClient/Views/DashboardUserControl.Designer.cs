namespace WindowsFormsDedicatedClient.Views
{
    partial class DashboardUserControl
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
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUserEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(3, 3);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(75, 23);
            this.BtnLogOut.TabIndex = 0;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnProfile
            // 
            this.BtnProfile.Location = new System.Drawing.Point(84, 3);
            this.BtnProfile.Name = "BtnProfile";
            this.BtnProfile.Size = new System.Drawing.Size(75, 23);
            this.BtnProfile.TabIndex = 1;
            this.BtnProfile.Text = "Profile";
            this.BtnProfile.UseVisualStyleBackColor = true;
            this.BtnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logged in as:";
            // 
            // LblUserEmail
            // 
            this.LblUserEmail.AutoSize = true;
            this.LblUserEmail.Location = new System.Drawing.Point(242, 8);
            this.LblUserEmail.Name = "LblUserEmail";
            this.LblUserEmail.Size = new System.Drawing.Size(62, 13);
            this.LblUserEmail.TabIndex = 3;
            this.LblUserEmail.Text = "user@email";
            // 
            // DashboardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblUserEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProfile);
            this.Controls.Add(this.BtnLogOut);
            this.Name = "DashboardUserControl";
            this.Size = new System.Drawing.Size(377, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUserEmail;
    }
}
