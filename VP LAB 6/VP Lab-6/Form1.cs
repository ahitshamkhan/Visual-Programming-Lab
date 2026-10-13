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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radRed.Checked = true;
            radMedium.Checked = true;
            cmbExtraOptions.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
                lblDisplay.ForeColor = Color.Red;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
                lblDisplay.ForeColor = Color.Blue;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
                lblDisplay.ForeColor = Color.Green;
        }

        private void UpdateFontSize(float size)
        {
            lblDisplay.Font = new Font(
                lblDisplay.Font.Name,
                size,
                lblDisplay.Font.Style
            );
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radSmall.Checked)
                UpdateFontSize(10);
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radMedium.Checked)
                UpdateFontSize(14);
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radLarge.Checked)
                UpdateFontSize(20);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            switch (cmbExtraOptions.SelectedItem?.ToString())
            {
                case "Bold":
                    style = FontStyle.Bold;
                    break;
                case "Italic":
                    style = FontStyle.Italic;
                    break;
                case "Underline":
                    style = FontStyle.Underline;
                    break;
            }

            lblDisplay.Font = new Font(
                lblDisplay.Font.Name,
                lblDisplay.Font.Size,
                style
            );

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radRed.Checked = true;
            radMedium.Checked = true;
            cmbExtraOptions.SelectedIndex = 0;
            lblDisplay.ForeColor = Color.Black;
            lblDisplay.Font = new Font(lblDisplay.Font.Name, 14, FontStyle.Regular);
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
