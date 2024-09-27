using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Operations;

public class OperationManager
{
    /// <summary>
    /// If a parameter has value print it ,otherwise print 0
    /// </summary>
    /// <param name="input"></param>
    public void NullChecking(int? input)
    {
        var a = input ?? 0;

        Console.WriteLine();
    }

    /// <summary>
    /// If a property of person is null, It can help you to continue without exception
    /// </summary>
    /// <param name="person"></param>
    public void NullChecking(Person person)
    {
        Console.WriteLine(person?.FirstName);
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

