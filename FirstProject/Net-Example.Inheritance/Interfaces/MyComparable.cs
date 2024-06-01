using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Inheritance.Interfaces
{
    public class MyComparable : IComparable
    {
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
