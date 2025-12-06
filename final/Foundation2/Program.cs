using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        List<Product> products1 = new List<Product>();
        Product product1_1 = new Product("Jam", "112", 3, 1);
        products1.Add(product1_1);
        Product product1_2 = new Product("Bread", "224", 2, 1);
        products1.Add(product1_2);
        Address address1 = new Address("Boise", "Idaho", "United States", "Potato Dr");
        Customer customer1 = new Customer("Alice", address1);
        Order order1 = new Order(customer1, products1);
        Console.WriteLine($"{order1.ReturnSLabel()}");
        Thread.Sleep(1000);
        Console.WriteLine($"\n{order1.ReturnPLabel()}");
        Thread.Sleep(1000);
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");
        Thread.Sleep(1000);

        List<Product> products2 = new List<Product>();
        Product product2_1 = new Product("Eye of Newt", "003", 10, 3);
        products2.Add(product2_1);
        Product product2_2 = new Product("Spider Leg", "888", 1, 8);
        products2.Add(product2_2);
        Product product2_3 = new Product("Golem Tears", "8953", 30, 1);
        products2.Add(product2_3);
        Address address2 = new Address("Boggy", "The Bog", "Bog Land", "Witch Lane");
        Customer customer2 = new Customer("Witchy", address2);
        Order order2 = new Order(customer2, products2);
        Console.WriteLine($"\n{order2.ReturnSLabel()}");
        Thread.Sleep(1000);
        Console.WriteLine($"\n{order2.ReturnPLabel()}");
        Thread.Sleep(1000);
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
        Thread.Sleep(1000);
    }
}