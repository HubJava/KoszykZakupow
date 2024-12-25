using System;
using System.Collections.Generic;
using Koszyk_Zakupow;

// List<Product> listProduct = new List<Product>
// {
//     new Product("Masło", 9.80m, 123),
//     new Product("Chleb", 3.40m, 124),
//     new Product("Ser", 5.40m, 125),
//     new Product("Mleko", 3.80m, 126),
//     new Product("Pomidor", 2.00m, 127),
//     new Product("Szynka", 2.83m, 128),
//     new Product("Woda", 1.40m, 129),
//     new Product("Papier toaletowy", 10.70m, 130),
//     new Product("Szpinak", 4.40m, 131),
//         
// };

Console.WriteLine("Skanuj kod, żeby dodać do koszyka.");
 
Console.WriteLine();
 
Console.WriteLine("Lista produktów:");
foreach (Product product in listProduct)
{
    Console.WriteLine(product);
}