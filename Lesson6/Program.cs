//string name = null;
//string resultName = name ?? "Valera";
//Console.WriteLine(resultName);

//string name = null;
//string resultName = name ?? "Valera";
//Console.WriteLine(resultName);
//Console.WriteLine(name??"Валера");


void PrintWebSite(Person? person)
{
    if (person != null)
    {
        if (person.Company != null)
        {
            if (person.Company.WebSity != null)
            {
                Console.WriteLine(person.Company.WebSity.ToUpper());
            }
        }
    }
    //ИЛИ
    if ((person != null) && (person.Company != null) && (person.Company.WebSity != null))
        Console.WriteLine(person.Company.WebSity.ToUpper());
    //ИЛИ
    Console.WriteLine(person?.Company?.WebSity?.ToUpper() ?? "Error");

}
Company company = new Company();
//company.WebSity = "mail.ru";
company.WebSity = null;
Person person = new Person();
person.Company = company;
PrintWebSite(person);

class Person
{
    public Company? Company { get; set; }
}

class Company
{
    public string? WebSity { get; set; }
}

