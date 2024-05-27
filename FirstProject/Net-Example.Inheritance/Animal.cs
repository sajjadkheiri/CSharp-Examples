using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Inheritance
{
    public class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("My animal voice");
        }
    }

    public class Cat : Animal
    {
        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Mio");
        }
    }

    public class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Woof");
            base.Voice();
        }
    }

    public class Caw : Animal
    { 
    }
}
