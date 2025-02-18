using Word = Microsoft.Office.Interop.Word;

namespace Test8
{
    public partial class Form1 : Form
    {
        Word.Application wordApp = new Word.Application();
        public Form1()
        {
            InitializeComponent();
            

        }

    }
}
