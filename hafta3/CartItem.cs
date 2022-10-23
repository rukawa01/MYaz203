
public class CartItem 
{
    
    
    public int CartId { get; set; }
   
    public int Quantity { get; set; }
    public Product Product { get; set; }

    public CartItem(int cartId, int quantity, Product product)
    {
        CartId = cartId;
        Quantity = quantity;
        Product = product;
    }
    

    public override string? ToString()
    {
        return $"{Product.ProductName}\nAdet : {Quantity}\nToplam fiyat: {Quantity * Product.Price} tl\n\n ";
    }
}
