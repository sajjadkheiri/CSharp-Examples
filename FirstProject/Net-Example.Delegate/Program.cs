using Net_Example.Delegate;


Person person = new Person()
{
    FirstName = "Sajjad",
    LastName = "Kheiri"
};

PersonPrinter printer = new PersonPrinter();

printer.Print(PersonFullName.GetPersonalFullName, person);
printer.Print(PersonFullNameReverse.GetPersonalFullName, person);


//Or

PersonToString myDelegate = PersonFullName.GetPersonalFullName;
var result = myDelegate.Invoke(person);

Console.WriteLine(result);