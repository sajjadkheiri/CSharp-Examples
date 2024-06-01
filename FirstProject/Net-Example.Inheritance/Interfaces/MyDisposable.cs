using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Inheritance.Interfaces
{
    public class MyDisposable : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
