using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr146_1
{
    // Базовый класс: 
    class Alpha
    {
        // Обычный (не виртуальный) метод: 
        public void hello()
        {
            Console.WriteLine("Метод hello() из класса Alpha");
        }
        // Виртуальный метод: 
        public virtual void hi()
        {
            Console.WriteLine("Метод hi() из класса Alpha");
        }
        // Обычный (не виртуальный) метод: 
        public void show()
        {
            // Вызов методов: 
            hello();
            hi();
            Console.WriteLine();
        }
    }

    // Производный класс: 
    class Bravo : Alpha
    {
        // Замещение метода: 
        new public void hello()
        {
            Console.WriteLine("Метод hello() из класса Bravo");
        }
        // Переопределение виртуального метода: 
        public override void hi()
        {
            Console.WriteLine("Метод hi() из класса Bravo");
        }
    }

    // Класс с главным методом: 
    class Program
    {
        // Главный метод:
        static void Main()
        {
            Alpha A = new Alpha();
            Console.WriteLine("Выполнение команды A.show():");
            // Вызов метода:
            A.show();
            // Создание объекта производного класса:
            Bravo B = new Bravo();
            Console.WriteLine("Выполнение команды B.hello():");
            // Вызов замещающего метода из производного класса:
            B.hello();
            Console.WriteLine("Выполнение команды В.hi():");
            // Вызов переопределенного метода:
            B.hi();
            Console.WriteLine("Выполнение команды В.show():");
            // Вызов унаследованного метода:
            B.show();
            Console.WriteLine("После выполнения команды А=В");
            // Объектной переменной базового класса присваивается 
            // ссылка на объект производного класса:
            A = B;
            Console.WriteLine("Выполнение команды A.hello():");
            // Вызов замещаемого метода:
            A.hello();
            Console.WriteLine("Выполнение команды A.hi():");
            // Вызов переопределенного метода:
            A.hi();
            Console.WriteLine("Выполнение команды A.show():");
            // Вызов унаследованного метода:
            A.show();
            // Задержка:
            Console.ReadLine();
        }
    }
}
