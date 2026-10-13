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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                lstItems.Items.Add(txtInput.Text);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Please type something to add!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex != -1)
            {
                lstItems.Items.RemoveAt(lstItems.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item from the list first.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
