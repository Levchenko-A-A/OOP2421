namespace Lesson17
{
    partial class FormRegistration
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
            textBoxLogin = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxRegistration = new TextBox();
            textBoxRepit = new TextBox();
            dateTimePickerBers = new DateTimePicker();
            buttonReg = new Button();
            labelWarning = new Label();
            labelPassWarning = new Label();
            labelEmailWarning = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(24, 24);
            textBoxLogin.Margin = new Padding(5, 6, 5, 6);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Введите Логин";
            textBoxLogin.Size = new Size(484, 36);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(24, 72);
            textBoxFirstName.Margin = new Padding(5, 6, 5, 6);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Введите Имя";
            textBoxFirstName.Size = new Size(484, 36);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(24, 120);
            textBoxLastName.Margin = new Padding(5, 6, 5, 6);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Введите Фамилию";
            textBoxLastName.Size = new Size(484, 36);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(24, 168);
            textBoxEmail.Margin = new Padding(5, 6, 5, 6);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Введите Адрес почты";
            textBoxEmail.Size = new Size(484, 36);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxRegistration
            // 
            textBoxRegistration.Location = new Point(22, 232);
            textBoxRegistration.Margin = new Padding(5, 6, 5, 6);
            textBoxRegistration.Name = "textBoxRegistration";
            textBoxRegistration.PasswordChar = '*';
            textBoxRegistration.PlaceholderText = "Введите Пароль";
            textBoxRegistration.Size = new Size(484, 36);
            textBoxRegistration.TabIndex = 4;
            textBoxRegistration.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxRepit
            // 
            textBoxRepit.Location = new Point(22, 297);
            textBoxRepit.Margin = new Padding(5, 6, 5, 6);
            textBoxRepit.Name = "textBoxRepit";
            textBoxRepit.PasswordChar = '*';
            textBoxRepit.PlaceholderText = "Повторите Пароль";
            textBoxRepit.Size = new Size(484, 36);
            textBoxRepit.TabIndex = 5;
            textBoxRepit.TextChanged += textBoxRepit_TextChanged;
            // 
            // dateTimePickerBers
            // 
            dateTimePickerBers.Location = new Point(22, 369);
            dateTimePickerBers.Name = "dateTimePickerBers";
            dateTimePickerBers.Size = new Size(484, 36);
            dateTimePickerBers.TabIndex = 6;
            // 
            // buttonReg
            // 
            buttonReg.Location = new Point(188, 481);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(145, 41);
            buttonReg.TabIndex = 7;
            buttonReg.Text = "Зарегистрироваться";
            buttonReg.UseVisualStyleBackColor = true;
            buttonReg.Click += buttonReg_Click;
            // 
            // labelWarning
            // 
            labelWarning.AutoSize = true;
            labelWarning.BackColor = SystemColors.Control;
            labelWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWarning.ForeColor = Color.Red;
            labelWarning.Location = new Point(22, 274);
            labelWarning.Name = "labelWarning";
            labelWarning.Size = new Size(0, 17);
            labelWarning.TabIndex = 8;
            // 
            // labelPassWarning
            // 
            labelPassWarning.AutoSize = true;
            labelPassWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassWarning.ForeColor = Color.Red;
            labelPassWarning.Location = new Point(22, 334);
            labelPassWarning.Name = "labelPassWarning";
            labelPassWarning.Size = new Size(0, 17);
            labelPassWarning.TabIndex = 9;
            // 
            // labelEmailWarning
            // 
            labelEmailWarning.AutoSize = true;
            labelEmailWarning.BackColor = SystemColors.Control;
            labelEmailWarning.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmailWarning.ForeColor = Color.Red;
            labelEmailWarning.Location = new Point(24, 209);
            labelEmailWarning.Name = "labelEmailWarning";
            labelEmailWarning.Size = new Size(0, 17);
            labelEmailWarning.TabIndex = 10;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Автор", "Читатель" });
            comboBoxRole.Location = new Point(22, 426);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(484, 38);
            comboBoxRole.TabIndex = 11;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 534);
            Controls.Add(comboBoxRole);
            Controls.Add(labelEmailWarning);
            Controls.Add(labelPassWarning);
            Controls.Add(labelWarning);
            Controls.Add(buttonReg);
            Controls.Add(dateTimePickerBers);
            Controls.Add(textBoxRepit);
            Controls.Add(textBoxRegistration);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLogin);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormRegistration";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxRegistration;
        private TextBox textBoxRepit;
        private DateTimePicker dateTimePickerBers;
        private Button buttonReg;
        private Label labelWarning;
        private Label labelPassWarning;
        private Label labelEmailWarning;
        public ComboBox comboBoxRole;
    }
}