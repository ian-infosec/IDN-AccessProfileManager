using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharp_IDN_Helper;
using Newtonsoft.Json.Linq;

namespace Access_Profile_Manager
{
    public partial class APManagerForm : Form
    {
        IDN_Helper_Authentication authentication;
        IDN_Helper_AccessProfiles sourceAccessProfiles = new IDN_Helper_AccessProfiles();
        JArray accessProfileEntitlementArray;
        JObject accessProfileDetails;
        
        public APManagerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //IDN_Helper_Sources sources = new IDN_Helper_Sources();
            //IDN_Helper idnHelper = new IDN_Helper(authentication);

            dgView.ColumnCount = 2;
            dgView.Columns[0].Name = "Name";
            dgView.Columns[1].Name = "ID";
        }

        private void btnLoadEntitlements_Click(object sender, EventArgs e)
        {
            try
            {
                authentication = new IDN_Helper_Authentication("client_credentials", ConfigurationManager.AppSettings["ClientID"].ToString(), ConfigurationManager.AppSettings["ClientSecret"].ToString(), ConfigurationManager.AppSettings["OrgName"].ToString());


                dgView.Rows.Clear();
                JArray entitlementArray = sourceAccessProfiles.Get_AccessProfileEntitlements(authentication, txtAPID.Text.ToString());
                accessProfileDetails = sourceAccessProfiles.Get_AccessProfileDetails(authentication, txtAPID.Text.ToString());

                lblAPName.Text = accessProfileDetails["name"].ToString();
                lblAPDescription.Text = accessProfileDetails["description"].ToString();
                lblSourceName.Text = accessProfileDetails["sourceName"].ToString();
                accessProfileEntitlementArray = (JArray)accessProfileDetails["entitlements"];

                foreach (JValue entitlement in accessProfileEntitlementArray)
                {
                    Console.WriteLine(entitlement.ToString());
                }

                string[] row;

                foreach (JObject entitlement in entitlementArray)
                {
                    row = new string[] { entitlement["displayName"].ToString(), entitlement["id"].ToString() };
                    dgView.Rows.Add(row);

                }
            }
            catch
            {
                MessageBox.Show("Something went terribly wrong loading entitlements");
            }
        }

        private void btnRemoveEntitlement_Click(object sender, EventArgs e)
        {
            try
            {
                string strRemovalItem = txtRemoveEntitlement.Text.ToString();
                int removalIndex = -1;
                int count = 0;

                foreach (JValue entitlement in accessProfileEntitlementArray)
                {
                    if (entitlement.ToString() == strRemovalItem)
                    {
                        Console.WriteLine("Attempting a Removal");
                        removalIndex = count;
                    }
                    count++;
                }

                accessProfileEntitlementArray.RemoveAt(removalIndex);

                foreach (JValue entitlement in accessProfileEntitlementArray)
                {
                    Console.WriteLine(entitlement.ToString());
                }

                sourceAccessProfiles.Patch_AccesProfile(authentication, accessProfileEntitlementArray, accessProfileDetails["id"].ToString());

            }
            catch
            {
                MessageBox.Show("Something went terribly wrong");
            }
            txtRemoveEntitlement.Clear();

        }

        private void btnAddEntitlement_Click(object sender, EventArgs e)
        {
            string additionalItem = txtAdditionalEntitlement.Text.ToString();
            JToken itemToAdd = additionalItem;
            accessProfileEntitlementArray.Add(itemToAdd);

            foreach (JValue entitlement in accessProfileEntitlementArray)
            {
                Console.WriteLine(entitlement.ToString());
            }

            sourceAccessProfiles.Patch_AccesProfile(authentication, accessProfileEntitlementArray, accessProfileDetails["id"].ToString());

            txtAdditionalEntitlement.Clear();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Preferences().Show();
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dgView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (value is DBNull) { return; }

            Clipboard.SetText(value.ToString());
            lblClipboardNotice.Text = value.ToString() + " in clipboard";
        }
    }
}
