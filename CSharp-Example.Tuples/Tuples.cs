using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Example.Tuplesp;

public class Tuples
{
    public void TupleSample()
    {
        (int Id, string FirstName, string LastName) person = (1, "Sajjad", "Kheiri");

        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
    }

    public (int Id, string FirstName, string LastName) RetuenTuple()
    {
        return (1, "Sajjad", "Kheiri");
    }

    public void ReturnTupleReconstruction()
    {
        (int Id, string FirstName, string LastName) = RetuenTuple();

        Console.WriteLine(FirstName);
        Console.WriteLine(LastName);
    }

    public Tuple<int, string, string> TupleSample2()
    {
        var data = Tuple.Create(1, "Sajjad", "Kheiri");
        return data;
    }
}
