using System.Security.Cryptography.X509Certificates;
Warehouse warehouse = new Warehouse();
warehouse.MyEvent += DisplayMessage;
warehouse.AddProduct(new Product() { Name = "Apple", Quantity = 7, DeliveryDate = DateTime.Parse("10.10.2024") });
warehouse.RemoveProduct("Apple", 4);
void DisplayMessage(string message) => Console.WriteLine(message);
class Product
{
    public string? Name { get; set; }
    private int quantity;
    public int Quantity
    {
        get { return quantity; }
        set { if (value > 0) quantity = value; }
    }
    public DateTime DeliveryDate { get; set; }
}
class Warehouse
{
    List<Product>? products;

    public Warehouse()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    { 
        products.Add(product);
    }
    public void RemoveProduct(string productName, int quantity) 
    {
        foreach (Product product in products)
        {
            if (ChekStock(productName) >= quantity)
            {
                product.Quantity -= quantity;
                if (product.Quantity < 10) MyEvent.Invoke($"На складе меньше 10 единиц товара {productName}");
            }
            else
            {
                Console.WriteLine($"На складе не хватает {quantity-product.Quantity} товара {productName}");
            }
        }
    }
    public int ChekStock(string productName)
    {
        foreach (Product product in products)
            if (product.Name == product.Name)
            {
                return product.Quantity;
            }
        return 0;
    }
    public event ProductsChanges MyEvent;
    public delegate void ProductsChanges(string productName);
}
