using Net_Example.Inheritance;

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

