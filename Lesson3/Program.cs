﻿using Lesson3;
using System.Transactions;

//TwoPair twoPair=new TwoPair(6,8);
//twoPair.Print();

//Engine auto = new Engine()
//{
//    Name = "Mersedec",
//    Rashod = 8,
//    Volume = 45
//};
//auto.AddFill(40);
//Console.WriteLine("Текущий уровень: "+auto.PrintCurrent());
//auto.Way(200);
//Console.WriteLine("Текущий уровень: " + auto.PrintCurrent());
//Console.WriteLine("Смогу проехать "+auto.CanGo());

//Sklad sklad = new Sklad()
//{
//    Fio = "Иванов П.П.",
//    Number = 2,
//    MaxVolume = 500,
//    Current = 100
//};
//sklad.Print();
//sklad.Add(250);
//sklad.Print();
//sklad.Add(400);
//sklad.Print();
//sklad.Sub(300);
//sklad.Print();
//sklad.Sub(1000);
//sklad.Print();

MassivIndex massive=new MassivIndex();
massive.Print();
for(int i = 0; i < massive.list.Count; i++)
{
    Console.WriteLine(massive[i]+" ");
}