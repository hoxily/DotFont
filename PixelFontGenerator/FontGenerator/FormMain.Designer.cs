namespace FontGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox = new System.Windows.Forms.PictureBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.numericUpDownwIndent = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownhIndent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTestChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownWidthHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFontFaceList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownwIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidthHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(1, 1);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(312, 315);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(187, 415);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(126, 23);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "GenerateFont";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(187, 388);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(126, 23);
            this.buttonDraw.TabIndex = 2;
            this.buttonDraw.Text = "DrawTest";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // numericUpDownwIndent
            // 
            this.numericUpDownwIndent.Location = new System.Drawing.Point(113, 388);
            this.numericUpDownwIndent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownwIndent.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDownwIndent.Name = "numericUpDownwIndent";
            this.numericUpDownwIndent.Size = new System.Drawing.Size(67, 21);
            this.numericUpDownwIndent.TabIndex = 3;
            this.numericUpDownwIndent.ValueChanged += new System.EventHandler(this.indentChanged);
            // 
            // numericUpDownhIndent
            // 
            this.numericUpDownhIndent.Location = new System.Drawing.Point(113, 415);
            this.numericUpDownhIndent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownhIndent.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numericUpDownhIndent.Name = "numericUpDownhIndent";
            this.numericUpDownhIndent.Size = new System.Drawing.Size(67, 21);
            this.numericUpDownhIndent.TabIndex = 4;
            this.numericUpDownhIndent.ValueChanged += new System.EventHandler(this.indentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "WidthIndent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "HeightIndent";
            // 
            // textBoxTestChar
            // 
            this.textBoxTestChar.Location = new System.Drawing.Point(187, 363);
            this.textBoxTestChar.MaxLength = 1;
            this.textBoxTestChar.Name = "textBoxTestChar";
            this.textBoxTestChar.Size = new System.Drawing.Size(126, 21);
            this.textBoxTestChar.TabIndex = 7;
            this.textBoxTestChar.Text = "屌";
            this.textBoxTestChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width/Height";
            // 
            // numericUpDownWidthHeight
            // 
            this.numericUpDownWidthHeight.Location = new System.Drawing.Point(113, 361);
            this.numericUpDownWidthHeight.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownWidthHeight.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownWidthHeight.Name = "numericUpDownWidthHeight";
            this.numericUpDownWidthHeight.Size = new System.Drawing.Size(67, 21);
            this.numericUpDownWidthHeight.TabIndex = 11;
            this.numericUpDownWidthHeight.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownWidthHeight.ValueChanged += new System.EventHandler(this.fontSizeChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "FontFace";
            // 
            // comboBoxFontFaceList
            // 
            this.comboBoxFontFaceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontFaceList.FormattingEnabled = true;
            this.comboBoxFontFaceList.Location = new System.Drawing.Point(113, 335);
            this.comboBoxFontFaceList.Name = "comboBoxFontFaceList";
            this.comboBoxFontFaceList.Size = new System.Drawing.Size(200, 20);
            this.comboBoxFontFaceList.TabIndex = 13;
            this.comboBoxFontFaceList.SelectedValueChanged += new System.EventHandler(this.comboBoxFontFaceList_SelectedValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownhIndent);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.comboBoxFontFaceList);
            this.Controls.Add(this.textBoxTestChar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownwIndent);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.numericUpDownWidthHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelFontGenerator";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownwIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownhIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidthHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.NumericUpDown numericUpDownwIndent;
        private System.Windows.Forms.NumericUpDown numericUpDownhIndent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTestChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownWidthHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFontFaceList;
    }
}

