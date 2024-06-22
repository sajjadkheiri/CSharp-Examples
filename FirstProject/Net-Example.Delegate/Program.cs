﻿using Net_Example.Delegate;


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
Console.WriteLine(result);

// Multicast delegate void

MulticastDelegateFunctions multicastDelegateFunctions = new MulticastDelegateFunctions();

MethodNamePrinter myMulticastDelegate = multicastDelegateFunctions.Method1;
myMulticastDelegate += multicastDelegateFunctions.Method2;
myMulticastDelegate += multicastDelegateFunctions.Method3;
myMulticastDelegate += multicastDelegateFunctions.Method4;

myMulticastDelegate();


// Multicast delegate with value => Just print the last value
PersonToString personDelegate = PersonFullName.GetPersonalFullName;
personDelegate += PersonFullNameReverse.GetPersonalFullName;

PersonPrinter personPrinter = new PersonPrinter();
personPrinter.Print(personDelegate,person);
