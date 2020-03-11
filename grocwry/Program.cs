using System;

namespace grocwry
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier c1 = new Cashier();
            Order o1 = new Order();
            Order o2 = new Order();
            Order o3 = new Order();

            Console.Write("Enter the cashier: ");
            c1.SetName(Console.ReadLine());
            Console.Write("Enter counter number: ");
            c1.SetCounterNumber(int.Parse(Console.ReadLine()));

            Console.Write("\nEnter Item 1 name: ");
            o1.SetItemName(Console.ReadLine());
            Console.Write("Enter price: ");
            o1.SetPrice(double.Parse(Console.ReadLine()));
            Console.Write("Enter quantity: ");
            o1.SetQuantity(int.Parse(Console.ReadLine()));

            Console.Write("\nEnter Item 2 name: ");
            o2.SetItemName(Console.ReadLine());
            Console.Write("Enter price: ");
            o2.SetPrice(double.Parse(Console.ReadLine()));
            Console.Write("Enter quantity: ");
            o2.SetQuantity(int.Parse(Console.ReadLine()));

            Console.Write("\nEnter Item 3 name: ");
            o3.SetItemName(Console.ReadLine());
            Console.Write("Enter price: ");
            o3.SetPrice(double.Parse(Console.ReadLine()));
            Console.Write("Enter quantity: ");
            o3.SetQuantity(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            c1.ToString(o1, o2, o3);
        }
    }
}
