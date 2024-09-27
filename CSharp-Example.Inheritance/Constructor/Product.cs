using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Inheritance.Constructor
{
    public class Product
    {
        public Product()
        {
            Console.WriteLine("This is a Product class constructor");
        }

        public Product(string input)
        {
            Console.WriteLine($"This is a Product class constructor with {input}");
        }
    }

    public class Mobile : Product
    {
        public Mobile()
        {
            Console.WriteLine("This is a Mobile class constructor");
        }

        public Mobile(string input) : base(input)
        {
            Console.WriteLine($"This is a Mobile class constructor with {input}");
        }
    }
}
