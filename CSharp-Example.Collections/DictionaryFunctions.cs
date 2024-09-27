namespace CSharp_Example.Collections;

public class DictionaryFunctions
{
    Dictionary<string, string> myDic = new Dictionary<string, string>();

    public void Add(string key, string value)
    {
        if (!myDic.ContainsKey(key))
        {
            myDic.Add(key, value);
        }
    }

    public string GetByKey(string key) => myDic[key];

    public void PrintAll()
    {
        foreach (var item in myDic)
        {
            Console.WriteLine($"The value of {item.Key} is {item.Value}");
        }
    }
}
