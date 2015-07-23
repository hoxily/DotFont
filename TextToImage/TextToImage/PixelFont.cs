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
                int width = Width / 2;
                int height = Height;
                for (int cy = 0; cy < height; cy++)
                {
                    for (int cx = 0; cx < width; cx++)
                    {
                        Color color = _ASCIIImage.GetPixel(offset * width + cx, cy);

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
            _ASCIIBackgroundColor = asciiFontBackgroundColor;

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
