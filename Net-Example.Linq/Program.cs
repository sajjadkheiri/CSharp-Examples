
using Net_Example.Linq;

#region Preparation

LinqFunctions linqFunctions = new LinqFunctions();

List<Person> people = new List<Person>(){
    new Person(){Id = 1,Age = 2,FirstName = "Homan",LastName = "Kheiri"},
    new Person(){Id = 2,Age = 35,FirstName = "Amirhossein",LastName = "Kheiri"},
    new Person(){Id = 3,Age = 5,FirstName = "Hamid",LastName = "Kheiri"},
    new Person(){Id = 4,Age = 10,FirstName = "Sajjad",LastName = "Kheiri"},
    new Person(){Id = 5,Age = 62,FirstName = "MohammadAli",LastName = "Kheiri"},
};

List<PersonInformation> personInformation = new List<PersonInformation>(){
    new PersonInformation{Id = 1, PersonId = 5,NationalCode = "0011226677",FatherName = "Mohammad"},
    new PersonInformation{Id = 2, PersonId = 3,NationalCode = "3366558877",FatherName = "Reza"},
    new PersonInformation{Id = 3, PersonId = 4,NationalCode = "1597643898",FatherName = "Ali"},
    new PersonInformation{Id = 4, PersonId = 1,NationalCode = "3625365987",FatherName = "Pouya"},
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

#region GroupBy

linqFunctions.GroupByPeople(people);

#endregion

#region Join

linqFunctions.InnerJoinPersonInfo(people, personInformation);

linqFunctions.GroupJoinPersonInfo(people, personInformation);

#endregion

#region Operations

linqFunctions.Distinct();
linqFunctions.DistinctBy(people);

linqFunctions.Union();
linqFunctions.UnionBy(people, people);

linqFunctions.Except();
linqFunctions.ExceptBy(people, new List<int> { 2, 3 });

linqFunctions.Intersect();
linqFunctions.IntersectBy(people, new List<int> { 2, 3 });

linqFunctions.Pagination(0, 3);
linqFunctions.Pagination(1, 3);
linqFunctions.Pagination(2, 3);
linqFunctions.Pagination(3, 3);

linqFunctions.Chunk(4);

#endregion

#region Aggregations

linqFunctions.AggregationFunctions(people);

#endregion

#region Generators
    
    linqFunctions.GeneratorFunctions();

#endregion