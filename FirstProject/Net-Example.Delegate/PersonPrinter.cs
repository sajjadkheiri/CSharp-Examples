using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Delegate
{
    public class PersonPrinter
    {
        public void Print(PersonToString personToString, Person person)
        {
            var name = personToString(person);
            Console.WriteLine(name);
        }
    }
}
