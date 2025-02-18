//using Microsoft.Office.Interop.Word;
//using Word = Microsoft.Office.Interop.Word;
//string path = "E:\\OOP\\OOP2421\\Lesson28.1\\bin\\Debug\\net8.0\\111.docx";
//Word.Application wordApp = new Word.Application();
//Word.Document wordDoc = wordApp.Documents.Open(path);
////wordDoc.Content.Delete();
////AddNewTable(3, 7, "first", wordDoc);
////AddNewTable(9, 5, "second", wordDoc);

//Table table = wordDoc.Tables[1];
//Random random = new Random();
//foreach(Row row in table.Rows)
//{
//    foreach(Cell cell in row.Cells)
//    {
//        cell.Range.Text = random.Next(10, 101).ToString();
//    }
//}

//wordDoc.Save();
//wordDoc.Close();
//wordApp.Quit();
////Открытие


//void AddNewTable(int rows, int colunms, string tableName, Word.Document doc)
//{
//    Word.Paragraph paragraph = doc.Paragraphs.Add();
//    paragraph.Range.Text = $"\r{tableName}\n";
//    Word.Table table = doc.Tables.Add(paragraph.Range, NumRows: rows, NumColumns: colunms);
//    table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
//    table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
//    table.Borders.OutsideColor = Word.WdColor.wdColorBlack;
//    table.Borders.InsideColor = Word.WdColor.wdColorBlack;
//    table.Cell(1, 1).Range.Text = "Ячейка 1-1";
//    table.Cell(1, 2).Range.Text = "Ячейка 1-2";
//}

//---------------------------------------------------------------
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
string path = "E:\\OOP\\OOP2421\\Lesson28.1\\bin\\Debug\\net8.0\\forma.docx";
Word.Application wordApp = new Word.Application();
Word.Document wordDoc = wordApp.Documents.Open(path);
Word.Range renge = wordDoc.Content;
renge.Find.Execute("[число, месяц, год]", DateTime.Now.ToShortDateString());



wordDoc.Save();
wordDoc.Close();
wordApp.Quit();