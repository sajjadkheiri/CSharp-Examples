using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Delegate
{
    public delegate string PersonToString(Person person);

    public class DelegateFunctions
    {
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonFullName
    {
        public static string GetPersonalFullName(Person person) => $"{person.FirstName} {person.LastName}";
    }

    public class PersonFullNameReverse
    {
        public static string GetPersonalFullName(Person person) => $"{person.LastName} {person.FirstName}";
    }

    /// <summary>
    /// Func is a delegate that return a value with until 16 input parameter
    /// </summary>
    public class FuncSample
    {
        public static string MyIntToString(int i, int j, int y) => $"{i},{j},{y}";
    }

    /// <summary>
    /// Action is a delegate that is void with until 16 input parameter
    /// </summary>
    public class ActionSample
    {
        public static void MyStringToVoid(string name, string family) => Console.WriteLine($"{name} {family}");
    }
}
