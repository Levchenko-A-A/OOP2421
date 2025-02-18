using CsvHelper;
using CsvHelper.Configuration;
using Lesson25;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.PortableExecutable;

//List<Person> list = new List<Person>(); 
//list.Add(new Person() { Name = "Ivan", Age = 23 });
//list.Add(new Person() { Name = "Sergei", Age = 19 });
//list.Add(new Person() { Name = "Mike", Age = 23 });
//list.Add(new Person() { Name = "Ivan", Age = 23 });
//StreamWriter writer = new StreamWriter("output.csv");
//CsvConfiguration csvConfig = new
//CsvConfiguration(CultureInfo.InvariantCulture)
//{
//    Delimiter = ";"
//};
//CsvWriter csvWriter = new CsvWriter(writer, csvConfig);
//csvWriter.WriteRecords(list);
//writer.Close();

//List<Person> list = new List<Person>();
StringReader stringReader = new StringReader("output.csv");
CsvConfiguration csvConfig = new
CsvConfiguration(CultureInfo.InvariantCulture)
{
    Delimiter = ";"
};
CsvReader csvRead = new CsvReader(stringReader, csvConfig);
//CsvReader csvRead = new CsvReader(stringReader, new
//CsvConfiguration(CultureInfo.InvariantCulture));
List<Person> records = csvRead.GetRecords<Person>().ToList();
stringReader.Close();
foreach (Person person in records)
{
    Console.WriteLine($"Имя: {person.Name} \n Возраст: { person.Age }    " ); 
}




