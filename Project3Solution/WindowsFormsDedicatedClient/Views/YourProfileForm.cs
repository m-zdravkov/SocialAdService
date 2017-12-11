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
using WindowsFormsDedicatedClient.Models;
using WindowsFormsDedicatedClient.SaServicePrivate;

namespace WindowsFormsDedicatedClient.Views
{
    public partial class YourProfileForm : Form
    {
        public YourProfileForm()
        {
            InitializeComponent();
            DisplayUser(AuthHelper.CurrentUserDetails);
            AddAds(PanelReservedAds, AdController.GetReservedAds().ToShortAdUcList());
            AddAds(PanelYourAds, AdController.GetPostedAds().ToShortAdUcList());
        }

        private void DisplayUser(User user)
        {
            LblUserName.Text = user.Name;
            LblUserEmail.Text = user.Email;
            LblReservations.Text = user.Reservations.ToString();
            LblBoosts.Text = user.Boosts.ToString();
            LblDateRegistered.Text = user.DateRegistered.ToString();
        }

        public void UpdateDisplay()
        {
            DisplayUser(AuthController.GetUpdatedCurrentUserDetails());
            AddAds(PanelReservedAds, AdController.GetReservedAds().ToShortAdUcList());
            AddAds(PanelYourAds, AdController.GetPostedAds().ToShortAdUcList());
        }

        private void AddAds(Panel panel, ShortAdUserControl[] list, bool clearFirst = true)
        {
            if (clearFirst)
                panel.Controls.Clear();

            if(list != null)
            {
                foreach (var ad in list)
                {
                    panel.Controls.Add(ad);
                }
            }
        }
    }
}
