using LINQNorthwindClient1.ServiceReference1;
using NorthwindDAL;
using LINQNorthwindClient1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQNorthwindClient1
{
    public partial class Form1 : Form
    {
        ServiceReference1.Product product;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bthGetProduct_Click(object sender, EventArgs e)
        {




            var client = new ProductServiceClient();
            string result = "";

            try
            {
                var productID = Int32.Parse(txtProductID.Text);
                 product = client.GetProduct(productID);

                var sb = new StringBuilder();
                sb.Append("ProductID:" +
                    product.ProductID.ToString() + "\r\n");
                sb.Append("ProductName:" +
                    product.ProductName + "\r\n");
                sb.Append("QuantityPerUnit:" +
                    product.QuantityPerUnit + "\r\n");
                sb.Append("UnitPrice:" +
                    product.UnitPrice.ToString() + "\r\n");
                sb.Append("Discontinued:" +
                    product.Discontinued.ToString() + "\r\n");
                sb.Append("RowVersion:");
                foreach (var x in product.RowVersion.AsEnumerable())
                {
                    sb.Append(x.ToString());
                    sb.Append(" ");
                }
                result = sb.ToString();
            }
            catch (TimeoutException ex)
            {
                result = "The service operation timed out. " +
                    ex.Message;
            }
            catch (FaultException<ProductFault> ex)
            {
                result = "ProductFault returned: " +
                    ex.Detail.FaultMessage;
            }
            catch (FaultException ex)
            {
                result = "Unknown Fault: " +
                    ex.ToString();
            }
            catch (CommunicationException ex)
            {
                result = "There was a communication problem. " +
                    ex.Message + ex.StackTrace;
            }
            catch (Exception ex)
            {
                result = "Other exception: " +
                    ex.Message + ex.StackTrace;
            }

            txtProductDetails.Text = result;
        }

        private void bthUpdateprice_Click(object sender, EventArgs e)
        {
         
                var result = "";
            
                if (product != null)
                {
                    try
                    {
                    // update its price
                    product.UnitPrice =
                           Decimal.Parse(txtNewPrice.Text);
                        var client = new ProductServiceClient();
                        var sb = new StringBuilder();
                        var message = "";
                        sb.Append("Price updated to ");
                        sb.Append(txtNewPrice.Text);
                        sb.Append("\r\n");
                        sb.Append("Update result:");
                        sb.Append(client.UpdateProduct(ref product,
                                  ref message).ToString());
                        sb.Append("\r\n");
                        sb.Append("Update message: ");
                        sb.Append(message);
                        sb.Append("\r\n");
                        sb.Append("New RowVersion:");
                        foreach (var x in product.RowVersion.AsEnumerable())
                        {
                            sb.Append(x.ToString());
                            sb.Append(" ");
                        }
                        result = sb.ToString();
                    }
                    catch (TimeoutException ex)
                    {
                        result = "The service operation timed out. " +
                                 ex.Message;
                    }
                    catch (FaultException<ProductFault> ex)
                    {
                        result = "ProductFault returned: " +
                                  ex.Detail.FaultMessage;
                    }
                    catch (FaultException ex)
                    {
                        result = "Unknown Fault: " +
                                  ex.ToString();
                    }
                    catch (CommunicationException ex)
                    {
                        result = "There was a communication problem. " +
                                 ex.Message + ex.StackTrace;
                    }
                    catch (Exception ex)
                    {
                        result = "Other exception: " +
                                  ex.Message + ex.StackTrace;
                    }
                }
                else
                {
                    result = "Get product details first";
                }

                txtUpdateResult.Text = result;
            }

        
    }
}
