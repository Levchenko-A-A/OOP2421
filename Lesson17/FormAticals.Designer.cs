namespace Lesson17
{
    partial class FormAticals
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
            listBoxAticals = new ListBox();
            buttonDel = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            linkLabelExit = new LinkLabel();
            SuspendLayout();
            // 
            // listBoxAticals
            // 
            listBoxAticals.FormattingEnabled = true;
            listBoxAticals.ItemHeight = 15;
            listBoxAticals.Location = new Point(12, 32);
            listBoxAticals.Name = "listBoxAticals";
            listBoxAticals.Size = new Size(361, 364);
            listBoxAticals.TabIndex = 0;
            listBoxAticals.DoubleClick += listBoxAticals_DoubleClick;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(264, 421);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(111, 28);
            buttonDel.TabIndex = 1;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(14, 421);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(111, 28);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(131, 421);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(127, 28);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // linkLabelExit
            // 
            linkLabelExit.AutoSize = true;
            linkLabelExit.Location = new Point(318, 9);
            linkLabelExit.Name = "linkLabelExit";
            linkLabelExit.Size = new Size(42, 15);
            linkLabelExit.TabIndex = 4;
            linkLabelExit.TabStop = true;
            linkLabelExit.Text = "Выход";
            linkLabelExit.LinkClicked += linkLabelExit_LinkClicked;
            // 
            // FormAticals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 461);
            Controls.Add(linkLabelExit);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDel);
            Controls.Add(listBoxAticals);
            Name = "FormAticals";
            Text = "Стати";
            FormClosed += FormAticals_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAticals;
        private Button buttonDel;
        private Button buttonAdd;
        private Button buttonEdit;
        private LinkLabel linkLabelExit;
    }
}