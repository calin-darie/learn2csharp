using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }

        public virtual void printToScreen()
        {
            Console.Write($"{Name, 13}");
        }

        public MenuItem(string name)
        {
            Name = name;
        }

        public MenuItem() { }

    }
}
