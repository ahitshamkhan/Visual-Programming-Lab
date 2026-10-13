using System;
using System.Drawing;
using System.Windows.Forms;

namespace VP_Lab_6
{
    public partial class Form2 : Form
    {
        int imageNum = 0; 

        public Form2()
        {
            InitializeComponent();

            
            LoadImage(0);
        }

        
        private void LoadImage(int index)
        {
            try
            {
                
                string imagePath = @"images\image" + index + ".bmp";

                
                picBox.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            
            imageNum = (imageNum + 1) % 3;


            LoadImage(imageNum);
        }

        
        private void chkVisibility_CheckedChanged(object sender, EventArgs e)
        {
           
            picBox.Visible = !chkVisibility.Checked;
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }
    }
}