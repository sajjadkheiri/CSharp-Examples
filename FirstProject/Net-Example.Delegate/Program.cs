using Net_Example.Delegate;


Person person = new Person()
{
    FirstName = "Sajjad",
    LastName = "Kheiri"
};

#region Delegate

PersonPrinter printer = new PersonPrinter();

printer.Print(PersonFullName.GetPersonalFullName, person);
printer.Print(PersonFullNameReverse.GetPersonalFullName, person);


//Or

PersonToString myDelegate = PersonFullName.GetPersonalFullName;
var result = myDelegate.Invoke(person);

Console.WriteLine(result);

#endregion

#region Func & Action

Func<int, int, int, string> func = FuncSample.MyIntToString;
Console.WriteLine(func(1, 2, 3));

printer.PrintFunc(PersonFullNameReverse.GetPersonalFullName, person);

Action<string,string> action = ActionSample.MyStringToVoid;
action("Sajjad","Kheiri");

#endregion