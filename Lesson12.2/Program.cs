using Lesson12._2;
using System.Collections;

Student<int>[] mas = new Student<int>[3];
mas[0] = new Student<int>("Vasia", 16);
mas[1] = new Student<int>("Boris", 13);
mas[2] = new Student<int>("Eugen", 10);

Array.Sort(mas);
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}
Array.Sort(mas, new FioSortComparatorInt());
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}

Student<string>[] group = new Student<string>[3];
group[0] = new Student<string>("Vano", "qwe");
group[1] = new Student<string>("Gigo", "asd");
group[2] = new Student<string>("Viko", "zxc");

Array.Sort(group);
for (int i = 0; i < group.Length; i++)
{
    Console.WriteLine(group[i]);
}
Console.WriteLine();

Array.Sort(group, new FioSortComparatorString());
Console.WriteLine();
for (int i = 0; i < group.Length; i++)
{
    Console.WriteLine(group[i]);
}

Student<int> student = new Student<int>("Ivaan", 15);
Student<int> stuuudent = (Student<int>)student.Clone();
Console.WriteLine();
Console.WriteLine(student);
Console.WriteLine(stuuudent);
class FioSortComparatorInt : IComparer
{

    public int Compare(object? x, object? y)
    {
        var student1 = x as Student<int>;
        var student2 = y as Student<int>;
        if (student1!.FIO.CompareTo(student2!.FIO) > 0) return 1;
        else if (student1!.FIO.CompareTo(student2!.FIO) == 0) return 0;
        return -1;
    }
}

class FioSortComparatorString : IComparer
{

    public int Compare(object? x, object? y)
    {
        var student1 = x as Student<string>;
        var student2 = y as Student<string>;
        if (student1!.FIO.CompareTo(student2!.FIO) > 0) return 1;
        else if (student1!.FIO.CompareTo(student2!.FIO) == 0) return 0;
        return -1;
    }
}