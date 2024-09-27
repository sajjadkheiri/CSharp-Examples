namespace Net_Example.Tasks;

public class TaskFunctions
{
    /// <summary>
    /// This is a background Thread that works with Thread Pool
    /// </summary>
    public void SimpleTask()
    {
        Task result = Task.Run(() => PrintName());

        Console.WriteLine("------- Finish -------");
        Console.WriteLine($"Task status : {result.Status}");

        result.Wait();

        Console.WriteLine($"Task status : {result.Status}");
    }

    /// <summary>
    /// This is a backgroung Thread that doesn't work with Thread pool.In addition, you can set as a LongRunning task
    /// </summary>
    public void TaskFactory()
    {
        Task result = Task.Factory.StartNew(() => PrintName(), TaskCreationOptions.LongRunning);

        Console.WriteLine("------- Finish -------");
        Console.WriteLine($"Task status : {result.Status}");

        result.Wait();

        Console.WriteLine($"Task status : {result.Status}");
    }

    public void ColdTask()
    {
        Task result = new Task(PrintName);

        Console.WriteLine($"Task status : {result.Status}");

        result.Start();

        Console.WriteLine("------- Finish -------");
        Console.WriteLine($"Task status : {result.Status}");

        result.Wait();

        Console.WriteLine($"Task status : {result.Status}");
    }

    public void ReturnValue()
    {
        Task<int> result = Task.Run(() => Sum(100, 200));

        Console.WriteLine($"Status : {result.Status}");
        Console.WriteLine($"Result : {result.Result}");
        Console.WriteLine($"Status : {result.Status}");
        Console.WriteLine("Finish");
    }

    /// <summary>
    /// IsFaulted : There is an issue or exception when the task has run 
    /// </summary>
    public void ExceptionHandling()
    {
        Task<int> result = Task.Run(() => Sum(null, 100));

        try
        {
            result.Wait();
            Console.WriteLine("Finish");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Is canceld : {result.IsCanceled}");
            Console.WriteLine($"Is Faulted : {result.IsFaulted}");
            Console.WriteLine($"Exception : {ex.InnerException?.Message}");
        }
    }

    public void Delay()
    {
        Task.Delay(2000).ContinueWith(task => Console.WriteLine("Continue after 2 seconds"));
        Console.ReadKey();
    }

    private void PrintName()
    {
        Console.WriteLine($"Thread pool : {Thread.CurrentThread.IsThreadPoolThread}");
        Console.WriteLine($"Background : {Thread.CurrentThread.IsBackground}");

        Thread.Sleep(3000);

        Console.WriteLine("Sajjad Kheiri");
    }

    private int Sum(int? a, int? b)
    {
        if (a is null)
        {
            throw new ArgumentNullException(nameof(a));
        }

        if (b is null)
        {
            throw new ArgumentNullException(nameof(b));
        }

        return a.Value + b.Value;
    }
}
