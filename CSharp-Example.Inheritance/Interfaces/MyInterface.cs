using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Inheritance.Interfaces
{
    /// <summary>
    /// All methods in Interface class are public even your methods don't have Access Modifire
    /// </summary>
    public interface MyInterface
    {
        public void GetData();
        void Create();
    }

    public class InterfaceImpl : MyInterface
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void GetData()
        {
            throw new NotImplementedException();
        }
    }
}
