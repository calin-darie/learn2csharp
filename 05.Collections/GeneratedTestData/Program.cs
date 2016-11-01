using System;

namespace GeneratedTestData
{
    class Program
    {
        static void Main(string[] args)
        {
            /*todo:
             * find the "Package Manager Console" window
             * in there, enter:
             * install-package genfu
             * read the readMe on github
             * https://github.com/MisterJames/GenFu#readme
             * 
             * generate a list of 25 Customers 
             * print the customer data to the console
             * 
             * Joe 
             * Smith
             * 20/10/1978
             * fsdjkl@yahoo.com
             * 19 Goldman ave.
             * ===================
             * Jane
             * Doe
             * ...
             */


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
