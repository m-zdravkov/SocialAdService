using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MvcClient
{
    public partial class Search : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dmai0916_200938ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string find = "select [Title],[Content] from Post where (Title like '%' + @title + '%' or Content like '&' + @content + '%') ";
            SqlCommand comm = new SqlCommand(find, con);

            comm.Parameters.Add("@title", SqlDbType.NVarChar).Value = TextBox1.Text;
            comm.Parameters.Add("@content", SqlDbType.NVarChar).Value = TextBox1.Text;

            con.Open();
            comm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;
            DataSet ds = new DataSet();
            da.Fill(ds, "Title");
            da.Fill(ds, "Content");
            GridView1.DataSource = ds;
            GridView1.DataBind();

            con.Close();
        }
    }
}