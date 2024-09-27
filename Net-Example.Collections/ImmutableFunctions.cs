using System.Collections.Immutable;

namespace Net_Example.Collections;

public class ImmutableFunctions
{
    /// <summary>
    /// An immutable object is an object that we can’t change after we instantiate it
    /// </summary>
    public void CreateImmutableList()
    {
        ImmutableList<string> immutableList = ImmutableList.Create<string>();

        Console.WriteLine($"Count : {immutableList.Count}");

        immutableList.Add("Hello");

        Console.WriteLine($"Count : {immutableList.Count}");

        var result = immutableList.Add("Hello");

        Console.WriteLine($"Count : {result}");
        Console.ReadKey();
    }
}
