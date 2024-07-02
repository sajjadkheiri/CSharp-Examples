
using Net_Example.Linq;

#region Preparation

LinqFunctions linqFunctions = new LinqFunctions();

List<Person> people = new List<Person>(){
    new Person(){Age = 2,FirsName = "Homan",LastName = "Kheiri",},
    new Person(){Age = 35,FirsName = "Amirhossein",LastName = "Kheiri",},
    new Person(){Age = 5,FirsName = "Hamid",LastName = "Kheiri",},
    new Person(){Age = 10,FirsName = "Sajjad",LastName = "Kheiri",},
    new Person(){Age = 62,FirsName = "MohammadAli",LastName = "Kheiri",},
};

#endregion

#region Filter

linqFunctions.FilterPeople(people);

List<object> obj = new List<object>() { "Sajjad", 1, 2, 3, true, "Kheiri", 85 };

linqFunctions.FilterByType(obj);

#endregion