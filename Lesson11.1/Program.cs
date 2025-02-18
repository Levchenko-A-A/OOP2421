
using System;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;

List<Project> projects = new List<Project>();
projects.Add(new Project(1, "Проект 1"));
projects.Add(new Project(2, "Проект 2"));
projects.Add(new Project(3, "Проект 3"));
Person<Gender, string, Color> p1 = new Person<Gender, string, Color>(
     "Ivan", 33, "Sity", "+7801455", 170, 55, Gender.Men, "негроидная", Color.Black);
Person<string, string, Color> p2 = new Person<string, string, Color>(
     "Ivan", 33, "Sity", "+7801455", 170, 55, "Мужской", "негроидная", Color.Black);
Teacher<Gender, string, Color> teacher = new Teacher<Gender, string, Color>("Петр", 26, "Site2","888-777",165,84,
    Gender.Men, "Европеоидная",Color.Magenta, 273, "Преподаватель", 73400, DateTime.Parse("12.02.2004"), "Программирование", 9);
Student<Gender, string, Color> student = new Student<Gender, string, Color>("Степан", 21, "Site3", "888-444", 173, 71,
    Gender.Men, "Европеоидная", Color.Gray, 118, "Студент", 21300, DateTime.Parse("12.02.2021"), 5,"АСУТП", 4.76);
Programmer<Gender, string, Color> programmer = new Programmer<Gender, string, Color>("Игорь", 21, "Site4", "222-444", 145, 39,
    Gender.Men, "Европеоидная", Color.Blue, 315, "Программист", 221300, DateTime.Parse("12.02.2000"), "C#/C++", projects, "Прикладная");
Console.WriteLine(teacher);
Console.WriteLine();
Console.WriteLine(student);
Console.WriteLine();
programmer.Display();

abstract class People<T, K, V>
{
    public double Rost { get; set; }
    public double Weight { get; set; }
    public T Pol { get; set; }
    public K Rassa { get; set; }
    public V ColorEyes { get; set; }

    public People(double rost, double weight, T pol, K rassa, V colorEyes)
    {
        Rost = rost;
        Weight = weight;
        Pol = pol;
        Rassa = rassa;
        ColorEyes = colorEyes;
    }
}
class Person<T, K, V>: People<T, K, V>
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public Person(string? _name, int _age, string? _address, string? _phone, double _rost, 
                     double _weight, T _pol, K _rassa, V _colorYeas): base(_rost, _weight, _pol, _rassa, _colorYeas)
    {
        Name = _name;
        Age = _age;
        Address = _address;
        Phone = _phone;
    }
}
class Employee<T, K, V>: Person<T, K, V>
{
    public Employee(string? _name, int _age, string? _address, string? _phone, double _rost, double _weight, T _pol, K _rassa, V _colorYeas,
        int _id, string _position, decimal _salary, DateTime _dateStart) : base(_name, _age, _address, _phone, _rost, _weight, _pol, _rassa, _colorYeas)
    {
        Id = _id;
        Position = _position;
        Salary = _salary;
        DateStart = _dateStart;
    }

    public int Id { get; set; }
    public string? Position { get; set; }
    public decimal? Salary { get; set; }
    public DateTime? DateStart { get; set; }
}
class Teacher<T, K, V>: Employee<T, K, V>
{
    public Teacher(string? _name, int _age, string? _address, string? _phone, double _rost, double _weight, 
                   T _pol, K _rassa, V _colorYeas, int _id, string _position, decimal _salary, DateTime _dateStart, 
                   string _sabject, int _experience) : 
                   base(_name, _age, _address, _phone, _rost, _weight, _pol, _rassa, _colorYeas, _id, _position, 
                        _salary, _dateStart)
    {
        Sabject = _sabject;
        Experience = _experience;
    }

    public string? Sabject { get; set; }
    public int Experience { get; set; }

    public override string? ToString()
    {
        return $"Класс Teacher:\nИмя: {Name}\nВозраст: {Age}\nАдрес: {Address}\nТелефон: {Phone}\nРост: {Rost}\n" +
               $"Вес: {Weight}\nПол: {Pol}\nРасса: {Rassa}\nЦвет глаз: {ColorEyes}\nИдентификатор: {Id}\n" +
               $"Должность: {Position}\nЗарплата: {Salary}\nДата приема: {DateStart}\n" +
               $"Предмет: {Sabject}\nСтаж преподавания: {Experience}";
    }
}
class Student<T, K, V> : Employee<T, K, V>
{
    public Student(string? _name, int _age, string? _address, string? _phone, double _rost, double _weight,
                   T _pol, K _rassa, V _colorYeas, int _id, string _position, decimal _salary, DateTime _dateStart,
                   int _course, string _specialization, double _averegeScore) :
                   base(_name, _age, _address, _phone, _rost, _weight, _pol, _rassa, _colorYeas, _id, _position,
                        _salary, _dateStart)
    {
        Course = _course;
        Specialization = _specialization;
        AveregeScore = _averegeScore;
    }

