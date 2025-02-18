using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson17
{
    public partial class FormAutorisation : Form
    {
        private UserAuthentification userAuthentification;
        public static FormAutorisation? instance;
        //private UserRegistration UserRegistration;
        public FormAutorisation()
        {
            InitializeComponent();
            instance = this;
            userAuthentification = new UserAuthentification();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            if (userAuthentification.Users != null)
            {
                foreach (User s in userAuthentification.Users!)
                {
                    source.Add(s.UserName);
                }

                textBoxLogin.AutoCompleteCustomSource = source;
                textBoxLogin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxLogin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(userAuthentification.AuthentificationUser(textBoxLogin.Text,textBoxPassword.Text));
            {
                FormAticals formAticals = new FormAticals();
                formAticals.Show();
                this.Hide();
            }
        }
    }
}
