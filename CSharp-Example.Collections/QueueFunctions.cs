namespace CSharp_Example.Collections;

public class QueueFunctions
{
    Queue<string> queue = new Queue<string>();
    PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

    /// <summary>
    /// Adds an object to the end of the queue
    /// </summary>
    public void Enqueue(string input)
    {
        queue.Enqueue(input);
    }

    /// <summary>
    /// Removes and returns the object at the beginning of the queue
    /// </summary>
    public string Dequeue()
    {
        return queue.Dequeue();
    }

    /// <summary>
    /// Returns the object at the beginning of the queue without removing it.
    /// </summary>
    public string Peek()
    {
        return queue.Peek();
    }

    public void Count()
    {
        Console.WriteLine($"Queue count : {queue.Count}");
    }

    public void AddWithSamePriority()
    {
        priorityQueue.Enqueue("1", 1);
        priorityQueue.Enqueue("2", 1);
        priorityQueue.Enqueue("3", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
    }

    public void AddWithDifferentPriority()
    {
        priorityQueue.Enqueue("1", 5);
        priorityQueue.Enqueue("2", 8);
        priorityQueue.Enqueue("3", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
    }
}
