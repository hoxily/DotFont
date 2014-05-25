using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace TextToImage
{
    class PixelFont
    {
        private string _Information;
        public string Information
        {
            get
            {
                return _Information;
            }
        }
        //width of ascii characters are half of other characters
        private int _Width;
        public int Width
        {
            get
            {
                return _Width;
            }
        }
        private int _Height;
        public int Height
        {
            get
            {
                return _Height;
            }
        }
        private byte[] _UnicodeImages;
        private Bitmap _ASCIIImage;
        private Color _ASCIIBackgroundColor;
        /// <summary>
        /// 计算此文本绘制时所占宽度
        /// </summary>
        /// <param name="text">text中不含0x0000 - 0x0020的字符</param>
        /// <returns></returns>
        public int MeasureStringDrawingLength(string text)
        {
            int result = 0;
            foreach (var c in text)
            {
                result += MeasureCharDrawingLength(c);
            }
            return result;
        }
        public int MeasureCharDrawingLength(char c)
        {
            if(' ' <= c && c <= '~')
            {
                return Width / 2;
            }
            else
            {
                return Width;
            }
        }
        public void DrawString(Graphics g, Brush b, string text, int x, int y)
        {
            //if (text.Length > 1)
            //{
            //    int len = MeasureCharDrawingLength(text[0]);
            //    DrawChar(g, b, text[0], x, y);
            //    DrawString(g, b, text.Substring(1), x + len, y);
            //}
            //else if(text.Length == 1)
            //{
            //    DrawChar(g, b, text[0], x, y);
            //}
            //改递归为循环,提高效率
            foreach (var c in text)
            {
                int move = MeasureCharDrawingLength(c);
                DrawChar(g, b, c, x, y);
                x += move;
            }
        }

        private void DrawChar(Graphics g, Brush b, char c, int x, int y)
        {
            if (' ' <= c && c <= '~')
            {
                int offset = c - ' ';
                //对8x16的英文来说,这样画会出现毛刺,真是奇怪.
                //但是打开terminus-ascii-8x16-95chars.bmp查看却是正常的.
                //g.DrawImage(_ASCIIImage, new Rectangle(x, y, Width / 2, Height), new Rectangle(Width / 2 * offset, 0, Width / 2, Height), GraphicsUnit.Pixel);
                //-=-=-
                //擦,这样子画也出现毛刺,真恶心.
                int width = Width / 2;
                int height = Height;
                for (int cy = 0; cy < height; cy++)
                {
                    for (int cx = 0; cx < width; cx++)
                    {
                        Color color = _ASCIIImage.GetPixel(offset * width + cx, cy);
                        //if (!(color.R == _ASCIIBackgroundColor.R && color.G == _ASCIIBackgroundColor.G && color.B == _ASCIIBackgroundColor.B))
                        //{//foreground
                        //    g.FillRectangle(b, x + cx, y + cy, 1, 1);
                        //}

                        //用画板逐像素画的图,用Bitmap.FromFile载入得到的Bitmap对象产生了误差
                        //所以得设定个误差阈值
                        if (Math.Abs(color.R - _ASCIIBackgroundColor.R) +
                            Math.Abs(color.G - _ASCIIBackgroundColor.G) +
                            Math.Abs(color.B - _ASCIIBackgroundColor.B) > 300)
                        {
                            g.FillRectangle(b, x + cx, y + cy, 1, 1);
                        }
                    }
                }
            }
            else
            {
                int offset = c - '\0';
                int bytesPerLine = _Width % 8 == 0 ? _Width / 8 : _Width / 8 + 1;
                int bytesPerChar = bytesPerLine * Height;
                offset = offset * bytesPerChar;
                byte[] mask = { 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01 };
                int bitMaskPos = 0;
                for (int cy = 0; cy < Height; cy++)
                {
                    bitMaskPos = 0;
                    for (int cx = 0; cx < Width; cx++)
                    {
                        byte currentByte = _UnicodeImages[offset + cy * bytesPerLine + cx / 8];
                        if ((currentByte & mask[bitMaskPos]) > 0)
                        {
                            g.FillRectangle(b, x + cx, y + cy, 1, 1);
                        }
                        bitMaskPos = (bitMaskPos + 1) % 8;
                    }
                }
            }
        }
        public PixelFont(string unicodeFontFileName, string asciiFontFileName, Color asciiFontBackgroundColor)
        {
            //ascii image data
            _ASCIIImage = Bitmap.FromFile(asciiFontFileName,false) as Bitmap;
            //debug
            //_ASCIIImage.Save("a.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            //
            _ASCIIBackgroundColor = asciiFontBackgroundColor;
            //for (int x = 0; x < _ASCIIImage.Width; x++)
            //{
            //    for (int y = 0; y < _ASCIIImage.Height; y++)
            //    {
            //        if (_ASCIIImage.GetPixel(x, y).R == _ASCIIBackgroundColor.R)
            //        {
            //            _ASCIIImage.SetPixel(x, y, Color.White);
            //        }
            //        else
            //        {
            //            _ASCIIImage.SetPixel(x, y, Color.Black);
            //        }
            //    }
            //}
            
            //unicode image data
            FileStream fs = new FileStream(unicodeFontFileName, FileMode.Open);
            byte[] buffer = new byte[256];
            fs.Read(buffer, 0, buffer.Length);
            _Information = Encoding.UTF8.GetString(buffer);
            _Width = fs.ReadByte();
            _Width = _Width == 0 ? 256 : _Width;
            _Height = fs.ReadByte();
            _Height = _Height == 0 ? 256 : _Height;
            int bytesPerLine = _Width % 8 == 0 ? _Width / 8 : _Width / 8 + 1;
            int length = bytesPerLine * Height * 65536;
            _UnicodeImages = new byte[length];
            fs.Read(_UnicodeImages, 0, _UnicodeImages.Length);
            fs.Close();
        }
    }
}
