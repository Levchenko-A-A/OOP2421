using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    struct Train
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }
    }
    internal class Railway
    {
        public List<Train> Trains { get; set; } = new();

        public void Add(Train train) => Trains.Add(train);

        public Railway(List<Train> trains)
        {
            Trains = trains;
        }

        public Railway()
        {
        }

        public void SortByNumber()
        {
            for (int i = 1; i < Trains.Count; i++)
            {
                Train key = Trains[i];
                int j = i - 1;
                while (j >= 0 && Trains[j].Number > key.Number)
                {
                    Trains[j + 1] = Trains[j];
                    j--;
                }
                Trains[j + 1] = key;
            }
        }
        public void SortByName()
        {
            for (int i = 1; i < Trains.Count; i++)
            {
                Train key = Trains[i];
                int j = i - 1;
                while (j >= 0 && Trains[j].Name.CompareTo(key.Name) > 0)
                {
                    Trains[j + 1] = Trains[j];
                    j--;
                }
                Trains[j + 1] = key;
            }
            for (int j = 0; j < Trains.Count-1; j++)
            {
                if (Trains[j + 1].Name.CompareTo(Trains[j].Name) == 0)
                {
                    if (Trains[j].Time > Trains[j + 1].Time)
                    {
                        Train temp = Trains[j + 1];
                        Trains[j + 1] = Trains[j];
                        Trains[j] = temp;
                    }
                }
            }
        }

        public void Print()
        {
            foreach (Train t in Trains)
            {
                Console.WriteLine($"Пункт назначения:{t.Name,10} Номер поезда:{t.Number,6} Время отправления:{t.Time,6}");
            }
        }
    }


    internal class TwoPair
    {
        private int a;
        private int b;
        //конструктор с параметрами
        public TwoPair(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        //конструктор по умолчанию (без параметров) - по умолчанию
        public TwoPair()
        {
            a = 1;
            b = 1;
        }

        //конструктор копирования
        public TwoPair(TwoPair tp)
        {
            a= tp.a;
            b= tp.b;
        }

        //диструктор
        ~TwoPair()
        {
            Console.WriteLine("Объект удален!");
        }
        public void Print()
        {
            Console.WriteLine("a="+a+"  b="+b);
        }
    }
}
