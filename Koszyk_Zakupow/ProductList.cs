using System.Security.Cryptography.X509Certificates;

namespace Koszyk_Zakupow;

class ProductList
{
    public List<Product> products;

    public ProductList()
    {
        products = new List<Product>();
    }

    // Dodawanie produktu do listy
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Wyświetlanie wszystkich produktów
    public void DisplayProducts()
    {
        Console.WriteLine("Lista produktów:");
        foreach (Product product in products)
        {
            Console.WriteLine(product); // Wywoła się ToString() z klasy Product
        }
    }

    // Pobieranie listy produktów (jeśli potrzebne)
    public List<Product> GetProducts()
    {
        return products;
    }
}