namespace Lesson25._2
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
            dataGridViewInventors = new DataGridView();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            textBoxName = new TextBox();
            textBoxQuant = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDesc = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            buttonAdd = new Button();
            buttonEdit = new Button();
            comboBoxFilter = new ComboBox();
            textBoxSeach = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventors).BeginInit();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewInventors
            // 
            dataGridViewInventors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventors.Location = new Point(3, 64);
            dataGridViewInventors.Name = "dataGridViewInventors";
            dataGridViewInventors.Size = new Size(652, 422);
            dataGridViewInventors.TabIndex = 0;
            dataGridViewInventors.CellClick += dataGridViewInventors_CellClick;
            dataGridViewInventors.KeyDown += dataGridViewInventors_KeyDown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount });
            statusStrip1.Location = new Point(0, 489);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(884, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(118, 17);
            toolStripStatusLabelCount.Text = "toolStripStatusLabel1";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(661, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Название";
            textBoxName.Size = new Size(211, 29);
            textBoxName.TabIndex = 2;
            // 
            // textBoxQuant
            // 
            textBoxQuant.Location = new Point(661, 64);
            textBoxQuant.Name = "textBoxQuant";
            textBoxQuant.PlaceholderText = "Количество";
            textBoxQuant.Size = new Size(211, 29);
            textBoxQuant.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(661, 99);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "Цена";
            textBoxPrice.Size = new Size(211, 29);
            textBoxPrice.TabIndex = 4;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(661, 134);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.PlaceholderText = "Пояснение";
            textBoxDesc.Size = new Size(211, 308);
            textBoxDesc.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, открытьToolStripMenuItem, toolStripSeparator1, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(130, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(133, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(661, 448);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 38);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(767, 448);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(105, 38);
            buttonEdit.TabIndex = 8;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Название", "Количество", "Цена" });
            comboBoxFilter.Location = new Point(248, 27);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(121, 29);
            comboBoxFilter.TabIndex = 9;
            // 
            // textBoxSeach
            // 
            textBoxSeach.Location = new Point(12, 27);
            textBoxSeach.Name = "textBoxSeach";
            textBoxSeach.PlaceholderText = "Введите строку для поиска";
            textBoxSeach.Size = new Size(221, 29);
            textBoxSeach.TabIndex = 10;
            textBoxSeach.TextChanged += textBoxSeach_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(textBoxSeach);
            Controls.Add(comboBoxFilter);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxQuant);
            Controls.Add(textBoxName);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridViewInventors);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Уорк 25";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventors).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInventors;
        private StatusStrip statusStrip1;
        private TextBox textBoxName;
        private TextBox textBoxQuant;
        private TextBox textBoxPrice;
        private TextBox textBoxDesc;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button buttonAdd;
        private Button buttonEdit;
        private ToolStripStatusLabel toolStripStatusLabelCount;
        private ComboBox comboBoxFilter;
        private TextBox textBoxSeach;
    }
}
