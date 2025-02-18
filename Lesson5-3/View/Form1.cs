using Lesson5_3.Model;

namespace Lesson5_3.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Eat();
            person.Move();
            Human human = new Human("Василий");
            MessageBox.Show(human.Name);
            //human.Name = "Борис";
            MessageBox.Show(human.Name);
        }
    }
}