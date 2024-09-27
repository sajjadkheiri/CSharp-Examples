using System.Threading;

namespace Net_Example.Thread;

public class ThreadFunctions
{
    bool allowWrite = true;
    private readonly static object _locker = new object();

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

    public void ThreadStateCheck()
    {
        CharPrinter charPrinter = new CharPrinter();
        System.Threading.Thread thread = new(charPrinter.DashPrinter);

        thread.Start();

        Console.WriteLine(thread.ThreadState);

        var isBlock = (thread.ThreadState & ThreadState.WaitSleepJoin) != 0;

        Console.WriteLine($"Thread is block ? {isBlock}");
    }

    public void SharedState()
    {
        System.Threading.Thread first = new System.Threading.Thread(CheckSharedState);
        System.Threading.Thread second = new System.Threading.Thread(CheckSharedState);

        first.Start();
        second.Start();

        Console.ReadKey();
    }

    public void CheckSharedState()
    {
        if (allowWrite)
        {
            Console.WriteLine("This is my message");
            allowWrite = false;
        }
    }

    /// <summary>
    /// The lock is used to get a lock for a single thread. A lock prevents several threads from accessing a resource simultaneously
    /// </summary>
    public void SafeCheckSharedState()
    {
        lock (_locker)
        {
            if (allowWrite)
            {
                Console.WriteLine($"Locker thread name is {System.Threading.Thread.CurrentThread.Name}");
                Console.WriteLine("This is my message");
                allowWrite = false;
            }
        }

        Console.WriteLine(System.Threading.Thread.CurrentThread.Name);
    }

    public void OneInputParam(object firstName)
    {
        CharPrinter charPrinter = new CharPrinter();
        System.Threading.Thread thread = new(charPrinter.FirstNamePrinter);

        thread.Start(firstName);

        Console.ReadKey();
    }

    public void InputParams(string firstName, string lastName)
    {
        CharPrinter charPrinter = new CharPrinter();
        System.Threading.Thread thread = new(() => charPrinter.FullNamePrinter(firstName, lastName));

        thread.Start();

        Console.ReadKey();
    }

    /// <summary>
    /// Tip : In this case, you expect to print both names at 2 thread. However, like Linq syntax when
    /// the intialization doesn't run until the thread will be run and the last value(name) will be printed.
    /// </summary>
    public void CaptureVariableIssue()
    {
        string name = "Sajjad";

        System.Threading.Thread thread_1 = new(() => Console.WriteLine(name));

        name = "Steve";

        System.Threading.Thread thread_2 = new(() => Console.WriteLine(name));

        thread_1.Start();
        thread_2.Start();

        Console.ReadKey();
    }

    /// <summary>
    /// Tip : When you initial thread into the TryCatch, your code has issue because TryCatch won't detect
    /// your exception. Your exception handling must be into the main method where the thread wants start.
    /// </summary>
    public void ExceptionHandling()
    {
        System.Threading.Thread thread = new(ThreadStartPoint);

        thread.Start();

        Console.ReadKey();
    }

    private void ThreadStartPoint()
    {
        try
        {
            Exception();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void Exception()
    {
        throw new Exception("Exception !!!!!!!!");
    }

    /// <summary>
    /// Foreground thread : Foreground is the default form of thread. It will remain active until all the Foreground threads have finished.
    /// Background thread : They do not prevent the application from terminating (IsBackground property)
    /// Join : It tries to wait before starting another thraed. 
    /// </summary>
    public void BackgroundThread()
    {
        CharPrinter charPrinter = new();
        System.Threading.Thread thread = new(charPrinter.DashPrinter);

        thread.IsBackground = true;

        thread.Start();

        thread.Join(TimeSpan.FromSeconds(10));
    }

    public void WithoutThreadPool()
    {
        CharPrinter charPrinter = new();
        System.Threading.Thread thread = new(charPrinter.ThreadTypePrinter);

        thread.Start();

        Console.ReadKey();
    }

    /// <summary>
    /// TODO : Read more about it
    /// </summary>
    public void WithThreadPool()
    {
        CharPrinter charPrinter = new();

        Task.Run(() => charPrinter.ThreadTypePrinter());

        Console.ReadKey();
    }

}
