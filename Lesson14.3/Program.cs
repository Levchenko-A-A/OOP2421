using System;

//int[] Mult(int[] mas, Predicate<int> func)
//{
//    List<int> result = new List<int>();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) result.Add(mas[i]);
//    }
//    return result.ToArray();
//}
//int[] mas = new int[10];
//Random rand = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rand.Next(1, 21);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//foreach (int i in Mult(mas, x => x % 2 == 0))
//    Console.Write(i + " ");
//Console.WriteLine();

//-------------------------------------------

//DateTime[] DFilterDate(DateTime[] mas, Predicate<DateTime> func)
//{
//    List<DateTime> result = new List<DateTime>();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) result.Add(mas[i]);
//    }
//    return result.ToArray();
//}
//DateTime[] mdate = new DateTime[3]
//{
//    new DateTime(2024, 12, 5),
//    new DateTime(2024, 10, 5),
//    new DateTime(2024, 7, 9)
//};

//foreach(DateTime i in DFilterDate(mdate, x => x>DateTime.Now))
//    Console.WriteLine(i+" ");

//------------------------------------------
//string[] FilterString(string[] mas, Predicate<string> func)
//{
//    List<string> result = new ();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) result.Add(mas[i]);
//    }
//    return result.ToArray();
//}
//string[] mdate = new string[5]
//{
//    "fhndyjdy",
//    "tghns",
//    "khgdsh",
//    "vhunbgyug",
//    "dfs"
//};

//foreach (string i in FilterString(mdate, x => x.Length>=5))
//    Console.WriteLine(i);

//----------------------------------------------------

//Persson[] FilterPersson(Persson[] mas, Predicate<Persson> func)
//{
//    List<Persson> result = new();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) result.Add(mas[i]);
//    }
//    return result.ToArray();
//}


//Persson[] mdate = {
//new Persson { Name="Andrei", Age=88},
//new Persson { Name = "Semen", Age = 15 },
//new Persson { Name = "Anton", Age = 5 },
//new Persson { Name = "Dima", Age = 32 },
//new Persson { Name = "Kostia", Age = 79 } };

//foreach (Persson i in FilterPersson(mdate, x => x.Age >= 20))
//    Console.WriteLine(i);
//class Persson
//{
//    public string Name { get; set; }
//    private int age;
//    public int Age 
//    { 
//        get => age; 
//        set { if (value > 0 && value < 120) age = value; } 
//    }

//    public override string? ToString()
//    {
//        return $"{Name} - {Age}";
//    }
//}

//-----------------------------------------------
//double Add(double x, double y) => x + y;
//double Sub(double x, double y) => x - y;
//double Mul(double x, double y) => x * y;
//double Div(double x, double y) => x / y;
//Operation[] Calc = new Operation[4];
//{
//    Calc[0] = Add;
//    Calc[1] = Sub;
//    Calc[2] = Mul;
//    Calc[3] = Div;
//}

//Console.Write("Введите первое число: ");
//double first = 0;
//double.TryParse(Console.ReadLine(), out first);
//Console.Write("Введите второе число: ");
//double second = 0;
//double.TryParse(Console.ReadLine(), out second);
//Console.Write("Введите операцию: ");
//char operation = char.Parse(Console.ReadLine()!);
//switch (operation)
//{
//    case '+': Console.WriteLine(Calc[0](first, second)); break;
//    case '-': Console.WriteLine(Calc[1](first, second)); break;
//    case '*': Console.WriteLine(Calc[2](first, second)); break;
//    case '/': Console.WriteLine(Calc[3](first, second)); break;
//    default:
//        Console.WriteLine("Некорректный ввод."); break;
//}

//public delegate double Operation(double x, double y);

//---------------------------------------------
//void Add(double x, double y) => Console.WriteLine(x + y);
//void Sub(double x, double y) => Console.WriteLine(x - y);
//void Mul(double x, double y) => Console.WriteLine(x * y);
//void Div(double x, double y) => Console.WriteLine(x / y);

//Operation delMas = Add;
//delMas += Sub;
//delMas += Mul;
//delMas += Div;

//Console.Write("Введите первое число: ");
//double first = 0;
//double.TryParse(Console.ReadLine(), out first);
//Console.Write("Введите второе число: ");
//double second = 0;
//double.TryParse(Console.ReadLine(), out second);
//delMas(first, second);
//public delegate void Operation(double x, double y);

//-------------------------------------------------------------
//FactGelegate fact = delegate (int x)
//{
//    long f = 1;
//    for (int i = 1; i <= x; i++)
//    {
//        f *= i;
//    }
//    return f;
//};
//Console.WriteLine(fact(10));
//delegate long FactGelegate(int x);

//---------------------------------------------------------

UserInfo[] userInfos =
{
    new UserInfo("Sam","Brown", 150000),
    new UserInfo("Bob","Red", 120000),
    new UserInfo("Jordj","Town", 180000),
    new UserInfo("Garry","Clinton", 110000)
};
ArrSort.Sort(userInfos, UserInfo.UserSalary);
foreach (UserInfo i in userInfos)
    Console.WriteLine(i);
class ArrSort
{
    public static void Sort<T>(IList<T> sortArray, Func<T,T,bool> res)
    {
        bool mySort = true;
        do
        {
            mySort = false;
            for(int i = 0;i<sortArray.Count-1;i++)
            {
                if (res(sortArray[i + 1], sortArray[i]))
                {
                    T j= sortArray[i];
                    sortArray[i] = sortArray[i+1];
                    sortArray[i + 1]=j;
                    mySort = true;
                }
            }
        }
        while (mySort);
    }
}
class UserInfo
{
    public string? Name { get; set; }
    public string? Family { get; set; }
    public decimal? Salary { get; set; }

    public UserInfo(string? name, string? family, decimal? salary)
    {
        Name = name;
        Family = family;
        Salary = salary;
    }

    public override string? ToString()
    {
        return Name + " " + Family + " " + Salary;
    }
    public static bool UserSalary(UserInfo userInfo1, UserInfo userInfo2)
    {
        return userInfo1.Salary > userInfo2.Salary;
    }
}