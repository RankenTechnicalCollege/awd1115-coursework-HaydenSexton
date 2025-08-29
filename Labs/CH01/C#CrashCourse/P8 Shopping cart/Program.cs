using P8_Shopping_cart;

Cart cart1 = new Cart("1234");
cart1.AddItem("Lollypop", 2.5);
cart1.AddItem("Jolly Rancher", 0.50);
cart1.AddItem("Gum Pack", 5.0);
Console.WriteLine(cart1);

cart1.RemoveItem("Jolly Rancher");
Console.WriteLine(cart1);