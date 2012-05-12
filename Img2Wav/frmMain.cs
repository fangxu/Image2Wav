using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Img2Wav
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Core_Img2Wav core = new Core_Img2Wav();
            core.InputBitmap = (System.Drawing.Bitmap) pbxInputImage.Image;
            core.Start();
           
            sfdOutputFile.Filter = "Wave File (*.wav)|";
            DialogResult dr = sfdOutputFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                core.OutputWav.WriteFile(sfdOutputFile.FileName);
                
            }
            MessageBox.Show("Done!");

        }




        private void frmMain_Load(object sender, EventArgs e)
        {
            pbxInputImage.Image = new Bitmap(pbxInputImage.Width, pbxInputImage.Height );
            Color C = new Color();
            C = Color.FromArgb(40, 40, 40);
            panColor.BackColor = C;
            cldColor.Color = C;
        }

        private Boolean IsDrawing = false;

        private void pbxInputImage_MouseDown(object sender, MouseEventArgs e)
        {
            IsDrawing = true;
        }

        private void pbxInputImage_MouseUp(object sender, MouseEventArgs e)
        {
            IsDrawing = false;
        }

        private void pbxInputImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing)
            {
                Bitmap B = (Bitmap)pbxInputImage.Image;
                System.Windows.Forms.MouseEventArgs mea = (System.Windows.Forms.MouseEventArgs)e;

                Color c = new Color(); c = B.GetPixel(mea.X, mea.Y);
                if ((c.R == 0) && (c.G == 0) && (c.B == 0))
                {
                    B.SetPixel(mea.X, mea.Y, cldColor.Color);
                }
                else
                {
                    B.SetPixel(mea.X, mea.Y, Color.Black);
                }
                pbxInputImage.Refresh();
            }
        }

        private void panColor_Click(object sender, EventArgs e)
        {
            DialogResult res = cldColor.ShowDialog();
            if (res == DialogResult.OK)
            {
                panColor.BackColor = cldColor.Color;
            }

        }


    }
}
