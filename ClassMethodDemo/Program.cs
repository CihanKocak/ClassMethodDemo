using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Cihan";
            customer1.LastName = "Koçak";
            customer1.City = "Antalya";
            customer1.Age = 35;
            customer1.AccountBalance = 1000000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Özde";
            customer2.LastName = "Koçak";
            customer2.City = "Antalya";
            customer2.Age = 35;
            customer2.AccountBalance = 2000000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ada";
            customer3.LastName = "Koçak";
            customer3.City = "Antalya";
            customer3.Age = 4;
            customer3.AccountBalance = 3000000;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Can";
            customer4.LastName = "Koçak";
            customer4.City = "Antalya";
            customer4.Age = 2;
            customer4.AccountBalance = 4000000;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Get(customer1);
            Console.WriteLine("----------------------------");
            customerManager.Add(customer2);
            Console.WriteLine("----------------------------");
            customerManager.Update(customer3);
            Console.WriteLine("----------------------------");
            customerManager.Delete(customer4);
            Console.WriteLine("----------------------------");

            Console.ReadLine();
        }
    }
}