    public int Course { get; set; }
    public string? Specialization { get; set; }
    public double AveregeScore { get; set;}

    public override string? ToString()
    {
        return $"Класс Student:\nИмя: {Name}\nВозраст: {Age}\nАдрес: {Address}\nТелефон: {Phone}\nРост: {Rost}\n" +
               $"Вес: {Weight}\nПол: {Pol}\nРасса: {Rassa}\nЦвет глаз: {ColorEyes}\nИдентификатор: {Id}\n" +
               $"Должность: {Position}\nЗарплата: {Salary}\nДата приема: {DateStart}\n" +
               $"Курс: {Course}\nСпециальность: {Specialization}\nСредний бал: {AveregeScore}";
    }
}
class Manager<T, K, V> : Employee<T, K, V>
{
    public Manager(string? _name, int _age, string? _address, string? _phone, double _rost, double _weight,
                   T _pol, K _rassa, V _colorYeas, int _id, string _position, decimal _salary, DateTime _dateStart,
                   string? _managementAarea, int _numberOfSubordinates, int _managementExperience) :
                   base(_name, _age, _address, _phone, _rost, _weight, _pol, _rassa, _colorYeas, _id, _position,
                        _salary, _dateStart)
    {
        ManagementAarea = _managementAarea;
        NumberOfSubordinates = _numberOfSubordinates;
        ManagementExperience = _managementExperience;
    }

    public string? ManagementAarea { get; set; }
    public int NumberOfSubordinates { get; set; }
    public int ManagementExperience { get; set; }
}
class Programmer<T, K, V> : Employee<T, K, V>
{
    public Programmer(string? _name, int _age, string? _address, string? _phone, double _rost, double _weight,
                   T _pol, K _rassa, V _colorYeas, int _id, string _position, decimal _salary, DateTime _dateStart,
                   string? _programmingLanguage, List<Project> _projects, string? _specialization) :
                   base(_name, _age, _address, _phone, _rost, _weight, _pol, _rassa, _colorYeas, _id, _position,
                        _salary, _dateStart)
    {
        ProgrammingLanguage = _programmingLanguage;
        Projects = _projects;
        Specialization = _specialization;
    }

    public string? ProgrammingLanguage { get; set; }
    public List<Project> Projects { get; set; } = new();
    public string? Specialization {  get; set; }

    public void Add(Project task)
    {
        Projects.Add(task);
    }
    public void Display()
    {
        Console.WriteLine($"Класс Programmer:\nИмя: {Name}\nВозраст: {Age}\nАдрес: {Address}\nТелефон: {Phone}\nРост: {Rost}\n" +
               $"Вес: {Weight}\nПол: {Pol}\nРасса: {Rassa}\nЦвет глаз: {ColorEyes}\nИдентификатор: {Id}\n" +
               $"Должность: {Position}\nЗарплата: {Salary}\nДата приема: {DateStart}\n" +
               $"Язык программирования: {ProgrammingLanguage}\nСпециализация: {Specialization}\nПроекты, над которыми работал:");
        foreach (var item in Projects)
        {
            Console.Write(item);
            Console.WriteLine();
        }
    }

    public override string? ToString()
    {
        return $"Класс Programmer:\nИмя: {Name}\nВозраст: {Age}\nАдрес: {Address}\nТелефон: {Phone}\nРост: {Rost}\n" +
               $"Вес: {Weight}\nПол: {Pol}\nРасса: {Rassa}\nЦвет глаз: {ColorEyes}\nИдентификатор: {Id}\n" +
               $"Должность: {Position}\nЗарплата: {Salary}\nДата приема: {DateStart}\n" +
               $"Язык программирования: {ProgrammingLanguage}\nПроекты: {Projects}\nСпециализация: {Specialization}";
    }
}

enum Gender { Men, Women };

struct Project
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public Project(int id, string? name)
    {
        Id = id;
        Name = name;
    }

    public override string? ToString()
    {
        return $"Id: {Id}\nНазвание: {Name}";
    }
}
