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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            ItemCheckedList.Items.Add("C#");
            ItemCheckedList.Items.Add("Java");
            ItemCheckedList.Items.Add("Python");
            ItemCheckedList.Items.Add("C++");
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemCheckedList_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string item = ItemCheckedList.SelectedItem.ToString();

        //    if (e.NewValue == CheckState.Checked)
        //    {
        //        displayListBox.Items.Add(item);
        //    }
        //    else
        //    {
        //        displayListBox.Items.Remove(item);
        //    }
        }

        private void itemCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = ItemCheckedList.SelectedItem.ToString();

            if (e.NewValue == CheckState.Checked)
            {
                displayListBox.Items.Add(item);
            }
            else
            {
                displayListBox.Items.Remove(item);
            }
        }
    }
}
