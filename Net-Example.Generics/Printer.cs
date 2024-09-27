using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Generics
{
    /// <summary>
    /// Without Constraint
    /// </summary>
    public class Printer<TModel>
    {
        public void PersonPrint(TModel model)
        {
            var personModel = model as Person;

            Console.WriteLine(personModel);
        }
    }

    /// <summary>
    /// With Constraint
    /// Types of constraint => Where T : struct /  
    ///                        Where T : Class /
    ///                        Where T : Model (Person) /
    ///                        Where T : Interface (IPerson) /
    ///                        Where T : new()
    /// </summary>
    public class PersonPrinter<TModel> where TModel : Person
    {
        public void PersonPrint(TModel model)
        {   
            Console.WriteLine(model);
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }
    }

    public class Teacher : Person
    {
        public int TeacherId { get; set; }
    }

    public class Car
    {
        public int CarId { get; set; }
    }
}
