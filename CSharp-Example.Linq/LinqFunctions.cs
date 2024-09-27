namespace CSharp_Example.Linq;

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

    /// <summary>
    /// Group join consist of both sides of join
    /// </summary>
    public void GroupJoinPersonInfo(List<Person> people, List<PersonInformation> information)
    {
        var result = people.GroupJoin(information, p => p.Id, i => i.PersonId, (per, info) => new
        {
            PersonId = per.Id,
            per.FirstName,
            per.LastName,
            Information = info
        });

        foreach (var pers in result)
        {
            foreach (var info in pers.Information)
            {
                Console.WriteLine($"Person Id : {pers.PersonId} | InfoId : {info.Id} | FirstName : {pers.FirstName} | LastName : {pers.LastName} | NationalCode : {info.NationalCode}");
            }
        }
    }

    public void Distinct()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 1, 6, 3, 5, 4, 9, 5 };

        var result = numbers.Distinct();

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    /// <summary>
    /// DistinctBy works with a keySelector that you can distinct according to that
    /// </summary>
    public void DistinctBy(List<Person> people)
    {
        var result = people.DistinctBy(p => p.Age);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    public void Union()
    {
        List<int> firstList = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> secondList = new List<int> { 4, 5, 6, 7, 8, 9 };

        var result = firstList.Union(secondList);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    public void UnionBy(List<Person> people1, List<Person> people2)
    {
        var result = people1.UnionBy(people2, p => p.Age);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    public void Except()
    {
        List<int> firstList = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> secondList = new List<int> { 4, 5, 6, 7, 8, 9 };

        var result = firstList.Except(secondList);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    /// <summary>
    /// Produces the set difference of two sequences according to a specified key selector
    /// </summary>
    public void ExceptBy(List<Person> people, List<int> exceptionAge)
    {
        var result = people.ExceptBy(exceptionAge, p => p.Age);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    public void Intersect()
    {
        List<int> firstList = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> secondList = new List<int> { 4, 5, 6, 7, 8, 9 };

        var result = firstList.Intersect(secondList);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    public void IntersectBy(List<Person> people, List<int> intersectioAge)
    {
        var result = people.IntersectBy(intersectioAge, p => p.Age);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }

    /// <summary>
    /// Zip can mix 2 or 3 list of items
    /// Tip : the shortest list is the base of mix
    /// </summary>
    public void Zip(bool twoItems)
    {
        List<int> number1 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> number2 = new List<int>() { 6, 7, 8, 9, 10 };
        List<int> number3 = new List<int>() { 11, 12, 13 };

        if (twoItems)
        {
            var twoItemsResult = number1.Zip(number2);

            foreach (var item in twoItemsResult)
            {
                Console.WriteLine($"First Item : {item.First} | Second Item : {item.Second}");
            }
        }
        else
        {
            var threeItemsResult = number1.Zip(number2, number3);

            foreach (var item in threeItemsResult)
            {
                Console.WriteLine($"First Item : {item.First} | Second Item : {item.Second} | Third Item : {item.Third}");
            }
        }

    }

    /// <summary>
    /// Skip : 
    /// Take : Get specific number of a collection and return an Enumerable to work on that
    /// </summary>
    public void Pagination(int pageIndex, int pageSize)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        var result = numbers.Skip(pageIndex * pageSize).Take(pageSize);

        foreach (var item in result)
        {
            Console.WriteLine(item);
            Console.WriteLine("----------------------");
        }
    }

    /// <summary>
    /// Splits the elements of a sequence into chunks of size
    /// </summary>
    public void Chunk(int chunkSize)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        var result = numbers.Chunk(chunkSize);

        foreach (var item in result)
        {
            Console.WriteLine(item);
            Console.WriteLine("----------------------");
        }
    }

    public void AggregationFunctions(List<Person> people)
    {
        var totalCoun = people.Count();
        var minValue = people.Min();
        var minByValue = people.MinBy(x => x.Age);
        var maxValue = people.Max();
        var maxByValue = people.MaxBy(x => x.Age);
        var avg = people.Average(x => x.Age);
        var sum = people.Sum(x => x.Age);

        Console.Write($"Total count : {totalCoun}");
        Console.Write($"Min value : {minValue} | MinBy value : {minByValue}");
        Console.Write($"Max value : {maxValue} | MaxBy value : {maxByValue}");
        Console.Write($"Average : {avg}");
        Console.Write($"Sum : {sum}");
    }

    public void GeneratorFunctions()
    {
        var rangeNumbers = Enumerable.Range(0, 100).ToList();

        var empty = Enumerable.Empty<int>().ToList();

        var repeat = Enumerable.Repeat<int>(1, 20);
    }
}
