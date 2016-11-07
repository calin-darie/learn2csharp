using GenFu;
using System;

namespace GeneratedTestData
{
    class Program
    {
        static void Main(string[] args)
        {
            int noCustomers = 25;
            var customers = A.ListOf<Customer>(noCustomers);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.BirthDate.ToShortDateString());
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Address);
                Console.WriteLine("===================");
            }

            Console.ReadKey();
        }

        public class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
        }
    }
}
