using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Generics
{
    /// <summary>
    /// Default value in Generics depends on input type  
    /// </summary>
    public class GenericConcate<TInput>
    {
        public string Concate(TInput firstArg, TInput SecondArg)
        {
            return $"First Argument : {firstArg}, Second Argument : {SecondArg}";
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
