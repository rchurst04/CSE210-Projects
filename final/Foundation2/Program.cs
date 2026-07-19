class Program
{
    static void Main(string[] args)
    {
        // Order 1 - US customer
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-001", 29.99, 2));
        order1.AddProduct(new Product("USB-C Hub", "UC-047", 49.99, 1));
        order1.AddProduct(new Product("Keyboard Cover", "KC-112", 12.99, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        // Order 2 - International customer
        Address address2 = new Address("10 Downing Street", "London", "England", "UK");
        Customer customer2 = new Customer("James Bennett", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "LS-203", 39.99, 1));
        order2.AddProduct(new Product("Webcam HD", "WC-558", 79.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}
