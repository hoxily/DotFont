using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FontGenerator
{
    public partial class FormMain : Form
    {
        Font myFont;
        SolidBrush myBrush;
        Bitmap myBitmap;
        Graphics myGraphics;
        Pen myPen;
        int fontWidth=12, fontHeight=12;
        int wIndent=0, hIndent=0;//字体的x/y方向的偏移,以像素为单位
        const int epsilong = 10;//颜色误差阈值.
        int scale = 5;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var installedFontCollection = new InstalledFontCollection();
            foreach (var f in installedFontCollection.Families)
            {
                comboBoxFontFaceList.Items.Add(f.Name);
            }
            comboBoxFontFaceList.SelectedItem = "宋体";
            myFont = new Font("宋体", fontWidth, FontStyle.Regular, GraphicsUnit.Pixel);
            myBrush = new SolidBrush(Color.Black);
            myPen = new Pen(myBrush);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}-{1}x{2}.bin", comboBoxFontFaceList.SelectedItem as string, fontWidth, fontHeight);
            string fontInformation = string.Format("OriginalFileName:{0}\r\nDateTime(UTC):{1}\r\nversion:{2}\r\nby:{3}\r\n",
                fileName,
                DateTime.UtcNow,
                "PixelFontGenerator1.0.0.0",
                "Hoxily(hoxily@qq.com)");
            byte[] fontInfoBuffer = new byte[256];
            byte[] fontInfoBytes = Encoding.UTF8.GetBytes(fontInformation);
            Array.Copy(fontInfoBytes, fontInfoBuffer, fontInfoBytes.Length);

            FileStream fsout = new FileStream(System.IO.Path.Combine(Application.StartupPath, fileName), FileMode.Create);
            fsout.Write(fontInfoBuffer, 0, fontInfoBuffer.Length);
            fsout.WriteByte((byte)fontWidth);
            fsout.WriteByte((byte)fontHeight);
            char unicode=char.MinValue;
            byte[] mask = new byte[8];
            /* mask array should be as below:
             * 0000 0001b
             * 0000 0010b
             * 0000 0100b
             * 0000 1000b
             * 0001 0000b
             * 0010 0000b
             * 0100 0000b
             * 1000 0000b
             * */
            mask[0] = 0x01;
            for (int i = 1; i < 8; i++)
            {
                mask[i] = (byte)(mask[i - 1] << 1);
            }
            while (true)
            {
                myGraphics.Clear(Color.White);
                myGraphics.DrawString(unicode.ToString(), myFont, myBrush, wIndent, hIndent);
                int x, y,bitPos;
                byte outputbyte;
                for (y = 0;y < fontHeight ; y++)
                {
                    outputbyte = 0;
                    bitPos = 7;
                    for (x = 0; x < fontWidth; x++)
                    {
                        if (Math.Abs(myBitmap.GetPixel(x, y).ToArgb() - Color.Black.ToArgb()) <= epsilong)
                        {//forecolor, set to 1
                            outputbyte = (byte)(outputbyte | mask[bitPos]);
                        }
                        bitPos = (bitPos - 1 + 8) % 8;
                        if (bitPos == 7)
                        {
                            fsout.WriteByte(outputbyte);
                            outputbyte = 0;
                        }
                    }
                    if (bitPos != 7)
                    {//不足1字节
                        fsout.WriteByte(outputbyte);
                    }
                }
                if (unicode == char.MaxValue)
                    break;
                unicode++;
            }
            fsout.Close();
            System.Diagnostics.Process.Start(Application.StartupPath);
        }
        private Bitmap DoubleSizeImage(Bitmap originalImage, Color backgroundColor,int scale)
        {
            Bitmap img = new Bitmap(originalImage.Width * scale, originalImage.Height * scale);
            Graphics g = Graphics.FromImage(img);
            g.Clear(backgroundColor);
            SolidBrush brush = new SolidBrush(backgroundColor);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    brush.Color = c;
                    g.FillRectangle(brush, x * scale, y * scale, scale, scale);
                }
            }
            g.Dispose();
            return img;
        }
        private Bitmap AddGridLines(Bitmap originalImage, Color gridLineColor, int gridSize)
        {
            Bitmap img = new Bitmap(originalImage);
            Graphics g = Graphics.FromImage(img);
            Pen pen = new Pen(gridLineColor, 1.0f);
            //draw horizontal gridlines
            for (int y = 0; y < img.Height; y+= gridSize)
            {
                g.DrawLine(pen, 0, y, img.Width - 1, y);
            }
            //draw vertical gridLines
            for (int x = 0; x < img.Width; x += gridSize)
            {
                g.DrawLine(pen, x, 0, x, img.Height - 1);
            }
            g.Dispose();
            return img;
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            picBox.Size = new Size(scale*fontWidth, scale*fontHeight);
            picBox.Left = (this.Width - picBox.Width - 10)/2;
            myBitmap = new Bitmap(Convert.ToInt32(myFont.Size), Convert.ToInt32(myFont.Size));
            myGraphics = Graphics.FromImage(myBitmap);
            myGraphics.Clear(Color.Green);
            myGraphics.TextRenderingHint = TextRenderingHint.SystemDefault;
            myGraphics.DrawString(textBoxTestChar.Text, myFont, myBrush, wIndent, hIndent);
            Bitmap doubledImage = DoubleSizeImage(myBitmap, Color.Green, scale);
            picBox.Image = AddGridLines(doubledImage, Color.Black, scale);
        }

        private void fontSizeChanged(object sender, EventArgs e)
        {
            fontWidth = (int)(numericUpDownWidthHeight.Value);
            fontHeight = fontWidth;
            myFont = new Font(comboBoxFontFaceList.SelectedItem as string, fontWidth, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        private void indentChanged(object sender, EventArgs e)
        {
            wIndent = (int)(numericUpDownwIndent.Value);
            hIndent = (int)(numericUpDownhIndent.Value);
        }

        private void comboBoxFontFaceList_SelectedValueChanged(object sender, EventArgs e)
        {
            myFont = new Font(comboBoxFontFaceList.SelectedItem as string, fontWidth, FontStyle.Regular, GraphicsUnit.Pixel);
        }
    }
}
