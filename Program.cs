using static Program;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 2, 2, 3, 4, 5, 6, 7, 8 };

        int[] empty_collection = { };

        var firstValue = numbers.First();

        Console.WriteLine(firstValue);

        Console.WriteLine();

        var lastValue = numbers.Last();

        Console.WriteLine(lastValue);

        Console.WriteLine();

        var elementAt = numbers.ElementAt(3);

        Console.WriteLine(elementAt);

        Console.WriteLine();

        var single = empty_collection.SingleOrDefault();

        Console.WriteLine(single);

        Console.WriteLine();

        var default_empty =  empty_collection.DefaultIfEmpty(10);

        foreach(var defaultempty in default_empty)
        {
            Console.WriteLine(defaultempty);
        }

    }
}