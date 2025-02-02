
using System.Diagnostics;
using System.Security.Cryptography;

namespace Koszyk_Zakupow;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Code { get; set; }


    // stworzenie obiektu produktu i nadanie atrybutów
    public Product(string name, decimal price, int code)
    {
        Name = name;
        Price = price;
        Code = code;
    }
    public override string ToString()
    {
        return $"Nazwa: {Name}, Cena: {Price} zł, Kod: {Code}";
    }
}