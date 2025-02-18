using Word = Microsoft.Office.Interop.Word;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace Lesson27._2
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFile;
        private FontStyle fontStyle;
        private FontFamily fontFamily;
        private float size;
        public Form1()
        {
            InitializeComponent();
            fontStyle = FontStyle.Regular;
            fontFamily = FontFamily.GenericMonospace;
            size = 14;
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Word files(*.docx)|*.docx";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc;
                wordDoc = wordApp.Documents.Open(openFile.FileName);
                this.Text = openFile.FileName;
                Word.Range range = wordDoc.Content;
                string str = string.Empty;
                for (int i = 0; i < wordDoc.Paragraphs.Count; i++)
                {
                    str += wordDoc.Paragraphs[i + 1].Range.Text + "\n";
                }
                richTextBoxText.Text = str;
                richTextBoxText.SelectAll();
                richTextBoxText.SelectionFont = new System.Drawing.Font(fontFamily, size, fontStyle);
                textBoxFont.Text = fontFamily.Name;
                numericUpDownSize.Value = decimal.Parse(size.ToString());
                wordDoc.Close();
                wordApp.Quit();
            }
        }

        private void checkBoxBolt_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxText.SelectedText.Length != 0)
            {
                if (checkBoxBolt.Checked)
                {
                    richTextBoxText.SelectionFont = new System.Drawing.Font("Veranda", 12, FontStyle.Bold);
                }
                else
                {
                    richTextBoxText.SelectionFont = new System.Drawing.Font("Veranda", 12, FontStyle.Regular);
                }

            }
        }

        private void buttonFond_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFont.Text = fontDialog.Font.FontFamily.Name;
                richTextBoxText.SelectionFont = new System.Drawing.Font(fontDialog.Font.FontFamily,
                                                                        fontDialog.Font.Size,
                                                                        fontDialog.Font.Style);
                fontFamily = fontDialog.Font.FontFamily;
                fontStyle = fontDialog.Font.Style;
                size = fontDialog.Font.Size;
                numericUpDownSize.Value = decimal.Parse(size.ToString());

            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxText.SelectionColor = colorDialog.Color;
            }
        }

        private void ñîõðàíèòüÊàêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word files(*.docx)|*.docx|Rich text format (*.rtf)|*.rtf";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc;
                wordDoc = wordApp.Documents.Open(saveFileDialog.FileName);
                wordDoc.Content.Delete();
                //Word.Paragraph heading = wordDoc.Paragraphs.Add();
                string res = string.Empty;
                string[] mas = res.Split("\n");
                for (int i = 0; i < mas.Length; i++)
                {
                        Word.Paragraph heading = wordDoc.Paragraphs.Add();
                        heading.Range.Text += mas[i];
                }
                Word.Range range = wordDoc.Content;
                range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphThaiJustify;
                wordDoc.SaveAs2(saveFileDialog.FileName);
                wordDoc.Close();
                wordApp.Quit();
            }
        }

        private void numericUpDownSize_ValueChanged(object sender, EventArgs e)
        {
            richTextBoxText.SelectionFont = new System.Drawing.Font(fontFamily, (float)numericUpDownSize.Value,
                                                                    fontStyle);
        }

        private void toolStripButtonJust_Click(object sender, EventArgs e)
        {
            richTextBoxText.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}

//https://www.cyberforum.ru/csharp-beginners/thread310479.html?ysclid=m4rcr4pram849888196