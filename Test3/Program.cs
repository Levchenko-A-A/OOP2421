using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr148_1
{
    class Alpha
    {
        protected int alpha;                    // Защищенное целочисленное поле: 
        private char[] symbs;                   // Закрытый массив: 
        public Alpha(int a, string txt)         // Конструктор с двумя аргументами: 
        {
            alpha = a;                          // Присваивание значения полю: 
            symbs = txt.ToCharArray();          // Создание массива на основе текстового аргумента: 
        }
        public virtual int number               // Виртуальное свойство: 
        {
            get => alpha;                       // Аксессор для считывания значения:
            set => alpha = value;               // Аксессор для присваивания значения: 
        }
        public int length                       // Открытое свойство: 
        {
            get => symbs.Length;                // Аксессор для считывания значения: 
        }
        
        public char this[int k]                 // Символьный индексатор с целочисленным индексом: 
        {
            get => symbs[k];                    // Аксессор для считывания значения: 
            set => symbs[k] = value;            // Аксессор для присваивания значения: 
        }
        public virtual int this[char s]         // Виртуальный целочисленный индексатор с символьным индексом:
        {                      
            get => this[s - 'a'];               // Используется индексирование объекта:                          
            set => this[s - 'a'] = (char)value; // Используется индексирование объекта: 
        }
        public override string ToString()           // Переопределение метода ToString(): 
        {
            string txt = "|";                       // Текстовая переменная: 
            for (int k = 0; k < this.length; k++)   // Формируется значение текстовой переменной: 
                txt += this[k] + "|";
            return txt;                             // Результат метода: 
        }
    }
    class Bravo : Alpha
    {
        
        protected int bravo;                                    // Защищенное целочисленное поле: 
        public Bravo(int a, int b, string txt) : base(a, txt)   // Конструктор с тремя аргументами: 
        {
            bravo = b;                                          // Значение целочисленного поля: 
        }
        public override int number                              // Переопределение свойства: 
        {
            get => alpha + bravo;                               // Аксессор для считывания значения: 
        }
        public override int this[char s]                        // Переопределение индексатора с символьным индексом: 
        {
            get                                                 // Аксессор для считывания значения: 
            {
                if (s == 'a') return alpha;
                else return bravo;
            }
            set                                                 // Аксессор для присваивания значения: 
            {
                if (s == 'a')
                    alpha = value;
                else bravo = value;
            }
        }
    }

    // Класс с главным методом: 
    class Program
    {
        // Главный метод:
        static void Main()
        {
            int k;                                          // Целочисленная переменная: 
            char s;                                         // Символьная переменная: 
            Alpha A = new Alpha(100, "ABCDEF");               // Создание объекта базового класса:
            Console.WriteLine("Объект A:");
            Console.WriteLine(A);                           // Содержимое символьного массива объекта:
            Console.WriteLine("А.number = " + A.number);    // Значение свойства number объекта:
            A.number = 150;                                 // Присваивание значения свойству number:
            Console.WriteLine("A.number = " + A.number);    // Значение свойства number объекта:
            for (k = 0, s = 'a'; k < A.length; k++, s++)  // Индексирование объекта: 
            {
                Console.WriteLine((char)'a' - 'a');
                Console.WriteLine("Символ \'{0}\' с кодом {1}", A[k], A[s]);
            }
            A[0] = 'E';
            A['c'] = 'A' + 10;
            Console.WriteLine(A);                           // Содержимое символьного массива объекта:
            //// Создание объекта производного класса:
            //Bravo B = new Bravo(200, 300, "EFGHI");
            //Console.WriteLine("Объект В:");
            //// Содержимое массива объекта:
            //Console.WriteLine(B);
            //// Значение свойства number объекта:
            //Console.WriteLine("В.number = " + B.number);
            //// Присваивание значения свойству number объекта:
            //B.number = 400;
            //// Значение свойства number объекта:
            //Console.WriteLine("В.number = " + B.number);
            //// Индексирование объекта:
            //B['a'] = 10;
            //B['d'] = 20;
            //Console.WriteLine("В[\'a\'] = " + B['a']);
            //Console.WriteLine("В[\'b\'] = " + B['b']);
            //// Проверка значения свойства number объекта:
            //Console.WriteLine("В.number = " + B.number);
            //// Индексирование объекта: 
            //for (k = 0; k < B.length; k++)
            //{
            //    Console.Write(B[k] + " ");
            //    B[k] = (char)('a' + k);
            //}
            //Console.WriteLine();
            //// Проверка содержимого массива объекта:
            //Console.WriteLine(B);
            //// Задержка:
            //Console.ReadLine();
        }
    }
}

//Проверка входящего индекса
//class Company
//{
//    Person[] personal;
//    public Company(Person[] people) => personal = people;
//    // индексатор
//    public Person this[int index]
//    {
//        get
//        {
//            // если индекс имеется в массиве
//            if (index >= 0 && index < personal.Length)
//                return personal[index]; // то возвращаем объект Person по индексу
//            else
//                throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
//        }
//        set
//        {
//            // если индекс есть в массиве
//            if (index >= 0 && index < personal.Length)
//                personal[index] = value;    // переустанавливаем значение по индексу
//        }
//    }
//}