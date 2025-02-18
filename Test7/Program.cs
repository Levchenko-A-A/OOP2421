using OfficeOpenXml;

string filePath = "F:\\OOP\\OOP2421\\Test7\\bin\\Debug\\net8.0\\newBook.xlsx";
ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
ExcelPackage newBook = new ExcelPackage(filePath);
//newBook.Workbook.Worksheets.Add("List1");
//newBook.Workbook.Worksheets.Add("List2");
ExcelWorksheet worksheet1 = newBook.Workbook.Worksheets["List1"];
ExcelWorksheet worksheet2 = newBook.Workbook.Worksheets["List2"];
//ExcelWorksheet workToDelet = newBook.Workbook.Worksheets["List2"];
//if(workToDelet != null)
//{
//    newBook.Workbook.Worksheets.Delete(workToDelet);
//}
ExcelWorksheet currentWorrsheet = newBook.Workbook.Worksheets["List1"];
currentWorrsheet.Cells["A1"].Value = "Значение в А1";
currentWorrsheet.Cells["B1"].Value = "Значение в B1";
currentWorrsheet.Cells["A2"].Value = "Значение в А2";
currentWorrsheet.Cells["B2"].Value = "Значение в B2";

//currentWorrsheet.Cells["A1"].Value = null;
//currentWorrsheet.Cells["B1"].Value = "";

string[] data = new string[] { "Значение1", "Значение2", "Значение3" };
for (int i = 0; i < data.Length; i++)
{
    currentWorrsheet.Cells[i + 1, 1].Value = data[i];
}

newBook.Save();
newBook.SaveAs("newBook.xlsx");