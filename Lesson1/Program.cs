using Lesson1;

//Pair pair=new Pair() { Firsr=6.9, Second=7.3};
//Console.WriteLine("Сумма "+pair.Sum());
//Console.WriteLine("Макс "+pair.Max());
//pair.Firsr = 74;
//pair.Second = 34;
//Console.WriteLine("Сумма " + pair.Sum());
//Console.WriteLine("Макс " + pair.Max());

//Console.Write("Введите нижнюю границу:");
//int low;
//int.TryParse(Console.ReadLine()!, out low);
//Console.Write("Введите верхнюю границу:");
//int high;
//int.TryParse(Console.ReadLine()!, out high);
//Console.Write("Введите значение счетчика:");
//int count;
//int.TryParse(Console.ReadLine()!, out count);
//Counter counter = new Counter() { Low = low, High = high, Count = count };
//counter.Valide();
//counter.Inc();
//Console.WriteLine(counter.Count);
//counter.Decrement();
//Console.WriteLine(counter.Count);

Time time = new Time() { Hour = 20, Minute = 15, Second = 30 };
time.Print();
time.AddHour(10);
time.Print();
time.SubMinutes(50);
time.SubHours(12);
time.Print();

double a = 3;
double b = 4;
double c = 5;
Triangle triangle = new Triangle(a, b, c);
triangle.Print();
triangle.A = 8;
//triangle.Valide();
triangle.Print();

