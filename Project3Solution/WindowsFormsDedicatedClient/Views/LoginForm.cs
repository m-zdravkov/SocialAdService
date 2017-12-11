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
using WindowsFormsDedicatedClient.Models;

namespace WindowsFormsDedicatedClient.Views
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ViewController.LogIn(new LoginViewModel
            {
                Email = TbEmail.Text,
                Password = TbPassword.Text
            });
        }
    }
}
