using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Inheritance.Constructor
{
    /// <summary>
    /// If parent class don't have defualt constructor and there is a defauld constructor in your child class,
    /// you have to use constructor with parameter in your child class
    /// </summary>
    /// 

    public class Camera
    {
        public Camera(string input)
        {
            Console.WriteLine($"This is a Camera class constructor with {input}");
        }
    }

    public class Lens : Camera
    {
        public Lens() : base("Defualt input")
        {
            Console.WriteLine("This is a Lens class constructor");
        }

        public Lens(string input) : base(input)
        {
            Console.WriteLine($"This is a Camera class constructor with {input}");
        }
    }
}
