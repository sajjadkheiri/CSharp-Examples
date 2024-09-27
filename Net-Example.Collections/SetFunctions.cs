namespace Net_Example.Collections;

public class SetFunctions
{
    /// <summary>
    /// The set is a collection that contains no deuplicate element.
    /// There are 2 types of set : 1. HashSet 2. SortedSet
    /// HashSet does not store the elements in order while giving faster operation time.
    /// SortedSet stores the elements in order which allows more functionality.
    /// </summary>
    HashSet<string> set = new HashSet<string>();

    public void Add(string input) => set.Add(input);

    public void PrintAll()
    {
        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }

    public void Remove(string item) => set.Remove(item);

    public void Clear() => set.Clear();

    public bool Contains(string item) => set.Contains(item);
}
