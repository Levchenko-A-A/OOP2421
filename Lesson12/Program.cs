Person p1 = new Person();
Person p2 = new Person()
{
    Name = "Ivan",
    Age = 20
};

Console.WriteLine(p1.Name);
Console.WriteLine(p1.Age);
p1.Move();
Console.WriteLine(IMovable.minSpeed);
Console.WriteLine(IMovable.maxSpeed);

Car car = new Car() { Name = "Mersedes", Age = 5 };
car.Move();
car.Eat();
class Car : IMovable, Ieating
{
    private string? name;
    public string? Name 
    {
        get => name;
        set => name = value;
    }
    private int age;
    public int Age 
    {
        get => age;
        set
        {
            if (value > 0) age = value;
        }
    }

    public void Move()
    {
        Console.WriteLine("Она едет"); ;
    }

    public void Eat()
    {
        Console.WriteLine("Пью все, что горит");
    }
}

class Person:IMovable,Ieating
{
    private string? name;
    public string Name
    {
        get => name;
        set => name=value;
    }
    private int age;
    public int Age
    {
        get => age;
        set
        {
            if (value > 0 && value < 150) age = value;
            else throw new Exception("Возраст не может быть больше 120");
        }
    }
    public void Move()
    {
        Console.WriteLine("Я гуляю");
    }

    public void Eat()
    {
        Console.WriteLine("Ем все, что вкусно");
    }
}
//class Implementation : IMyInterface<int>
//{
//    public int GetValue()
//    {
//        throw new NotImplementedException();
//    }

//    public void SetValue(int value)
//    {
//        throw new NotImplementedException();
//    }
//}
//class ImplementationString : IMyInterface<string>
//{
//    public string GetValue()
//    {
//        throw new NotImplementedException();
//    }

//    public void SetValue(string value)
//    {
//        throw new NotImplementedException();
//    }
//}

interface IMovable
{
    const int minSpeed = 0;
    static int maxSpeed = 60;
    void Move();
    string Name { get; set; }
    int Age { get; set; }
    delegate void MoveHendler(string message);
}

interface Ieating
{
    void Eat();
}
interface IMyInterface<T>
{
    T GetValue();
    void SetValue(T value);
}
