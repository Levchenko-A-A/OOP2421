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
    public partial class FormReadAtical : Form
    {
        public FormReadAtical(Atical atical)
        {
            InitializeComponent();
            this.Text = atical.Title + " " + atical.Autor;
            labelText.Text = atical.Content;
        }
    }
}
