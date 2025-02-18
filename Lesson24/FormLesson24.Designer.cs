namespace Lesson24
{
    partial class FormLesson24
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewUser = new DataGridView();
            UserFirstName = new DataGridViewTextBoxColumn();
            UserLastName = new DataGridViewTextBoxColumn();
            UserAge = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxAge = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { UserFirstName, UserLastName, UserAge });
            dataGridViewUser.ContextMenuStrip = contextMenuStrip1;
            dataGridViewUser.Location = new Point(6, 7);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowTemplate.Height = 25;
            dataGridViewUser.Size = new Size(565, 468);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.CellClick += dataGridViewUser_CellClick;
            dataGridViewUser.KeyDown += dataGridViewUser_KeyDown;
            // 
            // UserFirstName
            // 
            UserFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserFirstName.HeaderText = "Имя";
            UserFirstName.Name = "UserFirstName";
            // 
            // UserLastName
            // 
            UserLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserLastName.HeaderText = "Фамилия";
            UserLastName.Name = "UserLastName";
            // 
            // UserAge
            // 
            UserAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserAge.HeaderText = "Возраст";
            UserAge.Name = "UserAge";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(118, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(577, 7);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Имя";
            textBoxFirstName.Size = new Size(224, 35);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(577, 48);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(224, 35);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(577, 89);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.PlaceholderText = "Возраст";
            textBoxAge.Size = new Size(224, 35);
            textBoxAge.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(678, 130);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(123, 36);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Enabled = false;
            buttonEdit.Location = new Point(678, 172);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(123, 38);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // FormLesson24
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 487);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(dataGridViewUser);
            Enabled = false;
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormLesson24";
            Text = "FormLesson24";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUser;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxAge;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn UserFirstName;
        private DataGridViewTextBoxColumn UserLastName;
        private DataGridViewTextBoxColumn UserAge;
        private Button buttonEdit;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}