using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr145_1
{
    // Базовый класс: 
    class Alpha
    {
        // Открытое поле: 
        public int alpha;
        // Виртуальный метод: 
        public virtual void show()
        {
            Console.WriteLine("Класс Alpha: {0}", alpha);
        }
        // Конструктор с одним аргументом: 
        public Alpha(int a)
        {
            alpha = a;
        }
    }

    // Производный класс от класса Alpha: 
    class Bravo : Alpha
    {
        // Открытое поле: 
        public int bravo;
        // Переопределение виртуального метода: 
        public override void show()
        {
            Console.WriteLine("Класс Bravo: {0} и {1}", alpha, bravo);
        }
        // Конструктор с двумя аргументами:
        public Bravo(int a, int b) : base(a)
        {
            bravo = b;
        }
    }

    // Производный класс от класса Bravo: 
    class Charlie : Bravo
    {
        // Открытое поле: 
        public int charlie;
        // Переопределение виртуального метода: 
        public override void show()
        {
            Console.WriteLine("Класс Charlie: {0}, {1} и {2}", alpha, bravo, charlie);
        }
        // Конструктор с тремя аргументами: 
        public Charlie(int a, int b, int c) : base(a, b)
        {
            charlie = c;
        }
    }

    // Класс с главным методом:
    class Program
    {
        static void Main()
        {
            // Главный метод:
            // Создание объекта класса Alpha:
            Alpha objA = new Alpha(10);
            // Проверка значения поля: 
            objA.show();
            Console.WriteLine();
            // Создание объекта класса Bravo:
            Bravo objB = new Bravo(20, 30);
            // Объектной переменной базового класса присваивается 
            // ссылка на объект производного класса: 
            objA = objB;
            // Проверка значений полей: 
            objA.show();
            objB.show();
            Console.WriteLine();
            // Создание объекта класса Charlie:
            Charlie objC = new Charlie(40, 50, 60);
            // Объектной переменной базового класса присваивается 
            // ссылка на объект производного класса: 
            objA = objC;
            objB = objC;
            // Проверка значений полей: 
            objA.show();
            objB.show();
            objC.show();
            // Задержка:
            Console.ReadLine();
        }
    }
}
