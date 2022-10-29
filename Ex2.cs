public class Exercise2
{
    public static void Run()
    {
        MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
        dictionary.AddValue("one", 1);
        dictionary.AddValue("two", 2);
        dictionary.AddValue("three", 3);
        dictionary.AddValue("four", 4);
        
        System.Console.WriteLine(dictionary.GetValue("three"));
    }
}

public class MyDictionary<TKey, TValue>
    where TKey : IComparable
{
    private List<(TKey, TValue)> list = new List<(TKey, TValue)>();

    public TValue GetValue(TKey key)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Item1.Equals(key))
            {
                return list[i].Item2;
            }
        }
        throw new Exception($"Key \"{key}\" not found");
    }

    public void AddValue(TKey key, TValue value)
    {
        list.Add((key, value));
    }

    public int Count => list.Count;
}
