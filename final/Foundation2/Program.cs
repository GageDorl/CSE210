using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = [];
        Order order1 = new([new("Bike", "1", 120, 1), new("Helmet", "2", 35, 1)], new("George Johnson", new("123 Street St", "Place", "VA", "USA")));
        Order order2 = new([new("Chapstick", "3", 5, 3), new("Lotion", "4", 10, 1)], new("Jimmy Page", new("672 Park Ave", "Somewhere", "Province", "Mexico")));
        orders.Add(order1);
        orders.Add(order2);
        foreach(Order order in orders)
        {
            Console.WriteLine($"{order.GetPackingLabel()}\n{order.GetShippingLabel()}\nTotal: ${order.GetTotal()}\n");
        }
    }
}