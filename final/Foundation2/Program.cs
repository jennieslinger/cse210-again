using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple Street", "Corona", "CA", "USA");
        Address address2 = new Address("397 Elm Circle", "Vancouver", "ON", "Canada");

        Customer customer1 = new Customer("Sarah Johnson", address1);
        Customer customer2 = new Customer("James Wong", address2);

        Product product1 = new Product("Smart Home Security Camera", "SC-2003", 89.99, 2); //customer1
        Product product2 = new Product("Wireless Bluetooth Earbuds", "EB-4586", 49.95, 1);//customer1 & customer2
        Product product3 = new Product("Protable Power Bank (10000mAh)", "PB-0784", 29.98, 3);//customer1
        Product product4 = new Product("Robot Vacuum CLeaner", "VC-5429", 199.49, 1);//customer 2
        Product product5 = new Product("Wireless Charging Pad", "WP-9520", 24.98, 4);//customer 2

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("ORDER 1 DETAILS:  ");
        Console.WriteLine("");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Order Price: ${order1.CalculateTotal()}");
        Console.WriteLine("");

        Console.WriteLine("ORDER 2 DETAILS: ");
        Console.WriteLine("");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Order Price: ${order2.CalculateTotal()}");
        Console.WriteLine("");
    }
}