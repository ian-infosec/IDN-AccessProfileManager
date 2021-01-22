using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Access_Profile_Manager
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            txtOrgName.Text = ConfigurationManager.AppSettings["OrgName"].ToString();
            txtClientID.Text = ConfigurationManager.AppSettings["ClientID"].ToString();
            txtClientSecret.Text = ConfigurationManager.AppSettings["ClientSecret"].ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["OrgName"].Value = txtOrgName.Text.ToString();
            config.AppSettings.Settings["ClientID"].Value = txtClientID.Text.ToString();
            config.AppSettings.Settings["ClientSecret"].Value = txtClientSecret.Text.ToString();

            config.Save();
            ConfigurationManager.RefreshSection("appSettings");

            this.Close();
        }
    }
}
