using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDedicatedClient.Controllers;
using WindowsFormsDedicatedClient.Helpers;
using WindowsFormsDedicatedClient.SaServicePrivate;

namespace WindowsFormsDedicatedClient.Views
{
    public partial class PostAdForm : Form
    {
        public PostAdForm()
        {
            InitializeComponent();
            DetermineLoggedIn();
            CbCategory.DataSource = Enum.GetValues(typeof(AdType));
        }

        public void DetermineLoggedIn()
        {
            if(AuthHelper.IsLoggedIn())
            {
                BtnPost.Enabled = true;
            }
            else
            {
                BtnPost.Enabled = false;
            }
        }

        private void BtnPost_Click(object sender, EventArgs e)
        {
            if(TbLocation.Text.Length < 3)
            {
                MessageBox.Show("Location must be specified.", "Invalid ad",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(RtbContent.Text.Length == 0)
            {
                MessageBox.Show("Ad must have text.", "Invalid ad",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(TbTitle.Text.Length == 0)
            {
                MessageBox.Show("Ad must have a title.", "Invalid ad",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AdType type = AdType.Other;
            Enum.TryParse<AdType>(CbCategory.SelectedValue.ToString(), out type);

            AdController.PostAd(TbTitle.Text, RtbContent.Text, TbLocation.Text, type);
            this.Close();
        }
    }
}
