using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using Lesson25._1;

StringReader reader = new StringReader("inventoryControl.csv");
CsvReader csvRead = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
List<Inventory> records = csvRead.GetRecords<Inventory>().ToList();
reader.Close();
do
{
    foreach (Inventory record in records)
    {
        Console.WriteLine($"Name: {record.Name}, Quntity: {record.Quantity}," +
            $"Price: {record.Price}, Description: {record.Description}");
    }
    Console.WriteLine("Выберите действие.\n" +
                      "1. Вычеслить среднее арифметическое количество\n" +
                      "2. Вывести max и min\n");
    int n = int.Parse(Console.ReadLine()!);
    switch(n)
    {
        case 1: break; 
        case 2: break;
    }
}
while (true);