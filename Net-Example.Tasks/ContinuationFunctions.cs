namespace Net_Example.Tasks;

public class ContinuationFunctions
{
    /// <summary>
    /// If the task has hesitation, the procedure will continue and execute next method
    /// When the task have exceptions,if you just use GetAwaiter(), it returns ArgumentException =>
    /// otherwise, if you call GetResult(), it just returns Exception.
    /// </summary>
    public void TaskAwaiter()
    {
        Task<int> taskResult = Task.Run(() => Sum(100, 200));

        var awaiter = taskResult.GetAwaiter();

        awaiter.OnCompleted(async () =>
        {
            var result = awaiter.GetResult();
            Console.WriteLine($"the result is {result}");
        });

        Console.WriteLine("---------- Finish ----------");
        Console.ReadKey();
    }

    public void ContinueWith()
    {
        Task<int> taskResult = Task.Run(() => Sum(100, 200));

        taskResult.ContinueWith(task => Console.WriteLine($"the result is {taskResult.Result}"));

        Console.WriteLine("---------- Finish ----------");
        Console.ReadKey();
    }

    private int Sum(int a, int b)
    {
        Task.Delay(3000);
        return a + b;
    }
}
