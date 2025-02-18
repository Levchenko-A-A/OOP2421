using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29._1_TovNak
{
    internal class Nakladnaya: IComparable
    {
        [DisplayName("Название товара")]
        public string? Name { get; set; }
        [DisplayName("Количество")]
        public int Quantity { get; set; }
        [DisplayName("Стоимость")]
        public decimal Price { get; set; }
        [DisplayName("ФИО поставщика")]
        public string? Provider { get; set; }
        [DisplayName("ФИО получателя")]
        public string? Recipient { get; set; }
        [DisplayName("Дата поставки")]
        public DateTime Date { get; set; }
        public Nakladnaya() { }

        public int CompareTo(object? obj)
        {
            if (obj is Nakladnaya nak)
                return Name!.CompareTo(nak.Name);
            else throw new ArgumentException("Некорректное значение");
        }
    }
}
