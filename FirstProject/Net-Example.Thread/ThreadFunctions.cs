using System.Threading;

namespace Net_Example.Thread;

public class ThreadFunctions
{
    public void SimpleThread()
    {
        CharPrinter charPrinter = new CharPrinter();

        System.Threading.Thread startThread = new(charPrinter.StarPrinter);

        startThread.Name = "StartThread";

        Console.WriteLine($"{startThread.Name} is alive : {startThread.IsAlive}");
        Console.WriteLine($"Thread start");

        startThread.Start();

        Console.WriteLine($"{startThread.Name} is alive : {startThread.IsAlive}");

        charPrinter.DashPrinter();

        Console.WriteLine($"{startThread.Name} is alive : {startThread.IsAlive}");
        Console.WriteLine($"Thread finish");

        Console.ReadKey();
    }
}
