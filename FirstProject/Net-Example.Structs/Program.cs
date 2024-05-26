// See https://aka.ms/new-console-template for more information
using Net_Example.Structs;

Console.WriteLine("Hello, World!");

Person1 person1 = new Person1
{
    Id = 1,
    age = 25,
    FirstName = "Sajjad",
    LastName = "Kheiri"
};

/// with : Copy from a instnce
Person1 person2 = person1 with { FirstName = "HamidReza" };