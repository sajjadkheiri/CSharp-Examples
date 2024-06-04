
using Net_Example.Generics;

GenericConcate<int> intConcate = new GenericConcate<int>();
Console.WriteLine(intConcate.Concate(1, 2));

GenericConcate<string> stringConcate = new GenericConcate<string>();
Console.WriteLine(stringConcate.Concate("Sajjad", "Kheiri"));

GenericConcate<Product> ProductConcate = new GenericConcate<Product>();
Console.WriteLine(ProductConcate.Concate(new Product { Name = "Samsung Tv", Price = 1000 },
                                         new Product { Name = "H&M shirt", Price = 69 }));