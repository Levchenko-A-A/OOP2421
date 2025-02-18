using System.Collections;

//string[] people = { "Tom", "Sam", "Bob" };
//IEnumerator peopleEnumerator = people.GetEnumerator();
//while (peopleEnumerator.MoveNext())
//{
//    string item = (string)peopleEnumerator.Current;
//    Console.WriteLine(item);
//}
//peopleEnumerator.Reset();
//Console.WriteLine();
//while (peopleEnumerator.MoveNext())
//{
//    string item = (string)peopleEnumerator.Current;
//    Console.WriteLine(item);
//}
//Console.WriteLine();
//Week week = new Week();
//foreach(var day in week)
//{
//    Console.WriteLine(day);
//}

//class WeekEnumerator : IEnumerator
//{
//    private string[] days;
//    int index = -1;
//    public WeekEnumerator(string[] days)
//    {
//        this.days = days;
//    }

//    public object Current
//    {
//        get 
//        {
//            if (index == -1 || index >= days.Length)
//                throw new ArgumentException();
//            return days[index]; 
//        }
//    }
//    public bool MoveNext()
//    {
//        if(index < days.Length-1)
//        {
//            index++;
//            return true;
//        }
//        return false;
//    }
//    public  void Reset() => index = -1;
//}

//class Week: IEnumerable
//{
//    string[] days = { "Monday", "Tuesday", "Wensday", "Thirthday", "Fraiday", "Saaday", "Sanday"};
//    //public IEnumerator GetEnumerator() => days.GetEnumerator();
//    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
//}

Person[] people = new Person[]
{
    new Person("Tom"),
    new Person("Bob"),
    new Person("Sam")
};
Company company = new Company(people);

foreach (Person person in company)
    Console.WriteLine(person.Name);

class Person
{
    public string? Name { get; set; }

    public Person(string? name)
    {
        Name = name;
    }
}

class Company
{
    private Person[] personal;

    public Company(Person[] personal)
    {
        this.personal = personal;
    }
    public int Length => personal.Length;
    public IEnumerator<Person> GetEnumerator()
    {
        for (int i = 0; i < personal.Length; i++)
        {
            yield return personal[i];
        }
    }
}