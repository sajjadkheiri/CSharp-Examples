using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Inheritance.Interfaces
{
    /// <summary>
    /// Defualt Interface Method
    /// The aim is when you add an interface you are adding a breaking change in inherited class
    /// If you don't want breaking change and add interface, you should have defualt implement
    /// </summary>
    public interface ILogger
    {
        void Log(string message);
        public void Info(string message) => Console.WriteLine(message);
    }

    public class ConsultLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
