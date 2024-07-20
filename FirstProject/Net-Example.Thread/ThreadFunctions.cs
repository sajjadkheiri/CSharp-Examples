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

    /// <summary>
    /// The join method which allows one thread to wait until another thread completes its execution
    /// </summary>
    public void JoinThread()
    {
        CharPrinter charPrinter = new CharPrinter();
        System.Threading.Thread thread = new(charPrinter.DashPrinter);

        thread.Start();
        var isFinished = thread.Join(30);

        Console.WriteLine(isFinished);

        charPrinter.StarPrinter();

        Console.ReadLine();
    }

    public void SleepThread()
    {
        CharPrinter charPrinter = new CharPrinter();
        System.Threading.Thread thread = new(charPrinter.DashPrinter);

        thread.Start();

        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));

        charPrinter.StarPrinter();

        Console.ReadLine();

    }

    /// <summary>
    /// 
    /// </summary>
    public void YieldThread()
    {
        CharPrinter charPrinter = new CharPrinter();
        System.Threading.Thread thread = new(charPrinter.DashPrinter);

        thread.Start();

        System.Threading.Thread.Yield();
        System.Threading.Thread.Sleep(0);

        charPrinter.StarPrinter();

        Console.ReadLine();
    }
}
