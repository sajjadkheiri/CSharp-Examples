using CSharp.Examples;

Console.WriteLine("Hello, World!");


Property property = new Property()
{
    FatherName = "Alireza"
};

property.FirstName = "Sajjad";
var readOnlyProperty = property.LastName;