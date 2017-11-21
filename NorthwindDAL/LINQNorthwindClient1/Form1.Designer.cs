namespace LINQNorthwindClient1
{
    partial class Form1
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
            this.lblproductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.bthGetProduct = new System.Windows.Forms.Button();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.txtProductDetails = new System.Windows.Forms.TextBox();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.bthUpdateprice = new System.Windows.Forms.Button();
            this.lblUpdateResult = new System.Windows.Forms.Label();
            this.txtUpdateResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblproductID
            // 
            this.lblproductID.AutoSize = true;
            this.lblproductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblproductID.Location = new System.Drawing.Point(25, 35);
            this.lblproductID.Name = "lblproductID";
            this.lblproductID.Size = new System.Drawing.Size(81, 20);
            this.lblproductID.TabIndex = 0;
            this.lblproductID.Text = "ProductID";
            this.lblproductID.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(128, 35);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(165, 20);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bthGetProduct
            // 
            this.bthGetProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bthGetProduct.Location = new System.Drawing.Point(322, 32);
            this.bthGetProduct.Name = "bthGetProduct";
            this.bthGetProduct.Size = new System.Drawing.Size(163, 27);
            this.bthGetProduct.TabIndex = 2;
            this.bthGetProduct.Text = "Get product details";
            this.bthGetProduct.UseVisualStyleBackColor = true;
            this.bthGetProduct.Click += new System.EventHandler(this.bthGetProduct_Click);
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductDetails.Location = new System.Drawing.Point(24, 71);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(117, 20);
            this.lblProductDetails.TabIndex = 3;
            this.lblProductDetails.Text = "Product Details";
            // 
            // txtProductDetails
            // 
            this.txtProductDetails.Location = new System.Drawing.Point(28, 94);
            this.txtProductDetails.Multiline = true;
            this.txtProductDetails.Name = "txtProductDetails";
            this.txtProductDetails.Size = new System.Drawing.Size(456, 163);
            this.txtProductDetails.TabIndex = 4;
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNewPrice.Location = new System.Drawing.Point(24, 270);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(79, 20);
            this.lblNewPrice.TabIndex = 5;
            this.lblNewPrice.Text = "New Price";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(128, 272);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(165, 20);
            this.txtNewPrice.TabIndex = 6;
            // 
            // bthUpdateprice
            // 
            this.bthUpdateprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bthUpdateprice.Location = new System.Drawing.Point(322, 265);
            this.bthUpdateprice.Name = "bthUpdateprice";
            this.bthUpdateprice.Size = new System.Drawing.Size(163, 30);
            this.bthUpdateprice.TabIndex = 7;
            this.bthUpdateprice.Text = "Update Price";
            this.bthUpdateprice.UseVisualStyleBackColor = true;
            this.bthUpdateprice.Click += new System.EventHandler(this.bthUpdateprice_Click);
            // 
            // lblUpdateResult
            // 
            this.lblUpdateResult.AutoSize = true;
            this.lblUpdateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUpdateResult.ForeColor = System.Drawing.Color.Crimson;
            this.lblUpdateResult.Location = new System.Drawing.Point(24, 309);
            this.lblUpdateResult.Name = "lblUpdateResult";
            this.lblUpdateResult.Size = new System.Drawing.Size(112, 20);
            this.lblUpdateResult.TabIndex = 8;
            this.lblUpdateResult.Text = "Update Result";
            // 
            // txtUpdateResult
            // 
            this.txtUpdateResult.Location = new System.Drawing.Point(29, 333);
            this.txtUpdateResult.Multiline = true;
            this.txtUpdateResult.Name = "txtUpdateResult";
            this.txtUpdateResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpdateResult.Size = new System.Drawing.Size(456, 64);
            this.txtUpdateResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 419);
            this.Controls.Add(this.txtUpdateResult);
            this.Controls.Add(this.lblUpdateResult);
            this.Controls.Add(this.bthUpdateprice);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.txtProductDetails);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.bthGetProduct);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblproductID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button bthGetProduct;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.TextBox txtProductDetails;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Button bthUpdateprice;
        private System.Windows.Forms.Label lblUpdateResult;
        private System.Windows.Forms.TextBox txtUpdateResult;
    }
}

