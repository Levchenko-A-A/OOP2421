using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using OfficeOpenXml;
using System.ComponentModel;
using Word = Microsoft.Office.Interop.Word;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Lesson29._1_TovNak
{
    public partial class Form1 : Form
    {
        List<Nakladnaya> records;
        private ListSortDirection direction;
        StringReader stringReader;
        string path = "E:\\OOP\\OOP2421\\Lesson29.1 TovNak\\bin\\Debug\\net8.0-windows\\Товарная накладная.docx";
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
            direction = ListSortDirection.Ascending;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Csv files(*.csv)|*.csv|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.FileName);
                CsvReader csvReader = new CsvReader(reader,
                    new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ";",
                        HasHeaderRecord = false,
                        HeaderValidated = null
                    });
                records = csvReader.GetRecords<Nakladnaya>().ToList();
                reader.Close();
                records.RemoveAt(0);
                records.Sort();
                records = records.GroupBy(d => new { d.Name, d.Provider, d.Recipient, d.Date, d.Price }).Select(g => new Nakladnaya()
                {
                    Name = g.Key.Name,
                    Provider = g.Key.Provider,
                    Recipient = g.Key.Recipient,
                    Date = g.Key.Date,
                    Price = g.Key.Price,
                    Quantity = g.Sum(d => d.Quantity)
                }).ToList();
                UpdateForm(records);
            }
            UpdateForm(records);
        }
        private void UpdateForm(List<Nakladnaya> tmp)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tmp;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[i].ReadOnly = true;
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Xlsx files(*.xlsx)|*.xlsx|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage newBook = new ExcelPackage(fileInfo);
                if (newBook.Workbook.Worksheets.Contains(newBook.Workbook.Worksheets["Продукты"]) == false)
                    newBook.Workbook.Worksheets.Add("Продукты");
                ExcelWorksheet worksheet = newBook.Workbook.Worksheets["Продукты"];
                worksheet.Cells[1, 1].Value = "Название";
                worksheet.Cells[1, 2].Value = "Количество";
                worksheet.Cells[1, 3].Value = "Цена";
                worksheet.Cells[1, 4].Value = "Поставщик";
                worksheet.Cells[1, 5].Value = "Получатель";
                worksheet.Cells[1, 6].Value = "Дата";
                for (int i = 0; i < records.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = records[i].Name;
                    worksheet.Cells[i + 2, 2].Value = records[i].Quantity;
                    worksheet.Cells[i + 2, 3].Value = records[i].Price;
                    worksheet.Cells[i + 2, 4].Value = records[i].Provider;
                    worksheet.Cells[i + 2, 5].Value = records[i].Recipient;
                    worksheet.Cells[i + 2, 6].Value = records[i].Date;
                }
                newBook.SaveAs(fileInfo);
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (direction == ListSortDirection.Ascending) direction = ListSortDirection.Descending;
            else direction = ListSortDirection.Ascending;
            List<Nakladnaya> temp = new List<Nakladnaya>();
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        if (direction == ListSortDirection.Ascending)
                        {
                            temp = records.OrderBy(p => p.Name).ToList();
                        }
                        else
                        {
                            temp = records.OrderByDescending(p => p.Name).ToList();
                        }
                        UpdateForm(temp);
                    }
                    break;
                case 1:
                    {
                        if (direction == ListSortDirection.Ascending)
                        {
                            temp = records.OrderBy(p => p.Quantity).ToList();
                        }
                        else
                        {
                            temp = records.OrderByDescending(p => p.Quantity).ToList();
                        }
                        UpdateForm(temp);
                    }
                    break;
                case 2:
                    {
                        if (direction == ListSortDirection.Ascending)
                        {
                            temp = records.OrderBy(p => p.Price).ToList();
                        }
                        else
                        {
                            temp = records.OrderByDescending(p => p.Price).ToList();
                        }
                        UpdateForm(temp);
                    }
                    break;
                case 3:
                    {
                        if (direction == ListSortDirection.Ascending)
                        {
                            temp = records.OrderBy(p => p.Provider).ToList();
                        }
                        else
                        {
                            temp = records.OrderByDescending(p => p.Provider).ToList();
                        }
                        UpdateForm(temp);
                    }
                    break;
                case 4:
                    {
                        if (direction == ListSortDirection.Ascending)
                        {
                            temp = records.OrderBy(p => p.Recipient).ToList();
                        }
                        else
                        {
                            temp = records.OrderByDescending(p => p.Recipient).ToList();
                        }
                        UpdateForm(temp);
                    }
                    break;
                case 5:
                    {
                        if (direction == ListSortDirection.Ascending)
                        {
                            temp = records.OrderBy(p => p.Date).ToList();
                        }
                        else
                        {
                            temp = records.OrderByDescending(p => p.Date).ToList();
                        }
                        UpdateForm(temp);
                    }
                    break;
            }
        }

        private void buttonWorld_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int index = dataGridView1.CurrentRow.Index;
                Nakladnaya current = records[index];
                Word.Application wordApp = new Word.Application();
                Word.Document doc = wordApp.Documents.Open(path);
                Word.Range range = doc.Content;
                range.Find.Execute("номер", Replace:(index+1).ToString());
                range = doc.Content;
                range.Find.Execute("дата", Replace: current.Date);
                range = doc.Content;
                range.Find.Execute("ФИО поставщика", Replace: current.Provider);
                range = doc.Content;
                range.Find.Execute("ФИО покупателя", Replace: current.Recipient);
                range = doc.Content;
                range.Find.Execute("Адрес_доставки", Replace: "Остров сокровищ");
                range = doc.Content;
                range.Find.Execute("Сумма_итого1", Replace: current.Price*current.Quantity);
                range = doc.Content;
                range.Find.Execute("кол-во", current.Quantity);
                range = doc.Content;
                range.Find.Execute("cумма_итого2", Replace: current.Price * current.Quantity);
                range = doc.Content;
                doc.SaveAs2(Environment.CurrentDirectory + $"\\Накладная {index+1}.docs");
                if (File.Exists(Environment.CurrentDirectory + $"\\Накладная {index + 1}.docs"))
                    MessageBox.Show("Накладная успешно создана");
                doc.Close();
                wordApp.Quit();
            }
            else MessageBox.Show("Выделите строку");
        }
    }
}
