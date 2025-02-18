namespace Lesson27._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkBoxBolt = new CheckBox();
            checkBoxItalics = new CheckBox();
            checkBoxAndeLine = new CheckBox();
            textBoxFont = new TextBox();
            buttonFond = new Button();
            label1 = new Label();
            buttonColor = new Button();
            label2 = new Label();
            numericUpDownSize = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            richTextBoxText = new RichTextBox();
            toolStrip1 = new ToolStrip();
            создатьToolStripButton = new ToolStripButton();
            открытьToolStripButton = new ToolStripButton();
            сохранитьToolStripButton = new ToolStripButton();
            печатьToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            вырезатьToolStripButton = new ToolStripButton();
            копироватьToolStripButton = new ToolStripButton();
            вставитьToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            справкаToolStripButton = new ToolStripButton();
            toolStripButtonJust = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxBolt
            // 
            checkBoxBolt.AutoSize = true;
            checkBoxBolt.Location = new Point(613, 52);
            checkBoxBolt.Name = "checkBoxBolt";
            checkBoxBolt.Size = new Size(88, 24);
            checkBoxBolt.TabIndex = 3;
            checkBoxBolt.Text = "Жирный";
            checkBoxBolt.UseVisualStyleBackColor = true;
            checkBoxBolt.CheckedChanged += checkBoxBolt_CheckedChanged;
            // 
            // checkBoxItalics
            // 
            checkBoxItalics.AutoSize = true;
            checkBoxItalics.Location = new Point(707, 52);
            checkBoxItalics.Name = "checkBoxItalics";
            checkBoxItalics.Size = new Size(77, 24);
            checkBoxItalics.TabIndex = 4;
            checkBoxItalics.Text = "Курсив";
            checkBoxItalics.UseVisualStyleBackColor = true;
            // 
            // checkBoxAndeLine
            // 
            checkBoxAndeLine.AutoSize = true;
            checkBoxAndeLine.Location = new Point(790, 52);
            checkBoxAndeLine.Name = "checkBoxAndeLine";
            checkBoxAndeLine.Size = new Size(130, 24);
            checkBoxAndeLine.TabIndex = 5;
            checkBoxAndeLine.Text = "Подчеркнутый";
            checkBoxAndeLine.UseVisualStyleBackColor = true;
            // 
            // textBoxFont
            // 
            textBoxFont.Location = new Point(615, 84);
            textBoxFont.Name = "textBoxFont";
            textBoxFont.ReadOnly = true;
            textBoxFont.Size = new Size(268, 27);
            textBoxFont.TabIndex = 6;
            // 
            // buttonFond
            // 
            buttonFond.Location = new Point(889, 84);
            buttonFond.Name = "buttonFond";
            buttonFond.Size = new Size(40, 25);
            buttonFond.TabIndex = 7;
            buttonFond.Text = "...";
            buttonFond.UseVisualStyleBackColor = true;
            buttonFond.Click += buttonFond_Click;
            // 
            // label1
            // 
            label1.Location = new Point(836, 114);
            label1.Name = "label1";
            label1.Size = new Size(47, 26);
            label1.TabIndex = 8;
            label1.Text = "Цвет";
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(889, 115);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(40, 25);
            buttonColor.TabIndex = 9;
            buttonColor.Text = "...";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(615, 152);
            label2.Name = "label2";
            label2.Size = new Size(62, 22);
            label2.TabIndex = 10;
            label2.Text = "Размер";
            // 
            // numericUpDownSize
            // 
            numericUpDownSize.Location = new Point(695, 150);
            numericUpDownSize.Name = "numericUpDownSize";
            numericUpDownSize.Size = new Size(120, 27);
            numericUpDownSize.TabIndex = 11;
            numericUpDownSize.ValueChanged += numericUpDownSize_ValueChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(180, 22);
            открытьToolStripMenuItem.Text = "Открыть...";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(180, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            сохранитьКакToolStripMenuItem.Click += сохранитьКакToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // richTextBoxText
            // 
            richTextBoxText.Location = new Point(0, 52);
            richTextBoxText.Name = "richTextBoxText";
            richTextBoxText.Size = new Size(607, 536);
            richTextBoxText.TabIndex = 13;
            richTextBoxText.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { создатьToolStripButton, открытьToolStripButton, сохранитьToolStripButton, печатьToolStripButton, toolStripSeparator, вырезатьToolStripButton, копироватьToolStripButton, вставитьToolStripButton, toolStripSeparator2, toolStripButtonJust, справкаToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(939, 25);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // создатьToolStripButton
            // 
            создатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            создатьToolStripButton.Image = (Image)resources.GetObject("создатьToolStripButton.Image");
            создатьToolStripButton.ImageTransparentColor = Color.Magenta;
            создатьToolStripButton.Name = "создатьToolStripButton";
            создатьToolStripButton.Size = new Size(23, 22);
            создатьToolStripButton.Text = "&Создать";
            // 
            // открытьToolStripButton
            // 
            открытьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            открытьToolStripButton.Image = (Image)resources.GetObject("открытьToolStripButton.Image");
            открытьToolStripButton.ImageTransparentColor = Color.Magenta;
            открытьToolStripButton.Name = "открытьToolStripButton";
            открытьToolStripButton.Size = new Size(23, 22);
            открытьToolStripButton.Text = "&Открыть";
            // 
            // сохранитьToolStripButton
            // 
            сохранитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            сохранитьToolStripButton.Image = (Image)resources.GetObject("сохранитьToolStripButton.Image");
            сохранитьToolStripButton.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            сохранитьToolStripButton.Size = new Size(23, 22);
            сохранитьToolStripButton.Text = "&Сохранить";
            // 
            // печатьToolStripButton
            // 
            печатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            печатьToolStripButton.Image = (Image)resources.GetObject("печатьToolStripButton.Image");
            печатьToolStripButton.ImageTransparentColor = Color.Magenta;
            печатьToolStripButton.Name = "печатьToolStripButton";
            печатьToolStripButton.Size = new Size(23, 22);
            печатьToolStripButton.Text = "&Печать";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // вырезатьToolStripButton
            // 
            вырезатьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            вырезатьToolStripButton.Image = (Image)resources.GetObject("вырезатьToolStripButton.Image");
            вырезатьToolStripButton.ImageTransparentColor = Color.Magenta;
            вырезатьToolStripButton.Name = "вырезатьToolStripButton";
            вырезатьToolStripButton.Size = new Size(23, 22);
            вырезатьToolStripButton.Text = "Вы&резать";
            // 
            // копироватьToolStripButton
            // 
            копироватьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            копироватьToolStripButton.Image = (Image)resources.GetObject("копироватьToolStripButton.Image");
            копироватьToolStripButton.ImageTransparentColor = Color.Magenta;
            копироватьToolStripButton.Name = "копироватьToolStripButton";
            копироватьToolStripButton.Size = new Size(23, 22);
            копироватьToolStripButton.Text = "&Копировать";
            // 
            // вставитьToolStripButton
            // 
            вставитьToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            вставитьToolStripButton.Image = (Image)resources.GetObject("вставитьToolStripButton.Image");
            вставитьToolStripButton.ImageTransparentColor = Color.Magenta;
            вставитьToolStripButton.Name = "вставитьToolStripButton";
            вставитьToolStripButton.Size = new Size(23, 22);
            вставитьToolStripButton.Text = "&Вставить";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // справкаToolStripButton
            // 
            справкаToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            справкаToolStripButton.Image = (Image)resources.GetObject("справкаToolStripButton.Image");
            справкаToolStripButton.ImageTransparentColor = Color.Magenta;
            справкаToolStripButton.Name = "справкаToolStripButton";
            справкаToolStripButton.Size = new Size(23, 22);
            справкаToolStripButton.Text = "С&правка";
            // 
            // toolStripButtonJust
            // 
            toolStripButtonJust.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonJust.Image = (Image)resources.GetObject("toolStripButtonJust.Image");
            toolStripButtonJust.ImageTransparentColor = Color.Magenta;
            toolStripButtonJust.Name = "toolStripButtonJust";
            toolStripButtonJust.Size = new Size(23, 22);
            toolStripButtonJust.Text = "toolStripButton1";
            toolStripButtonJust.ToolTipText = "Выровнить";
            toolStripButtonJust.Click += toolStripButtonJust_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 600);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBoxText);
            Controls.Add(numericUpDownSize);
            Controls.Add(label2);
            Controls.Add(buttonColor);
            Controls.Add(label1);
            Controls.Add(buttonFond);
            Controls.Add(textBoxFont);
            Controls.Add(checkBoxAndeLine);
            Controls.Add(checkBoxItalics);
            Controls.Add(checkBoxBolt);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSize).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxBolt;
        private CheckBox checkBoxItalics;
        private CheckBox checkBoxAndeLine;
        private TextBox textBoxFont;
        private Button buttonFond;
        private Label label1;
        private Button buttonColor;
        private Label label2;
        private NumericUpDown numericUpDownSize;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private RichTextBox richTextBoxText;
        private ToolStrip toolStrip1;
        private ToolStripButton создатьToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripButton печатьToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton вырезатьToolStripButton;
        private ToolStripButton копироватьToolStripButton;
        private ToolStripButton вставитьToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton справкаToolStripButton;
        private ToolStripButton toolStripButtonJust;
    }
}
