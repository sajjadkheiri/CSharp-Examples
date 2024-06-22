
namespace Net_Example.Delegate
{
    public class PersonPrinter
    {
        public void Print(PersonToString personToString, Person person)
        {
            var name = personToString(person);
            Console.WriteLine(name);
        }

        public void PrintFunc(Func<Person, string> personToString, Person person)
        {
            var name = personToString(person);
            Console.WriteLine(name);
        }
    }
}
