
namespace Net_Example.Delegate
{
    /// <summary>
    /// Multicast delegate should be void because if it has value, you can just get last value.
    /// Exception in multicast delegate is vital because if in the middle of program has an excpetion
    /// your delegate will be incomplete
    /// </summary>
    public delegate void MethodNamePrinter();

    public class MulticastDelegateFunctions
    {
        public void Method1()
        {
            Console.WriteLine(nameof(Method1));
        }

        public void Method2()
        {
            Console.WriteLine(nameof(Method1));
        }

        public void Method3()
        {
            Console.WriteLine(nameof(Method1));
        }

        public void Method4()
        {
            Console.WriteLine(nameof(Method1));
        }
    }
}