var age = 27;

int ? n = null;

n = 10;

Console.WriteLine(n ?? 0);
Console.WriteLine(( n.HasValue ? n.Value : 0 ));

//Anonymous Type/Class
var purchase = new { item = "Toothpaste", price = 50.5, quantity = 2 };
Console.WriteLine($"Todays purchase: {purchase.item}, Total Bill: {purchase.price} * {purchase.quantity} = {purchase.price * purchase.quantity}");

Console.WriteLine(purchase.GetType());

//Arrays
var purchases = new[]
{
    new { item = "Toothpaste", price = 30, quantity = 3 },
    new { item = "Soap", price = 100, quantity = 4 },
    new { item = "Wallet", price = 1000, quantity = 2 },
    new { item = "Belt", price =1500, quantity = 1 }
};

foreach (var x in purchases)
{
    Console.WriteLine($"{x.item}, {x.price} x {x.quantity} = {x.price * x.quantity}");
}

Console.WriteLine();

var q1 = from x in purchases where x.price > 500 orderby x.price select x;

foreach (var x in q1)
{
    Console.WriteLine($"{x.item}, {x.price} x {x.quantity} = {x.price * x.quantity}");
}

Console.WriteLine();

var q2 = purchases.OrderByDescending(x => x.price).Where(x => x.price > 500).ToList();

foreach (var x in q2)
{
    Console.WriteLine($"{x.item}, {x.price} x {x.quantity} = {x.price * x.quantity}");
}

Console.ReadLine();