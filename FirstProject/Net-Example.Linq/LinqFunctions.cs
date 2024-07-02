namespace Net_Example.Linq;

public class LinqFunctions
{
    public void PrintWithoutLinq(List<string> names)
    {
        List<string> result = new List<string>();

        foreach (string name in names)
        {
            if (name.StartsWith("A"))
                result.Add(name);
        }

        result.Sort();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintWithLinqQuery(List<string> names)
    {
        var result = from name in names
                     where name.StartsWith("A")
                     orderby name ascending
                     select name;

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    public void PrintWithLinqMethod(List<string> names)
    {
        var result = names.Where(name => name.StartsWith("A"))
                          .OrderBy(name => name)
                          .Select(name => name);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// Deferred Execution : When your linq query is written doenn't execute untile you want to use from that data
    /// </summary>
    public void PrintWithDiferred()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 7, 12, 15 };

        var lessThan10 = from num in numbers where num <= 10 select num;

        foreach (var item in lessThan10)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("******************************");

        numbers.Add(2);
        numbers.Add(4);

        foreach (var item in lessThan10)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// Immediate Execution : Those methods like Tolist() or .... that need to your data to continue prosedure execute realtime
    /// </summary>
    public void PrintWithImmediate()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 7, 12, 15 };

        var lessThan10 = (from num in numbers where num <= 10 select num).ToList();

        foreach (var item in lessThan10)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("******************************");

        numbers.Add(2);
        numbers.Add(4);

        foreach (var item in lessThan10)
        {
            Console.WriteLine(item);
        }
    }

    public void FilterPeople(List<Person> people)
    {
        var result = people.Where(x => x.Age > 18).ToList();

        Person.PrintInformation(result);
    }

    public void FilterByType(List<object> obj)
    {
        var numbers = obj.OfType<int>().ToList();

        foreach (var number in numbers)
        {
            Console.WriteLine($"The number is {number}");
        }
    }

    /// <summary>
    /// OrderBy & OrderByDescending
    /// </summary>
    public void SortByFirstName(List<Person> people)
    {
        var result = people.OrderBy(x => x.FirstName).ToList();

        Person.PrintInformation(result);
    }

    /// <summary>
    /// ThenBy & ThenByDescending : When you want to sort the list after the list was sorted
    /// Two times sorting
    /// </summary>
    public void SortByTwoOptions(List<Person> people)
    {
        var result = people.OrderBy(x => x.FirstName).ThenBy(y => y.Age).ToList();

        Person.PrintInformation(result);
    }

    public void GroupByPeople(List<Person> people)
    {
        var result = people.GroupBy(x => x.Age);

        foreach (var Person in result)
        {
            Console.WriteLine($"Group : {Person.Key}");

            foreach (var item in Person)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} : {item.Age}");
            }

            Console.WriteLine("*******************************************");
        }
    }

    public void InnerJoinPersonInfo(List<Person> people, List<PersonInformation> information)
    {
        var result = people.Join(information, per => per.Id, info => info.PersonId, (per, info) => new
        {
            PersonId = per.Id,
            PersonInfoId = info.Id,
            per.FirstName,
            per.LastName,
            info.NationalCode
        });

        foreach (var item in result)
        {
            Console.WriteLine($"Person Id : {item.PersonId} | InfoId : {item.PersonInfoId} | FirstName : {item.FirstName} | LastName : {item.LastName} | NationalCode : {item.NationalCode}");
        }
    }
}
