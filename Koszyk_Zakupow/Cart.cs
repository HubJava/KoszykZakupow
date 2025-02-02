using System.Threading.Channels;

namespace Koszyk_Zakupow;

public class Cart
{
    private List<Product> cartItems;
    //tworzenie listy
    public Cart()
    {
        
        cartItems = new List<Product>();
        
    }
    
    //Dodawanie produktów do koszyka

    public void AddToCart (Product product)
    {
        cartItems.Add(product);
        Console.WriteLine($"Dodano do koszyka: {product.Name} ");

    }
    //Pokazanie zawartosci koszyka
    public void DisplayCart()
    {

        if (cartItems.Count == 0)
        {
            Console.WriteLine("Brak artykułow w koszyku.");
            return;
        }

        Console.WriteLine("Twoje produkty:");
        foreach (Product product in cartItems)
        {
            Console.WriteLine(product.Name);
        }
        
        
    }
    //Liczenie ceny paragonu
    public decimal TotalPrice()
    {
        decimal totalPrice = 0;
        foreach (Product product in cartItems)
        {
            totalPrice += product.Price;
        }
        return totalPrice;
    }
}