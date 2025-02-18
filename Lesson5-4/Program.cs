//var tuple = (5, 10);
//Console.WriteLine(tuple.Item1);
//Console.WriteLine(tuple.Item2);

int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10,100);
    Console.Write(mas[i]+" ");
}

for (int i = 0; i < mas.Length-1; i++)
{
    for( int j = i+1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
            (mas[i], mas[j]) = (mas[j], mas[i]);
    }
}
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    
    Console.Write(mas[i] + " ");
}

Console.WriteLine(GetValues(mas).Max);
print(("Vasiy",26));

(int Max, int Min, double Avg) GetValues(int[] mas)
{
    int max=mas.Max();
    int min = mas.Min();
    double avg=mas.Average();
    return (max, min, avg);
}

void print((string name, int age) person)
{
    Console.WriteLine(person.name, person.age);
}

(int[] Max, int[] Min) GetSort(int[] mas)
{
    int[] mas1 = new int[mas.Length];
    int[] mas2 = new int[mas.Length];
    for (int i = 0; i < mas1.Length - 1; i++)
        mas1[i] = mas[i];
    for (int i = 0; i < mas1.Length - 1; i++)
        mas2[i] = mas[i];
    for (int i = 0; i < mas1.Length - 1; i++)
    {
        for (int j = i + 1; j < mas1.Length; j++)
        {
            if (mas1[i] > mas1[j])
                (mas1[i], mas1[j]) = (mas1[j], mas1[i]);
        }
    }
    for (int i = 0; i < mas2.Length - 1; i++)
    {
        for (int j = i + 1; j < mas2.Length; j++)
        {
            if (mas2[i] < mas2[j])
                (mas2[i], mas2[j]) = (mas2[j], mas2[i]);
        }
    }
    return (mas1, mas2);
    
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(GetSort(mas).Max[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(GetSort(mas).Min[i]+" ");
}
