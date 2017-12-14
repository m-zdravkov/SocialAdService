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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if(TbPassword.Text != TbName.Text)
            {
                MessageBox.Show("Password confirmation doesn't match password!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AuthController.SignUp(new SignupViewModel
            {
                Email = TbEmail.Text,
                Password = TbPassword.Text,
                Name = TbName.Text,
            });

            this.Close();
        }
    }
}
