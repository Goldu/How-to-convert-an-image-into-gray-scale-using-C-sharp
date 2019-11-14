using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imageprocessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if(DialogResult.OK==ofile.ShowDialog())
            {
                this.PicOriginal.Image = new Bitmap(ofile.FileName);

            }
        }

        private void btngray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.PicOriginal.Image);
            Processing.ConvertToGray(copy);
            this.PicResult.Image = copy;
        }
    }
}
