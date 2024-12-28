using System;
using System.Collections.Generic;
using Koszyk_Zakupow;

class Program
{
    static void Main(string[] args)
    {

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


        Cart cart = new Cart();
        Console.WriteLine("Wpisz kod, żeby dodać do koszyka. Wciśnij ESC żeby wyjść.");
      
        while (true)
        {
            Console.WriteLine("Kod:");
            string userInput = Console.ReadLine();

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
            // Wyświetlanie zawartości koszyka
            Console.WriteLine("\nPodsumowanie:");
            cart.DisplayCart();

            // Obliczanie i wyświetlanie całkowitej wartości
            decimal total = cart.TotalPrice();
            Console.WriteLine($"Łączna wartość koszyka: {total} zł");
        }

    }

};

