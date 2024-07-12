#region SimpleThread

using Net_Example.Thread;

CharPrinter charPrinter = new CharPrinter();

Thread startThread = new Thread(charPrinter.StarPrinter);

startThread.Name = "StartThread";

Console.WriteLine($"{startThread.Name} is alive : {startThread.IsAlive}");
Console.WriteLine($"Thread start");

startThread.Start();

Console.WriteLine($"{startThread.Name} is alive : {startThread.IsAlive}");

charPrinter.DashPrinter();

Console.WriteLine($"{startThread.Name} is alive : {startThread.IsAlive}");
Console.WriteLine($"Thread finish");

Console.ReadKey();

#endregion