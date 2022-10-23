

public class ShoppingCart 
{
    private List<CartItem> cartItems;

    public ShoppingCart()
    {
        this.cartItems = new List<CartItem>();
    }

    public void Add(CartItem cartItem)
    {
        cartItems.Add (cartItem);
    }
    public void Remove(int cartItemId)
    {
        var cartItem = cartItems.FirstOrDefault(i => i.CartId == cartItemId );

        if (cartItem == null)
        {
            throw new Exception("ilgili id bulunamadı");

        }
        cartItems.Remove(cartItem);
    }
    public List<CartItem> GetList()
    {
        return cartItems;
    }


    public double GetBalance() => cartItems.Sum(i => i.Quantity * i.Product.Price);

    public override string? ToString()
    {
        return $"{GetBalance()} tl";
    }
}