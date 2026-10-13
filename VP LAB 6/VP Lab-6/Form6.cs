using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Lab_6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            cmbState.Items.Add("California");
            cmbState.Items.Add("Texas");
            cmbState.Items.Add("New York");
            cmbState.SelectedIndex = 0;
        }

        private void radOptionA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFeature_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                lstCountry.Items.Add(txtName.Text);

                // Add state to ComboBox if not already present
                string state = cmbState.Text;
                if (!cmbState.Items.Contains(state))
                {
                    cmbState.Items.Add(state);
                }

                txtName.Clear();
                txtName.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a name/country first!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCountry.SelectedIndex != -1)
            {
                lstCountry.Items.RemoveAt(lstCountry.SelectedIndex);
            }

            // Remove from ComboBox if something is selected
            if (cmbState.SelectedIndex != -1)
            {
                cmbState.Items.RemoveAt(cmbState.SelectedIndex);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            string details = "";

            // Get selected country
            if (lstCountry.SelectedIndex != -1)
                details += "Country: " + lstCountry.SelectedItem.ToString() + "\n";
            else
                details += "Country: None selected\n";

            // Get selected state
            if (cmbState.SelectedIndex != -1)
                details += "State: " + cmbState.SelectedItem.ToString() + "\n";
            else
                details += "State: None selected\n";

            // Get selected RadioButton
            if (radOptionA.Checked)
                details += "Option: A\n";
            else if (radOptionB.Checked)
                details += "Option: B\n";

            // Get CheckBox state
            details += "Feature Enabled: " + chkFeature.Checked.ToString();

            // Display all details
            lblResult.Text = details;
        }
    }
}
