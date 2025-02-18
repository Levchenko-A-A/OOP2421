using Lesson2;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

//int a = 6;
//int b = 9;
//TwoPair twoPair1 = new TwoPair(a,b);
//twoPair1.Print();
//TwoPair twoPair2 = new TwoPair();
//twoPair2.Print();
//TwoPair twoPair3 = new TwoPair(twoPair1);
//twoPair3.Print();

Railway railway = new Railway();
for (int i = 0; i < 5; i++)
{
    Console.Write("ведите пункт назначения:");
    string name = Console.ReadLine()!;
    Console.Write("ведите номер:");
    int number = int.Parse(Console.ReadLine()!);
    Console.Write("Введите Дату и время отправления:");
    DateTime time = DateTime.Parse(Console.ReadLine()!);
    railway.Add(new Train() { Name = name, Number = number, Time = time });
}

List<Train> train = new List<Train>();
train.Add(new Train() { Name = "rrttr", Number = 4, Time = DateTime.Parse("13.08.2024") });
Sorts.SortByName(train);
Railway railway2 = new Railway(train);
railway.Print();
railway.SortByNumber();
Console.WriteLine();
railway.Print();
Console.WriteLine();
railway.SortByName();
railway.Print();