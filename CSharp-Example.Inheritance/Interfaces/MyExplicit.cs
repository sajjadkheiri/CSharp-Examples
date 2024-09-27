using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Inheritance.Interfaces
{
    public interface MyExplicit
    {
        public void Insert();
        public void Update();
    }

    public class MyExplicitImpl : MyExplicit
    {
        void MyExplicit.Insert()
        {
            throw new NotImplementedException();
        }

        void MyExplicit.Update()
        {
            throw new NotImplementedException();
        }
    }
}
