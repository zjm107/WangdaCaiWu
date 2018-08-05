using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WangDaDll
{
    public partial class FrmImageView : Form
    {
        public FrmImageView()
        {
            InitializeComponent();
        }

        private void btnZoomAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double zoomPercent = imageView.Properties.ZoomPercent;
                if (zoomPercent == 1)
                {
                    imageView.Properties.ZoomPercent = 100;
                }
                else
                {
                    imageView.Properties.ZoomPercent = zoomPercent + 10;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZoom100_Click(object sender, EventArgs e)
        {
            try
            {
                    imageView.Properties.ZoomPercent = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            try
            {
                double zoomPercent = imageView.Properties.ZoomPercent;
                if (zoomPercent == 1)
                {
                    imageView.Properties.ZoomPercent = 100;
                }
                else
                    imageView.Properties.ZoomPercent = zoomPercent - 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 图片字节
        /// </summary>
        public byte[] ImageBytes
        {
            get;
            set;
        }

        private void FrmImageView_Load(object sender, EventArgs e)
        {
            try
            {
                if (ImageBytes != null && ImageBytes.Length > 0)
                {
                    MemoryStream stream = new MemoryStream(ImageBytes, true);
                    stream.Write(ImageBytes, 0, ImageBytes.Length);
                    imageView.Image = Image.FromStream(stream);
                    imageView.Properties.ZoomPercent = 100;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
