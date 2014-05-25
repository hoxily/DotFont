using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TextToImage
{
    class FormPreview:Form
    {
        private Bitmap PreviewImage;
        public FormPreview(Bitmap previewImage)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            PreviewImage = previewImage;
            this.BackgroundImage = PreviewImage;
            this.BackgroundImageLayout = ImageLayout.None;
            this.Width = PreviewImage.Width;
            this.Height = PreviewImage.Height;
            this.FormClosing += new FormClosingEventHandler(FormPreview_FormClosing);
        }

        void FormPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("要保存此图片吗?", "存盘提示", MessageBoxButtons.OKCancel))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.AddExtension = true;
                sfd.DefaultExt = "png";
                if (DialogResult.OK == sfd.ShowDialog())
                {
                    PreviewImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
    }
}
