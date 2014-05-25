namespace TextToImage
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
            this.buttonPreview = new System.Windows.Forms.Button();
            this.comboBoxPredefinedResolution = new System.Windows.Forms.ComboBox();
            this.groupBoxResolution = new System.Windows.Forms.GroupBox();
            this.numericUpDownResolutionHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResolutionWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUserDefined = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPage = new System.Windows.Forms.GroupBox();
            this.numericUpDownLineDistance = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPagePadding = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.comboBoxFontSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInputText = new System.Windows.Forms.TextBox();
            this.groupBoxResolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolutionHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolutionWidth)).BeginInit();
            this.groupBoxPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagePadding)).BeginInit();
            this.groupBoxFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(284, 407);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonPreview.TabIndex = 0;
            this.buttonPreview.Text = "预览效果";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click);
            // 
            // comboBoxPredefinedResolution
            // 
            this.comboBoxPredefinedResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPredefinedResolution.FormattingEnabled = true;
            this.comboBoxPredefinedResolution.Items.AddRange(new object[] {
            "iPhone 5s(640x1136)",
            "iPad Air(1536x2048)",
            "iPad mini(768x1024)",
            "iPad mini2(1536x2048)",
            "Nokia 5130(240x320)",
            "VGA(640x480)",
            "SVGA(1024x768)",
            "720p(1280x720)",
            "1080p(1920x1080)",
            "1366x768(1366x768)",
            "1280x1024(1280x1024)"});
            this.comboBoxPredefinedResolution.Location = new System.Drawing.Point(77, 28);
            this.comboBoxPredefinedResolution.Name = "comboBoxPredefinedResolution";
            this.comboBoxPredefinedResolution.Size = new System.Drawing.Size(270, 20);
            this.comboBoxPredefinedResolution.TabIndex = 1;
            // 
            // groupBoxResolution
            // 
            this.groupBoxResolution.Controls.Add(this.numericUpDownResolutionHeight);
            this.groupBoxResolution.Controls.Add(this.numericUpDownResolutionWidth);
            this.groupBoxResolution.Controls.Add(this.label3);
            this.groupBoxResolution.Controls.Add(this.label2);
            this.groupBoxResolution.Controls.Add(this.checkBoxUserDefined);
            this.groupBoxResolution.Controls.Add(this.label1);
            this.groupBoxResolution.Controls.Add(this.comboBoxPredefinedResolution);
            this.groupBoxResolution.Location = new System.Drawing.Point(12, 12);
            this.groupBoxResolution.Name = "groupBoxResolution";
            this.groupBoxResolution.Size = new System.Drawing.Size(360, 98);
            this.groupBoxResolution.TabIndex = 2;
            this.groupBoxResolution.TabStop = false;
            this.groupBoxResolution.Text = "分辨率";
            // 
            // numericUpDownResolutionHeight
            // 
            this.numericUpDownResolutionHeight.Location = new System.Drawing.Point(250, 59);
            this.numericUpDownResolutionHeight.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDownResolutionHeight.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownResolutionHeight.Name = "numericUpDownResolutionHeight";
            this.numericUpDownResolutionHeight.Size = new System.Drawing.Size(97, 21);
            this.numericUpDownResolutionHeight.TabIndex = 7;
            this.numericUpDownResolutionHeight.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDownResolutionWidth
            // 
            this.numericUpDownResolutionWidth.Location = new System.Drawing.Point(110, 59);
            this.numericUpDownResolutionWidth.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.numericUpDownResolutionWidth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownResolutionWidth.Name = "numericUpDownResolutionWidth";
            this.numericUpDownResolutionWidth.Size = new System.Drawing.Size(97, 21);
            this.numericUpDownResolutionWidth.TabIndex = 6;
            this.numericUpDownResolutionWidth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "高度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "宽度";
            // 
            // checkBoxUserDefined
            // 
            this.checkBoxUserDefined.AutoSize = true;
            this.checkBoxUserDefined.Location = new System.Drawing.Point(11, 60);
            this.checkBoxUserDefined.Name = "checkBoxUserDefined";
            this.checkBoxUserDefined.Size = new System.Drawing.Size(60, 16);
            this.checkBoxUserDefined.TabIndex = 3;
            this.checkBoxUserDefined.Text = "自定义";
            this.checkBoxUserDefined.UseVisualStyleBackColor = true;
            this.checkBoxUserDefined.CheckedChanged += new System.EventHandler(this.checkBoxUserDefined_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择预定义";
            // 
            // groupBoxPage
            // 
            this.groupBoxPage.Controls.Add(this.numericUpDownLineDistance);
            this.groupBoxPage.Controls.Add(this.label5);
            this.groupBoxPage.Controls.Add(this.numericUpDownPagePadding);
            this.groupBoxPage.Controls.Add(this.label4);
            this.groupBoxPage.Location = new System.Drawing.Point(12, 116);
            this.groupBoxPage.Name = "groupBoxPage";
            this.groupBoxPage.Size = new System.Drawing.Size(360, 64);
            this.groupBoxPage.TabIndex = 3;
            this.groupBoxPage.TabStop = false;
            this.groupBoxPage.Text = "页面设置";
            // 
            // numericUpDownLineDistance
            // 
            this.numericUpDownLineDistance.Location = new System.Drawing.Point(250, 26);
            this.numericUpDownLineDistance.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDownLineDistance.Name = "numericUpDownLineDistance";
            this.numericUpDownLineDistance.Size = new System.Drawing.Size(99, 21);
            this.numericUpDownLineDistance.TabIndex = 9;
            this.numericUpDownLineDistance.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "行距";
            // 
            // numericUpDownPagePadding
            // 
            this.numericUpDownPagePadding.Location = new System.Drawing.Point(110, 26);
            this.numericUpDownPagePadding.Name = "numericUpDownPagePadding";
            this.numericUpDownPagePadding.Size = new System.Drawing.Size(97, 21);
            this.numericUpDownPagePadding.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "页边距";
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.comboBoxFontSize);
            this.groupBoxFont.Controls.Add(this.label6);
            this.groupBoxFont.Location = new System.Drawing.Point(12, 186);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(360, 67);
            this.groupBoxFont.TabIndex = 4;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "字体设置";
            // 
            // comboBoxFontSize
            // 
            this.comboBoxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontSize.FormattingEnabled = true;
            this.comboBoxFontSize.Items.AddRange(new object[] {
            "12",
            "16"});
            this.comboBoxFontSize.Location = new System.Drawing.Point(68, 30);
            this.comboBoxFontSize.Name = "comboBoxFontSize";
            this.comboBoxFontSize.Size = new System.Drawing.Size(279, 20);
            this.comboBoxFontSize.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "字体大小\r\n(像素)";
            // 
            // textBoxInputText
            // 
            this.textBoxInputText.Location = new System.Drawing.Point(12, 259);
            this.textBoxInputText.Multiline = true;
            this.textBoxInputText.Name = "textBoxInputText";
            this.textBoxInputText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInputText.Size = new System.Drawing.Size(360, 142);
            this.textBoxInputText.TabIndex = 5;
            this.textBoxInputText.WordWrap = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.textBoxInputText);
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.groupBoxPage);
            this.Controls.Add(this.groupBoxResolution);
            this.Controls.Add(this.buttonPreview);
            this.Name = "FormMain";
            this.Text = "文字转图片";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResolution.ResumeLayout(false);
            this.groupBoxResolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolutionHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResolutionWidth)).EndInit();
            this.groupBoxPage.ResumeLayout(false);
            this.groupBoxPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagePadding)).EndInit();
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.ComboBox comboBoxPredefinedResolution;
        private System.Windows.Forms.GroupBox groupBoxResolution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxUserDefined;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownResolutionHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownResolutionWidth;
        private System.Windows.Forms.GroupBox groupBoxPage;
        private System.Windows.Forms.NumericUpDown numericUpDownLineDistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPagePadding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.ComboBox comboBoxFontSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInputText;
    }
}

