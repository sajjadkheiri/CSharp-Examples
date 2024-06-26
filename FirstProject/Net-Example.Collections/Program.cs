using Net_Example.Collections;

#region Queue

QueueFunctions queue = new QueueFunctions();

queue.Count();

Console.WriteLine("-------------------------------");

queue.Enqueue("1");
queue.Enqueue("2");
queue.Enqueue("3");
queue.Enqueue("4");

queue.Count();

Console.WriteLine("-------------------------------");

Console.WriteLine(queue.Peek());
queue.Count();
Console.WriteLine(queue.Peek());
queue.Count();
Console.WriteLine(queue.Peek());
queue.Count();

Console.WriteLine("-------------------------------");

Console.WriteLine(queue.Dequeue());
queue.Count();
Console.WriteLine(queue.Dequeue());
queue.Count();
Console.WriteLine(queue.Dequeue());
queue.Count();
    
#endregion

#region Priority Queue
    
    queue.AddWithDifferentPriority();

    Console.WriteLine("---------------------------");

    queue.AddWithSamePriority();

#endregion
