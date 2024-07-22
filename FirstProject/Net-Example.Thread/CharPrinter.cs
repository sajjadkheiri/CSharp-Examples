﻿namespace Net_Example.Thread;

public class CharPrinter
{
    public void StarPrinter()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write('*');
        }
    }

    public void DashPrinter()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write('-');
        }
    }

    public void FirstNamePrinter(object firstName)
    {
        Console.WriteLine($"My Name is {firstName}");
    }

    public void FullNamePrinter(string firstName, string lastName)
    {
        Console.WriteLine($"My fullname is {firstName} {lastName}");
    }
}
