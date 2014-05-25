using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextToImage
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void checkBoxUserDefined_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownResolutionHeight.Enabled = checkBoxUserDefined.Checked;
            numericUpDownResolutionWidth.Enabled = checkBoxUserDefined.Checked;
            comboBoxPredefinedResolution.Enabled = !checkBoxUserDefined.Checked;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            checkBoxUserDefined.Checked = false;
            numericUpDownResolutionHeight.Enabled = false;
            numericUpDownResolutionWidth.Enabled = false;
            comboBoxFontSize.SelectedIndex = 0;
            comboBoxPredefinedResolution.SelectedIndex = 0;
        }

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            int width, height;
            int pagePadding;
            int lineDistance;
            int fontSize;
            if (checkBoxUserDefined.Checked)
            {
                width = (int)numericUpDownResolutionWidth.Value;
                height = (int)numericUpDownResolutionHeight.Value;
            }
            else
            {
                string resolutionStr = comboBoxPredefinedResolution.SelectedItem as string;
                int leftBracketIndex = resolutionStr.IndexOf('(');
                int rightBracketIndex = resolutionStr.IndexOf(')');
                string resStr = resolutionStr.Substring(leftBracketIndex + 1, rightBracketIndex - leftBracketIndex - 1);
                string[] splits = resStr.Split('x');
                width = Convert.ToInt32(splits[0]);
                height = Convert.ToInt32(splits[1]);
            }
            pagePadding = (int)numericUpDownPagePadding.Value;
            lineDistance = (int)numericUpDownLineDistance.Value;
            fontSize = Convert.ToInt32(comboBoxFontSize.SelectedItem as string);
            Bitmap img = DrawImage(width, height, pagePadding, lineDistance, fontSize);
            FormPreview previewer = new FormPreview(img);
            //img.Save("b.png", System.Drawing.Imaging.ImageFormat.Png);
            previewer.ShowDialog();
        }
        //暂不考虑英文的word wrapper
        /// <summary>
        /// 计算所需高度
        /// </summary>
        /// <param name="width">目标宽度</param>
        /// <param name="pagePadding">页边距</param>
        /// <param name="lineDistance">行距</param>
        /// <param name="font">字体</param>
        /// <returns>分行完毕的文本</returns>
        private List<string> CalculateHeight(int width, int pagePadding, int lineDistance, PixelFont font, string text)
        {
            List<string> result = new List<string>();
            int availableWidth = width - pagePadding * 2;//除去页边距之后的可用宽度
            List<char> line = new List<char>();
            string[] lines = text.Split(new char[]{'\r', '\n'}, StringSplitOptions.None);
            int length = 0;
            foreach (var l in lines)
            {
                line.Clear();
                length = 0;
                foreach (var c in l)
                {
                    int len = font.MeasureCharDrawingLength(c);
                    if (len + length > availableWidth)
                    {
                        result.Add(new string(line.ToArray()));
                        line.Clear();
                        line.Add(c);
                        length = len;
                    }
                    else
                    {
                        length += len;
                        line.Add(c);
                    }
                }
                result.Add(new string(line.ToArray()));

            }
            return result;
        }
        private Bitmap DrawImage(int width, int height, int pagePadding, int lineDistance, int fontSize)
        {
            
            
            int halfFontSize = fontSize / 2;
            string unicodeFontFileName = "songti-" + fontSize + "x" + fontSize + ".bin";
            string asciiFontFileName = "terminus-ascii-" + halfFontSize + "x" + fontSize + "-95chars.png";
            //debug:
            //Bitmap bmp = Bitmap.FromFile(Application.StartupPath + "\\Resource\\" + asciiFontFileName) as Bitmap;
            //(new FormPreview(bmp)).ShowDialog();
            //
            PixelFont font = new PixelFont(Application.StartupPath + "\\Resource\\" + unicodeFontFileName, Application.StartupPath + "\\Resource\\" + asciiFontFileName, Color.Black);
            //test
            //font.DrawString(g, new SolidBrush(Color.Black), textBoxInputText.Text, 0, 0);
            //
            List<string> lines = CalculateHeight(width, pagePadding, lineDistance, font, textBoxInputText.Text);
            Bitmap target = new Bitmap(width, lines.Count * lineDistance + 2 * pagePadding);
            Graphics g = Graphics.FromImage(target);
            g.Clear(Color.White);
            SolidBrush b = new SolidBrush(Color.Black);
            for(int i = 0; i < lines.Count;i ++)
            {
                font.DrawString(g, b, lines[i], pagePadding, pagePadding + i * lineDistance);
            }
            g.Dispose();
            return target;
        }
    }
}
