
using Net_Example.Linq;

#region Preparation

LinqFunctions linqFunctions = new LinqFunctions();

List<Person> people = new List<Person>(){
    new Person(){Age = 2,FirstName = "Homan",LastName = "Kheiri",},
    new Person(){Age = 35,FirstName = "Amirhossein",LastName = "Kheiri",},
    new Person(){Age = 5,FirstName = "Hamid",LastName = "Kheiri",},
    new Person(){Age = 10,FirstName = "Sajjad",LastName = "Kheiri",},
    new Person(){Age = 62,FirstName = "MohammadAli",LastName = "Kheiri",},
};

#endregion

#region Filter

linqFunctions.FilterPeople(people);

List<object> obj = new List<object>() { "Sajjad", 1, 2, 3, true, "Kheiri", 85 };

linqFunctions.FilterByType(obj);

#endregion

#region Sort

linqFunctions.SortByFirstName(people);

linqFunctions.SortByTwoOptions(people);
    
#endregion

