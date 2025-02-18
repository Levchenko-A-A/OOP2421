using System.Text.Json;

Person person = new Person() { Name = "Ivan", Age = 35, Weight = 78 };
var options = new JsonSerializerOptions
{
    WriteIndented = true,
    AllowTrailingCommas = false,
    IgnoreReadOnlyFields = true
};


string json = JsonSerializer.Serialize(person, options);
Console.WriteLine(json);

Person? fromJson = JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(fromJson!.Name + " " + fromJson.Age + " " + fromJson.Weight);

List<Person> list = new List<Person>();
list.Add(person);
list.Add(new Person() { Name = "Adam", Age = 25, Weight = 48 });
list.Add(new Person() { Name = "Eva", Age = 18, Weight = 40 });

string jsonList = JsonSerializer.Serialize(list);
Console.WriteLine(jsonList);
List<Person?> listDes = JsonSerializer.Deserialize<List<Person>>(jsonList)!;
foreach (var item in listDes)
    Console.WriteLine(item);

Peopple peopple = new Peopple();
peopple.list = listDes;
string peopleJson = JsonSerializer.Serialize(peopple);
Console.WriteLine(peopleJson);

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
}
class Peopple
{
    public List<Person> list { get; set; } = new();

}
