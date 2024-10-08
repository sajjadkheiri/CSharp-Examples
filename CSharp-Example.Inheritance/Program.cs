﻿using CSharp_Example.Inheritance;
using CSharp_Example.Inheritance.Constructor;
using CSharp_Example.Inheritance.Interfaces;

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


using (MyDisposable dispos = new MyDisposable())
{

}

MyImplicitImpl myImpli = new MyImplicitImpl();
myImpli.Insert();
myImpli.Update();

MyExplicitImpl myExpli = new MyExplicitImpl();
MyExplicit iexpli = myExpli;
