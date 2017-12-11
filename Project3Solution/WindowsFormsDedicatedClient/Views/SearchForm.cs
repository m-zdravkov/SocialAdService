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
using WindowsFormsDedicatedClient.SaServicePublic;

namespace WindowsFormsDedicatedClient
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            CbCategory.DataSource = Enum.GetValues(typeof(AdType));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AdType type = AdType.All;
            Enum.TryParse<AdType>(CbCategory.SelectedValue.ToString(), out type);
            ViewController.FindAds(TbSearch.Text, TbLocation.Text, type);
        }
    }
}
