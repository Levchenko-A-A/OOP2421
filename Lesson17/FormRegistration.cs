using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson17
{
    public partial class FormRegistration : Form
    {
        private UserRegistration UserRegistration;
        public FormRegistration()
        {
            InitializeComponent();
            UserRegistration = new UserRegistration();
            buttonReg.Enabled = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length < 7)
            {
                labelWarning.Text = "Длина пароля должна быть больше 7 символов";
                return;
            }
            labelWarning.Text = "";
        }

        private void textBoxRepit_TextChanged(object sender, EventArgs e)
        {
            string text = (sender as TextBox)!.Text;
            if (text != textBoxRegistration.Text)
            {
                labelPassWarning.Text = "Пароли должны совпадать";
                return;
            }
            labelPassWarning.Text = "";
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string? pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (!Regex.IsMatch((sender as TextBox)!.Text, pattern, RegexOptions.IgnoreCase))
            {
                labelEmailWarning.Text = "Не соответствует email";
                return;
            }
            labelEmailWarning.Text = "";
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (UserRegistration.ExistUser(textBoxLogin.Text))
            {
                MessageBox.Show("Пользователь с таким именем существует.");
            }
            int id = UserRegistration.Users.Count + 1;
            User user = new User();
            user.Id = id;
            user.UserName = textBoxLogin.Text;
            user.FirstName = textBoxFirstName.Text;
            user.SecondName = textBoxLastName.Text;
            user.Email = textBoxEmail.Text;
            user.Password = UserRegistration.Hash(textBoxRegistration.Text);
            user.RegistrationDate = DateTime.Now;
            user.BirthDate = dateTimePickerBers.Value;
            user.Role = comboBoxRole.SelectedItem.ToString();
            UserRegistration.RegisterUser(user);
            UserRegistration.SerializeUsersToJson(UserRegistration.Users);
            this.Close();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(textBoxLogin.Text!=""&&
                textBoxFirstName.Text!=""&&
                textBoxLastName.Text!=""&&
                textBoxEmail.Text!=""&&
                textBoxRegistration.Text.Length>=7&&
                textBoxRepit.Text.Length >= 7 &&
                textBoxRegistration.Text==textBoxRepit.Text&&
                comboBoxRole.SelectedIndex!=-1) 
            { 
                buttonReg.Enabled = true;
            }
        }
    }
}
