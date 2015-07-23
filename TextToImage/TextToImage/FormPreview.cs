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
        private PictureBox mainPic;
        private Bitmap PreviewImage;
        public FormPreview(Bitmap previewImage)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            PreviewImage = previewImage;
            mainPic.Image = PreviewImage;
            this.FormClosing += new FormClosingEventHandler(FormPreview_FormClosing);
        }

        void FormPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("要保存此图片吗?", "存盘提示", MessageBoxButtons.YesNo))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.AddExtension = true;
                sfd.DefaultExt = "png";
                sfd.Filter = "PNG|*.png";
                if (DialogResult.OK == sfd.ShowDialog())
                {
                    PreviewImage.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void InitializeComponent()
        {
            this.mainPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPic
            // 
            this.mainPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPic.Location = new System.Drawing.Point(0, 0);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(284, 261);
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            // 
            // FormPreview
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mainPic);
            this.Name = "FormPreview";
            this.Text = "预览";
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
