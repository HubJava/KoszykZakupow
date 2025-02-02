using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Mime;
using Koszyk_Zakupow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("KASA SKLEPOWA");
        Console.WriteLine();
        Console.WriteLine("Autorzy: Hubert Hirt (122711), Szymon Albrycht (122692),Karol Urbańczyk (123764), Społeczna Akademia Nauk, Łodź");
        Console.WriteLine();
        Console.WriteLine("Witaj w kasie sklepowej, poniżej lista produktów którą możesz kupić");



        Console.WriteLine();



        // Tworzenie listy produktów
        ProductList productList = new ProductList();

        // Dodawanie produktów do listy
        productList.AddProduct(new Product("Masło", 9.80m, 123));
        productList.AddProduct(new Product("Chleb", 3.40m, 124));
        productList.AddProduct(new Product("Ser", 5.40m, 125));
        productList.AddProduct(new Product("Mleko", 3.80m, 126));
        productList.AddProduct(new Product("Pomidor", 2.00m, 127));
        productList.AddProduct(new Product("Szynka", 2.83m, 128));
        productList.AddProduct(new Product("Woda", 1.40m, 129));
        productList.AddProduct(new Product("Papier toaletowy", 10.70m, 130));
        productList.AddProduct(new Product("Szpinak", 4.40m, 131));

        // Wyświetlanie produktów
        productList.DisplayProducts();
        Console.WriteLine();

        Cart cart = new Cart();
        Console.WriteLine("Wpisz kod, żeby dodać do koszyka. Wciśnij Z żeby wyjść.  Wciśnij P, aby zobaczyć paragon.");
      
        while (true)
{
    Console.WriteLine();
    Console.WriteLine("Kod:");
    var keyInfo = Console.ReadKey(intercept: false);

    //Wyjście z programu po wciśnięciu klawisza ESC
    if (keyInfo.Key == ConsoleKey.Z)
    {
        Console.WriteLine();
        Console.WriteLine("Dziekujemy za skorzystanie z kasy");
       //`Environment.Exit(0);
      break;
    }

    // Wyświetlanie łącznej wartości koszyka po wciśnięciu klawisza P
    if (keyInfo.Key == ConsoleKey.P)
    {
        Console.WriteLine("\nPodsumowanie koszyka:");
        cart.DisplayCart();
        decimal currentTotal = cart.TotalPrice();
        Console.WriteLine($"\nŁączna wartość koszyka: {currentTotal} zł");
        break;
    }
    // dodawanie produktu do listy jesli sie zgadza podany kod
    string userInput = keyInfo.KeyChar + Console.ReadLine();

            if (int.TryParse(userInput, out int code)) 
          
            {
                Product selectedProduct = productList.GetProducts().Find(p => p.Code == code);
                if (selectedProduct != null)
                {
                    cart.AddToCart(selectedProduct);
                }
                else
                {
                    Console.WriteLine("Nie znaleziono produktu.");
                }
            }
            
            // Obliczanie i wyświetlanie całkowitej wartości
            decimal total = cart.TotalPrice();
            Console.WriteLine($"Łączna wartość koszyka: {total} zł");

           
        }

    }

};

