
using OrderManagement.Entities;
using OrderManagement.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date(DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = OrderStatus.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

Order order = new Order(DateTime.Now, status, client);
for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string nameProduct = Console.ReadLine();
    Console.Write("Product price: ");
    double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Product product = new Product(nameProduct, priceProduct);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    OrderItem item = new OrderItem(quantity, priceProduct, product);
    order.AddItem(item);
}

Console.WriteLine(order);
