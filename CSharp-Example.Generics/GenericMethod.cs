using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Generics
{
    public class GenericMethod
    {
        public void Print<TInput>(TInput input)
        {
            Console.WriteLine(input);
        }

        public string ReturnData<TInput>(TInput input) => input.ToString();
    }
}
