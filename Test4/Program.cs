//1.Управление задачами:
//Создайте консольное приложение для управления списком задач.
//Используйте List для хранения задач. Пользователь должен иметь
//возможность добавлять, удалять и просматривать задачи.

//List<string> listTask = new List<string>();
//listTask.Add("Первая задача");
//listTask.Add("Вторая задача");
//foreach (string task in listTask) Console.WriteLine(task);
//listTask.Remove("Первая задача");
//foreach (string task in listTask) Console.WriteLine(task);

//2. Учет посещений:
//Разработайте программу для учета посещений магазина. Используйте
//Dic_onary для отслеживания количества посещений для каждого клиента.
//Пользователь вводит имя, а словарь увеличивает счетчик посещений.
//При вводе слова “выход”, выводится список всех клиентов и количества их
//посещений

//Dictionary<string, int> shoping = new Dictionary<string, int>();
//string enterString = "";
//do
//{
//    Console.WriteLine("Введите имя клиента:");
//    enterString = Console.ReadLine()!;
//    if (enterString == "exit") break;
//    if (shoping.ContainsKey(enterString)) shoping[enterString]++;
//    else shoping.Add(enterString, 1);
//    //shoping.Add(client, i++);
//}
//while (true);
//foreach (var item in shoping) Console.WriteLine(item.Key + " " + item.Value);


//3. Проверка на уникальность:
//Напишите функцию, которая принимает массив и возвращает true, если
//все элементы в массиве уникальны, и false в противном случае.
//Используйте HashSet для решения этой задачи.

//bool IsUnique(int[] mas)
//{
//    HashSet<int> result = new HashSet<int>();
//    foreach (int ma in mas) result.Add(ma);
//    return result.Count == mas.Length;
//}

//int[] m1 = { 1, 2, 3, 4, 5 };
//int[] m2 = { 1, 2, 3, 3, 4, 5 };
//Console.WriteLine(IsUnique(m1));
//Console.WriteLine(IsUnique(m2));

//4. Сортировка чисел:
//Создайте приложение для сортировки списка чисел. Реализуйте
//сортировку с использованием List, а затем сравните производительность с
//SortedSet.

//Random random = new Random();
//List<int> ints = new();
//SortedSet<int> s = new();
//for (int i = 0; i < random.Next(20, 50); i++)
//{
//    int m = random.Next(10, 100);
//    s.Add(m);
//    ints.Add(random.Next(10, 100));
//}
//ints.Sort();
//foreach (int i in ints) Console.Write(i + " ");
//Console.WriteLine();
//foreach (int it in s) Console.Write(it + " ");

//5. Подсчет слов:
//Напишите программу, которая считает количество вхождений каждого
//слова в тексте. Используйте Dictionary<string, int> для хранения
//результатов.

/// Console.Write("Введите текст");
//string text = Console.ReadLine()!;
//Dictionary<string, int> words = new Dictionary<string, int>();
//string[] mas= Regex.Split(text, "[,.:; ]+");

//foreach(string ma in mas)
//{
//    if (words.ContainsKey(ma)) words[ma]++;
//    else words.Add(ma, 1);
//}

//var dictString = $"Count: {words.Count}\n";
//int j = 0;
//foreach (var val in words)
//    dictString += $"[{j++}]:  \"{val.Key}\"   \"{val.Value}\"\n";
//Console.WriteLine(dictString);
//6. Учет инвентаря:
//Разработайте приложение для учета инвентаря в магазине. Используйте
//разные коллекции (например, Dictionary для товаров и их количества, а
//HashSet для отслеживания, какие товары были проданы).


//Dictionary<string, int> inventory = new Dictionary<string, int>();  
//HashSet<string> soldItems = new HashSet<string>();                  
//inventory.Add("Книга", 5);                                          
//soldItems.Add("Книга");                                             
//if (inventory.ContainsKey("Книга"))                                 
//    Console.WriteLine($"Товар {inventory["Книга"]} доступен.");
//else
//    Console.WriteLine($"Товар не найден в инвентаре.");
//if (soldItems.Contains("Книга"))                                    
//    Console.WriteLine($"Товар был продан.");
//else
//    Console.WriteLine($"Товар не был продан.");

//7. Анализ логов - повышенная сложность:
//Создайте программу для анализа логов. Прочитайте лог-файл, разделите
//его на строки, и затем подсчитайте количество ошибок каждого типа.
//Используйте Dictionary для этой задачи.
//Dictionary<string, int> words = new Dictionary<string, int>();
//try
//{
//    using (StreamReader reader = new StreamReader("test.txt"))
//    {
//        string? line;
//        while ((line = reader.ReadLine()!) != null)
//        {
//            string[] parts = line.Split(" Ошибка: ");
//            if (words.ContainsKey(parts[1])) words[parts[1]]++;
//            else words.Add(parts[1], 1);
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Error reading file: {ex.Message}");
//}
//string dictString = $"Count: {words.Count}\n";
//int j = 0;
//foreach (var val in words)
//    dictString += $"[{j++}]:  \"{val.Key}\"   \"{val.Value}\"\n";
//Console.WriteLine(dictString);

//9.Календарь событий:
//Разработайте календарь событий.События могут быть добавлены,
//удалены и просмотрены. Используйте List или Dictionary для хранения
//событий.

//List<EventCalendar> list = new();
//Console.WriteLine("Календарь\n 1 - Ввод события\n" +
//    "2 - Просмотр\n 3 - Удаление:");
//do
//{
//Console.Clear();
//Console.WriteLine("Календарь\n 1 - Ввод события\n" +
//"2 - Просмотр\n 3 - Удаление:");
//int n = int.Parse(Console.ReadLine()!);
//switch (n)
//{
//case 1:
//{
//Console.Write("Введите название события:");
//string name = Console.ReadLine()!;
//Console.Write("Введите дату события:");
//DateOnly date = DateOnly.Parse(Console.ReadLine()!);
//list.Add(new EventCalendar()
//{
//NameEvent = name,
//Date = date
//});
//}
//break;
//case 2:
//{
//int i = 0;
//foreach (EventCalendar calendar in list)
//{
//Console.Write(++i + ".");
//Console.WriteLine(calendar);
//}
//Console.ReadKey();
//}
//break;
//case 3:
//{
//Console.Write("Введите номер события для удаления:");
//int k = int.Parse(Console.ReadLine()!);
//list.RemoveAt(k - 1);
//}
//break;
//default:
//break;
//}
//}
//while (true);
//class EventCalendar
//{
//    public string? NameEvent { get; set; }
//    public DateOnly Date { get; set; }

//    public override string? ToString()
//    {
//        return NameEvent + " " + Date;
//    }
//}