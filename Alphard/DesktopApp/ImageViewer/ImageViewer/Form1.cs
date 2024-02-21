using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class img_Viewer : Form
    {
        public img_Viewer()
        {
            InitializeComponent();
        }


/*Control button*/
        
        private void showButton_Click(object sender, EventArgs e) { 
            if(SelectPictureDialog.ShowDialog() == DialogResult.OK){
                pictureBox1.Load(SelectPictureDialog.FileName);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StretchCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (StretchCheckbox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
