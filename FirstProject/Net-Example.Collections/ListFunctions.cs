namespace Net_Example.Collections;

public class ListFunctions
{
    List<string> myList = new List<string>();

    public void AddItem(string item)
    {
        myList.Add(item);
        myList.AddRange(new List<string> { "a", "b", "c" });
    }

    public void Capacity()
    {
        Console.WriteLine($"Capacity : {myList.Capacity}");
    }

    public void Count()
    {
        Console.WriteLine($"Count : {myList.Count}");
    }

    /// <summary>
    /// When you set a capacity for your list and then you have decided to increase capacity
    /// you will be able to use this method
    /// </summary>
    public void Ensure(int capacity)
    {
        myList.EnsureCapacity(capacity);
    }

    /// <summary>
    /// According to the structure of adding List's capacity automatically,
    /// you can reduce the capacity of List in the storage.
    /// Tip : If the capacity of filled list is more than 90% of List's capacity
    /// this method wont work :) SMART
    /// </summary>
    public void Trim()
    {
        myList.TrimExcess();
    }

    public void Remove()
    {
        myList.Remove("a");
        myList.RemoveAt(5);
        myList.RemoveRange(5, 10);
        myList.RemoveAll(ml => ml.StartsWith('a'));
        myList.Clear();
    }

    public void Insert()
    {
        myList.Insert(5, "a");
        myList.InsertRange(5, new List<string> { "a", "b", "c" });
    }

    public void Find()
    {
        string? finded = myList.Find(ml => ml.EndsWith('n'));
        List<string>? findedList = myList.FindAll(ml => ml.StartsWith('s'));
    }

    public IReadOnlyList<string> GetReadOnlyList()
    {
        return myList.AsReadOnly(); 
    }

}
