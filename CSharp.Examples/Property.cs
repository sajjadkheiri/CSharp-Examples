using System;

namespace CSharp.Examples
{
    public class Property
    {
        public string FirstName { get; set; } 


        // ReadOnly Property
        public int LastName { get; private set; }

        // OR

        private string _lastName;
        public string LstName => _lastName;

        //Init-Only Property
        /// <summary>
        /// you can just set a value when you initial a class into a initializer
        /// </summary>
        public string FatherName { get; init; }
    }
}
