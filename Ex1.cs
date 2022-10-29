public class Exercise1
{
    public static void Run()
    {
        MyList<int> myList = new MyList<int>(100);
        myList.Add(0);
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);
        myList.Add(6);
        myList.Add(7);
        myList.Add(8);
        myList.Add(9);
        myList.Add(10);
        myList.Add(11);
        myList.Add(12);
        myList.Add(13);
        myList.Add(14);

        myList.RemoveAt(7);
        myList.RemoveAt(11);

        for (int i = 0; i < 13; i++)
        {
            System.Console.WriteLine(myList[i]);
        }

    }
}

public class MyList<T>
{
    private ListItem<T>[] arr;
    private int nextIndex = 0;

    public T this[int i] => arr[i].value;

    public int Count => nextIndex;

    public MyList(int maxLength)
    {
        arr = new ListItem<T>[maxLength];
    }

    public void RemoveAt(int index)
    {
        arr[index].value = default(T);
        nextIndex--;

        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i] == null)
                return;
            arr[i] = arr[i + 1];
        }
    }

    public void Add(T value)
    {
        if (nextIndex >= arr.Length)
            throw new IndexOutOfRangeException("Too many elements");
        arr[nextIndex++] = new ListItem<T>(value);
    }
}

public class ListItem<T>
{
    public T? value;

    public ListItem(T? value)
    {
        this.value = value;
    }
}
