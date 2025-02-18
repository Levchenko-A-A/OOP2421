using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal static class Sorts
    {
        public static void SortByNumber(List<Train> Trains)
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
        public static void SortByName(List<Train> Trains)
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
            for (int j = 0; j < Trains.Count - 1; j++)
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
    }
}
