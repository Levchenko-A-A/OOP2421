using Lesson6_1;

//Person person = new Person("Tom");
//person.Print();

//Employee emp=new Employee("Bob", "Microfost");
//emp.Print();
//;

//person = new Employee("Tom","Google");
//person.Print();

//Client client = new Client("Sam", "Standsrt");
//Console.WriteLine(client);

////Upcasting
//Employee employee = new Employee("John", "Beeline");
//Person bill = employee;
//Console.WriteLine(bill.Name);

//object client1 = new Client("Sara", "MTS");

////DownCasting

//Employee emp1 = (Employee)bill;
//emp1.Print();
//object obj2 = new Employee("Barak", "WhiteHouse");
//Console.WriteLine(((Person)obj2).Name??"");

//Способы преобразования
//Person person = new Person("Tom");
//Employee? emp=person as  Employee;
//if (person is Employee)
//{
//    emp.Company = "Google";
//    Console.WriteLine(emp?.Company);
//}
//else
//{
//    Console.WriteLine("Объект не создан");
//}

List<Student> students = new List<Student>();
students.Add(new Student() { FirstName = "Ivan", LartName = "Ivanov", Group = "POB2316", AvarageMark = 4.9 });
students.Add(new Aspirant() { FirstName = "Petr", LartName = "Petrovich", Group = "POB2416", AvarageMark = 4.5 });
students.Add(new Student() { FirstName = "Nikolai", LartName = "Nikolaevich", Group = "POB1416", AvarageMark = 5 });
foreach (var i in students)
{
    if(i is Aspirant)
    Console.WriteLine(((Aspirant)i).getScholarShip());
    else Console.WriteLine(i.getScholarShip());
}
