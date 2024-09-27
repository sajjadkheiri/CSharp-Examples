using CSharp_Example.Collections;

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

Console.ReadKey();

#endregion

#region Priority Queue

queue.AddWithDifferentPriority();

Console.WriteLine("---------------------------");

queue.AddWithSamePriority();

Console.ReadKey();

#endregion

#region Stack

StackFunctions stackFunctions = new StackFunctions();

stackFunctions.Push("1");
stackFunctions.Push("2");
stackFunctions.Push("3");

Console.WriteLine(stackFunctions.Pop());
Console.WriteLine(stackFunctions.Pop());
Console.WriteLine(stackFunctions.Pop());

Console.ReadKey();

#endregion