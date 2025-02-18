List<Book> list = new List<Book>();
list.Add(new Book(
    1,
    "fs",
    "sfs",
    DateTime.Parse("2024-01-01")
));
Catalog<Book> books = new Catalog<Book>(list);
books.AddBook(new Book(1,
    "fs",
    "sfs",
    DateTime.Parse("2024-01-01")));
foreach (Book i in books.GetBooks())
{
    Console.WriteLine(i.Id + " " + i.Title + " " + i.Author + " " + i.PublicationYear);
}
interface ICatalogItem<T>
{
    T Id { get; }
}
class Book: ICatalogItem<int>
{
    public string? Title { get; set; }
    public string? Author { get; set; } 
    public DateTime? PublicationYear { get; set; }
    public int Id 
    { 
        get;  
    }

    public Book(int id, string? title, string? autor, DateTime? puclicationYear)
    {
        Id = id;
        Title = title;
        Author = autor;
        PublicationYear = puclicationYear;
    }
}
class Catalog<T> where T: ICatalogItem<int>
{
    private List<T>? collection=new();

    public Catalog(List<T>? l)
    {
        collection.AddRange(l!);
    }
    public void AddBook(T book) => collection!.Add(book);
    public List<T> GetBooks() => collection!;
    public T GetConcreteBook(int id) => collection![id];
}