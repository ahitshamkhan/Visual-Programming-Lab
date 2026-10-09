using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_LAB_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void ClearFont()
        {
            timesMenuItem.Checked = false;
            courierMenuItem.Checked = false;
            comicMenuItem.Checked = false;
        }


        private void timesMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            displayLabel.Font = new Font("Times New Roman", displayLabel.Font.Size, displayLabel.Font.Style);
            timesMenuItem.Checked = true;
        }

        private void courierMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            displayLabel.Font = new Font("Courier New", displayLabel.Font.Size, displayLabel.Font.Style);
            courierMenuItem.Checked = true;
        }

        private void comicMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            displayLabel.Font = new Font("Comic Sans MS", displayLabel.Font.Size, displayLabel.Font.Style);
            comicMenuItem.Checked = true;
        }

        private void boldMenuItem_Click(object sender, EventArgs e)
        {
            boldMenuItem.Checked = !boldMenuItem.Checked;
            FontStyle newStyle = displayLabel.Font.Style ^ FontStyle.Bold;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, displayLabel.Font.Size, newStyle);

        }

        private void italicMenuItem_Click(object sender, EventArgs e)
        {
            italicMenuItem.Checked = !italicMenuItem.Checked;
            FontStyle newStyle = displayLabel.Font.Style ^ FontStyle.Italic;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, displayLabel.Font.Size, newStyle);
        }


        private void ClearColor()
        {
            blackMenuItem.Checked = false;
            blueMenuItem.Checked = false;
            redMenuItem.Checked = false;
            greenMenuItem.Checked = false;
        }

        private void blackMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Black;
            blackMenuItem.Checked = true;
        }

        private void blueMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;
            blueMenuItem.Checked = true;
        }

        private void redMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Red;
            redMenuItem.Checked = true;
        }

        private void greenMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Green;
            greenMenuItem.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelContextMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ctxBold_Click(object sender, EventArgs e)
        {
            ctxBold.Checked = !ctxBold.Checked;
            FontStyle newStyle = displayLabel.Font.Style ^ FontStyle.Bold;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, displayLabel.Font.Size, newStyle);
        }

        private void ctxItalic_Click(object sender, EventArgs e)
        {
            ctxItalic.Checked = !ctxItalic.Checked;
            FontStyle newStyle = displayLabel.Font.Style ^ FontStyle.Italic;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, displayLabel.Font.Size, newStyle);
        }

        private void ctxUnderline_Click(object sender, EventArgs e)
        {
            ctxUnderline.Checked = !ctxUnderline.Checked;
            FontStyle newStyle = displayLabel.Font.Style ^ FontStyle.Underline;
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, displayLabel.Font.Size, newStyle);
        }

        private void ctxReset_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, displayLabel.Font.Size, FontStyle.Regular);
            ctxBold.Checked = false;
            ctxItalic.Checked = false;
            ctxUnderline.Checked = false;
        }
    }
}
 