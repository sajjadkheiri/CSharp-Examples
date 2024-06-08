using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Inheritance.Interfaces
{
    /// <summary>
    /// like a sample using interface
    /// </summary>
    /// 
    public interface MyImplicit
    {
        public void Insert();
        public void Update();
    }

    public class MyImplicitImpl : MyImplicit
    {
        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
