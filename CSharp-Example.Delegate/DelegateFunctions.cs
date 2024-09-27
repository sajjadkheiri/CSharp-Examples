using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Delegate
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

    public class LambdaDelegate
    {
        public void LambdaFunction()
        {
            Func<string> func1 = () => "Without input parameter";

            Func<int, string> func2 = x => x.ToString();

            Func<int, int, string> func3 = (x, y) => $"{x},{y}";

            Func<int, int, string> func4 = (x, y) =>
            {
                if (x > y)
                {
                    return x.ToString();
                }
                else
                {
                    return y.ToString();
                }
            };

            var result = func1.Invoke();
            Console.WriteLine(result);
        }
    }
}
