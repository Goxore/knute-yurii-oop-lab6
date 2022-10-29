public class Exercise3
{
    public static void Run()
    {

    }
}

public class MyClass
{
    public static SomeClass<T> FabricMethod<T>()
    {
        if (typeof(T) == typeof(string))
        {
            return (SomeClass<T>) new LogRed();
        }

        if (typeof(T) == typeof(int))
        {
            return (SomeClass<T>)new LogGreen();
        }

        throw new Exception("Impossible");
    }
}

public interface SomeClass<T>
{
    void ConsoleLog(T value);
}

public class LogRed: SomeClass<int>
{
    public void ConsoleLog(int value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(value);
        Console.ResetColor();
    }
}

public class LogGreen: SomeClass<int>
{
    public void ConsoleLog(int value)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(value);
        Console.ResetColor();
    }
}
