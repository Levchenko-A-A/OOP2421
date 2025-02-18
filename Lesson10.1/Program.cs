////string x = "dddd";
////Console.WriteLine(x.GetHashCode());
////string y = "tdddd";
////Console.WriteLine(y.GetHashCode());

//List<string> people = new List<string>()
//{
//    "First", "Second", "Ten", "Seven"
//};

//LinkedList<string> list = new LinkedList<string>(people);
//Console.WriteLine(list.Count);
//Console.WriteLine(list.First!.Value);
//Console.WriteLine(list.First!.Next!.Value);
//Console.WriteLine(list.Last!.Value);

//var curent = list.First;
//while(curent!=null)
//{
//    Console.WriteLine(curent.Value);
//    curent=curent.Next;
//}
//Console.WriteLine();
//curent = list.Last;
//while (curent != null)
//{
//    Console.WriteLine(curent.Value);
//    curent = curent.Previous;
//}

//list.AddLast("sdsds");
//list.AddFirst("qqqqq");
//if(list.First!=null) list.AddAfter(list.First,"six");
//if (list.Last != null) list.AddBefore(list.Last, "xxxxx");
//Console.WriteLine();
//curent = list.Last;
//while (curent != null)
//{
//    Console.WriteLine(curent.Value);
//    curent = curent.Previous;
//}

//if (list.Contains("qqqqq")) list.Remove(list.Find("qqqqq")!);
//curent = list.Last;

//while (curent != null)
//{
//    Console.WriteLine(curent.Value);
//    curent = curent.Previous;
//}

//SortedSet<int> ints = new SortedSet<int>(); //сортирует автоматически
//ints.Add(6);
//ints.Add(3);
//ints.Add(6);
//Console.WriteLine();
//foreach (int i in ints) Console.WriteLine(i+" ");

//HashSet<double> doubles = new HashSet<double>(); //не сортирует авоматически
//doubles.Add(12);
//doubles.Add(2);
//doubles.Add(6);
//doubles.Add(12);
//foreach(double d in doubles) Console.WriteLine(d+" ");

//List<string> listTask = new List<string>();
//listTask.Add("Первая задача");
//listTask.Add("Вторая задача");
//foreach (string task in listTask) Console.WriteLine(task);
//listTask.Remove("Первая задача");
//foreach (string task in listTask) Console.WriteLine(task);

////Учет посещения
//Dictionary<string, int> shoping = new Dictionary<string, int>();
//string enterString = "";
//do
//{
//    Console.WriteLine("Введите имя клиента:");
//    enterString = Console.ReadLine()!;
//    if (enterString == "exit") break;
//    if(shoping.ContainsKey(enterString)) shoping[enterString]++;
//    else shoping.Add(enterString, 1);
//    //shoping.Add(client, i++);
//}
//while (true);
//foreach(var item in shoping) Console.WriteLine(item.Key+" "+item.Value);

//bool IsUnique(int[] mas)
//{
//    HashSet<int> result = new HashSet<int>();
//    foreach (int ma in mas) result.Add(ma);
//    return result.Count == mas.Length;
//}

//int[] m1 = { 1, 2, 3, 4, 5 };
//int[] m2 = {1,2,3,3,4,5 };
//Console.WriteLine(IsUnique(m1));
//Console.WriteLine(IsUnique(m2));

//Random random = new Random();
//List<int> ints = new();
//SortedSet<int> s = new();
//for (int i = 0; i < random.Next(20,50);i++)
//{
//    int m = random.Next(10, 100);
//    s.Add(m);
//    ints.Add(random.Next(10,100));
//}
//ints.Sort();
//foreach (int i in ints) Console.Write(i+" ");
//Console.WriteLine();
//foreach (int it in s) Console.Write(it+" ");

//Подсчет количества вхождения слов
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

//Console.Write("Введите текст");
//string text = Console.ReadLine()!;
Dictionary<string, int> words = new Dictionary<string, int>();
//string[] mas= Regex.Split(text, "[,.:; ]+");

//foreach(string ma in mas)
//{
//    if (words.ContainsKey(ma)) words[ma]++;
//    else words.Add(ma, 1);
//}

//var dictString = $"Count: {words.Count}\n";
//int j = 0;
//foreach (var val in words)
//    dictString += $"[{j++}]:  \"{val.Key}\"   \"{val.Value}\"\n";
//Console.WriteLine(dictString);


//чтение файла с логами 
try
{
    using (StreamReader reader = new StreamReader("test.txt"))
    {
        string? line;
        while ((line = reader.ReadLine()!) != null)
        {
            string[] parts = line.Split(" Ошибка: ");
            if (words.ContainsKey(parts[1])) words[parts[1]]++;
            else words.Add(parts[1], 1);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error reading file: {ex.Message}");
}
string dictString = $"Count: {words.Count}\n";
int j = 0;
foreach (var val in words)
    dictString += $"[{j++}]:  \"{val.Key}\"   \"{val.Value}\"\n";
Console.WriteLine(dictString);

//касс календарь событий
//Разработайте календарь событий. События могут быть добавлены,
//удалены и просмотрены. Используйте List или Dictionary для хранения
//событий

//List<EventCalendar> events = new List<EventCalendar>();
//Console.WriteLine("Календарь\n " +
//                  "1- Ввод события." +
//                  "2- Просмотр" +
//                  "3- Удаление");
//do
//{
//    Console.Clear();
//    Console.WriteLine("Календарь\n " +
//                  "1- Ввод события." +
//                  "2- Просмотр" +
//                  "3- Удаление");
//    Console.Write("Ваш выбор:");
//    int n = int.Parse(Console.ReadLine()!);
//    switch(n)
//    {
//        case 1:
//            {
//                Console.Clear();
//                Console.Write("Введите название события:");
//                string? name = Console.ReadLine()!;
//                Console.Write("Введите дату:");
//                DateOnly date=DateOnly.Parse(Console.ReadLine()!);
//                events.Add(new EventCalendar() { NameEvent=name, Date=date });
//            } break;
//        case 2:
//            {
//                int i = 0;
//                foreach(EventCalendar item in events)
//                {
//                    Console.WriteLine(++i+" ");
//                    Console.WriteLine(item);
//                }
//                Console.ReadLine();
//            } break;
//        case 3:
//            {
//                Console.WriteLine("Введите номер записи для удаления");
//                int k=int.Parse(Console.ReadLine()!);
//                events.RemoveAt(k - 1);
//            } break;
//        default: break;
//    }
//}
//while (true);
//class EventCalendar
//{
//    public string? NameEvent { get; set; }
//    public DateOnly Date { get; set; }
//}

