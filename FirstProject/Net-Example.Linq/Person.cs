namespace Net_Example.Linq;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public static void PrintInformation(List<Person> people)
    {
        foreach (var Person in people)
        {
            Console.WriteLine($"Name : {Person.FirstName} {Person.LastName} | Age : {Person.Age}");
        }
    }
}
