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
    public partial class FormAtical : Form
    {
        public FormAtical()
        {
            InitializeComponent();
            textBoxAuthor.Text = UserAuthentification.RegisterUser!.FirstName + " " + UserAuthentification.RegisterUser!.SecondName;
        }
    }
}
