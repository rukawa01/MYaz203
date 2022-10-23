
Product productTuvalet = new Product(100, "Tuvalet kağıdı", 1);
Product productCellPhone = new Product(2000, "Iphone 11", 2);
Product productKeyboard = new Product(120, "Led Keyboard", 3);
Product productChair = new Product(250, "Mini Chair", 4);




// ömerin alışverisi sepetinin içindekiler
CartItem omerTuvaletKagitlari = new CartItem(1, 2, productTuvalet);
CartItem omerChairs = new CartItem(2, 1, productChair);

ShoppingCart omerShoppingCart = new ShoppingCart();

omerShoppingCart.Add(omerTuvaletKagitlari);
omerShoppingCart.Add(omerChairs);


// ibonun alışverişi
CartItem iboKeyboards = new CartItem(3, 1, productKeyboard);
CartItem iboIphones = new CartItem(4, 1, productCellPhone);

ShoppingCart iboShoppingCart = new ShoppingCart();

iboShoppingCart.Add(iboKeyboards);
iboShoppingCart.Add(iboIphones);

foreach (var i in omerShoppingCart.GetList())
{
    Console.WriteLine(i);
}

Console.WriteLine(omerShoppingCart);