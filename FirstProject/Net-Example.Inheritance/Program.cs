using Net_Example.Inheritance;
using Net_Example.Inheritance.Constructor;

Animal animal = new();
Cat cat = new();
Dog dog = new();
Caw caw = new();

Console.WriteLine("Animal : ");
animal.Voice();

Console.WriteLine("Cat : ");
cat.Voice();

Console.WriteLine("Dog : ");
dog.Voice();

Console.WriteLine("Caw : ");
caw.Voice();


Teacher person = new()
{
    Id = 1,
    FirstName = "",
    LastName = ""
};


Product product = new();

Product productParam = new("input (prodct)");

Camera camera = new("input (camera)");