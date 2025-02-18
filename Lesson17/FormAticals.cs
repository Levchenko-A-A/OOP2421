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
    public partial class FormAticals : Form
    {
        private AticalsHandler handler;
        public FormAticals()
        {
            InitializeComponent();
            handler = new AticalsHandler();
            if (UserAuthentification.RegisterUser!.Role == "Читатель")
            {
                buttonAdd.Visible = false;
                buttonDel.Visible = false;
                buttonEdit.Visible = false;
            }
            else
            {
                buttonAdd.Visible = true;
                buttonDel.Visible = true;
                buttonEdit.Visible = true;
            }
            handler.ReadAticals();
            UpdateList();
        }

        private void FormAticals_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAutorisation.instance!.Show();
            UserAuthentification.ExitUser();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAtical formAtical = new FormAtical();
            if (formAtical.ShowDialog() == DialogResult.OK)
            {
                Atical atical = new Atical();
                atical.Theme = formAtical.textBoxTheme.Text;
                atical.Autor = formAtical.textBoxAuthor.Text;
                atical.Age = (int)formAtical.numericUpDownAge.Value;
                atical.Title = formAtical.textBoxAtical.Text;
                atical.Content = formAtical.richTextBox1.Text;
                handler.Add(atical);
                UpdateList();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxAticals.SelectedIndex != -1)
            {
                Atical atical = handler.getAtical(listBoxAticals.SelectedIndex);
                handler.Remove(atical);
                UpdateList();
            }
        }

        private void UpdateList()
        {
            listBoxAticals.Items.Clear();
            List<Atical> list = handler.getAticals();
            for (int i = 0; i < list.Count; i++)
            {
                listBoxAticals.Items.Add(list[i].Title + " " + list[i].Autor);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxAticals.SelectedIndex != -1)
            {
                Atical atical = handler.getAtical(listBoxAticals.SelectedIndex);
                FormAtical formAtical = new FormAtical();
                formAtical.textBoxAtical.Text = atical.Title;
                formAtical.richTextBox1.Text = atical.Content;
                formAtical.textBoxAuthor.Text = atical.Autor;
                formAtical.textBoxTheme.Text = atical.Theme;
                formAtical.numericUpDownAge.Value = atical.Age;
                if (formAtical.ShowDialog() == DialogResult.OK)
                {
                    handler.getAtical(listBoxAticals.SelectedIndex).Age = (int)formAtical.numericUpDownAge.Value;
                    handler.getAtical(listBoxAticals.SelectedIndex).Theme = formAtical.textBoxTheme.Text;
                    handler.getAtical(listBoxAticals.SelectedIndex).Title = formAtical.textBoxAtical.Text;
                    handler.getAtical(listBoxAticals.SelectedIndex).Content = formAtical.richTextBox1.Text;
                    UpdateList();
                }
            }
        }

        private void listBoxAticals_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAticals.SelectedIndex != -1)
            {
                Atical atical = handler.getAtical(listBoxAticals.SelectedIndex);
                FormReadAtical formReadAtical = new FormReadAtical(atical);
                formReadAtical.Show();
            }
        }

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserAuthentification.ExitUser();
            FormAutorisation.instance!.Show();
            this.Close();
        }
    }
}
