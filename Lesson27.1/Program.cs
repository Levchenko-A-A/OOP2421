using Word = Microsoft.Office.Interop.Word;
string? path = "E:\\OOP\\OOP2421\\Lesson27.1\\bin\\Debug\\net8.0\\First.docx";

//Открытие
//Word.Application wordApp = new Word.Application();
//Word.Document wordDoc = wordApp.Documents.Add();
//Word.Document wordDoc = wordApp.Documents.Open(path);
//Word.Paragraph para1 = wordDoc.Paragraphs.Add();
//para1.Range.Text = "Это первый текстовый блок\n";
//Word.Paragraph para2 = wordDoc.Paragraphs.Add();
//para2.Range.Text = "Это второй текстовый блок\n";
//Word.Paragraph para3 = wordDoc.Paragraphs.Add();
//para3.Range.Text = "Это третий текстовый блок";

//--------------------------------------------------------------------------------------
//Чтение и изменение
//Word.Application wordApp = new Word.Application();
//Word.Document wordDoc = wordApp.Documents.Open(path);
//Word.Paragraph para1 = wordDoc.Paragraphs.Add();
//Word.Range range = wordDoc.Content;
//range.Find.Execute("Это второй текстовый блок", ReplaceWith: "Замененный параграф");
//wordDoc.SaveAs2(path);
//wordDoc.Close();
//wordApp.Quit();

//--------------------------------------------------------------------------------------
//Изменение параметров на весь лист
//Word.Application wordApp = new Word.Application();
//Word.Document wordDoc = wordApp.Documents.Open(path);
//Word.Paragraph para1 = wordDoc.Paragraphs.Add();
//Word.Range range = wordDoc.Content;
//range.Font.Name = "Arial";
//range.Font.Size = 14;
//range.Font.Bold = 1;
//range.Font.Color = Word.WdColor.wdColorRed;
//wordDoc.SaveAs2(path);
//wordDoc.Close();
//wordApp.Quit();

//--------------------------------------------------------------------------------------
//Изменение параметров на весь лист
Word.Application wordApp = new Word.Application();
Word.Document wordDoc = wordApp.Documents.Open(path);
Word.Paragraph para1 = wordDoc.Paragraphs.Add();
Word.Range range = wordDoc.Content;
range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;

range.Font.Name = "Arial";
range.Font.Size = 14;
range.Font.Bold = 1;
range.Font.Color = Word.WdColor.wdColorRed;
Word.Paragraph heading = wordDoc.Paragraphs.Add();
heading.Range.Font.Name = "Times New Roman";
heading.Range.Font.Size = 18;
heading.Range.Font.Bold = 1;
heading.Range.Font.Color = Word.WdColor.wdColorGreen;
heading.Range.Text = "Замененный параграф";

wordDoc.SaveAs2(path);
wordDoc.Close();
wordApp.Quit();

Word.Application wordApp = new Word.Application();