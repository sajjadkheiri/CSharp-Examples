
using Net_Example.Generics;

#region Generics

GenericConcate<int> intConcate = new GenericConcate<int>();
Console.WriteLine(intConcate.Concate(1, 2));

GenericConcate<string> stringConcate = new GenericConcate<string>();
Console.WriteLine(stringConcate.Concate("Sajjad", "Kheiri"));

GenericConcate<Product> ProductConcate = new GenericConcate<Product>();
Console.WriteLine(ProductConcate.Concate(new Product { Name = "Samsung Tv", Price = 1000 },
                                         new Product { Name = "H&M shirt", Price = 69 }));

#endregion

#region Constraints

Printer<Student> studentPrinter = new Printer<Student>();
Printer<Teacher> teacherPrinter = new Printer<Teacher>();
Printer<Car> carPrinter = new Printer<Car>();

studentPrinter.PersonPrint(new Student
{
    FirstName = "Sajjad",
    LastName = "Kheiri",
    StudentId = 8585
});

teacherPrinter.PersonPrint(new Teacher
{
    FirstName = "Sajjad",
    LastName = "Kheiri",
    TeacherId = 7575
});

carPrinter.PersonPrint(new Car { CarId = 1 });

#endregion

#region Static Generic

StaticGeneric<int>.Counter = 10;
StaticGeneric<string>.Counter = 15;
StaticGeneric<bool>.Counter = 1;

Console.WriteLine(StaticGeneric<int>.Counter);
Console.WriteLine(StaticGeneric<string>.Counter);
Console.WriteLine(StaticGeneric<bool>.Counter);

StaticGeneric<int>.Counter = 20;

Console.WriteLine(StaticGeneric<int>.Counter);

#endregion

#region Generic Method

GenericMethod genericMethod = new GenericMethod();

genericMethod.Print(2);
genericMethod.Print<int>(1);

Console.WriteLine(genericMethod.ReturnData("Sajjad"));
Console.WriteLine(genericMethod.ReturnData<string>("Kheiri"));

#endregion