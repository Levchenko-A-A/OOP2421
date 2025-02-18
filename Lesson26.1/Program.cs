using Lesson26._1;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Xml.Serialization;

//Product product1 = new Product()
//{
//    Name = "Хлеб",
//    Category = "Белый",
//    Period = 2,
//    Manufactorer = "Хлебпром",
//    Price = 40
//};
//Product product2 = new Product()
//{
//    Name = "Мясо",
//    Category = "Мясные",
//    Period = 21,
//    Manufactorer = "Ферма",
//    Price = 800
//};
//Product product3 = new Product()
//{
//    Name = "Молоко",
//    Category = "Молочные",
//    Period = 8,
//    Manufactorer = "Молсервис",
//    Price = 40
//};

//List<Product> products = new List<Product>();
//products.Add(product1);
//products.Add(product2);
//products.Add(product3);
//XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
//FileStream stream = new FileStream("products.xml", FileMode.Create);
//xmlSerializer.Serialize(stream, products);
//stream.Close();

//-------------------------------------------------------
//List<Product> products = new List<Product>();
XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
using (FileStream stream = new FileStream("products.xml", FileMode.Open))
{
    List<Product> products = (List<Product>)xmlSerializer.Deserialize(stream)!;
    foreach (Product product in products)
    {
        Console.WriteLine(product);
    }
};