namespace Net_Example.Linq;

public class Person
{
    public string FirsName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public static void PrintInformation(List<Person> people)
    {
        foreach (var Person in people)
        {
            Console.WriteLine($"Name : {Person.FirsName} {Person.LastName} | Age : {Person.Age}");
        }
    }
}
