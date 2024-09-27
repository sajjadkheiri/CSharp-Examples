using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Example.Structs
{
    /// <summary>
    /// Old Syntax
    /// </summary>
    public struct Person1
    {
        public int age;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /// <summary>
    /// It was introduced in C# 7.2
    /// </summary>
    public readonly struct Person2
    {
        public readonly int age;
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    /// <summary>
    /// It was introduced in C# 8
    /// You cannot assign a number in ReadOnly method
    /// </summary>
    public struct Person3
    {
        public int age;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public readonly string GetFullName()
        {
            //Id++;
            return $"{FirstName} , {LastName}";
        }
    }

    /// <summary>
    /// After C# 10 the struct has default constructor
    /// But you should fill all the properties except nullable
    /// </summary>
    public struct Person4
    {
        public Person4()
        {
            age = 10;
            Id = 1;
        }

        public int age;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    /// <summary>
    /// There is not Inheritance in struct
    /// </summary>
    public struct Person5 //: Person1
    {
        public string FatherName { get; set; }
    }
}
