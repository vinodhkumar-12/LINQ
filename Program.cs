using static Program;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        IEnumerable<int> result = Enumerable.Empty<int>();

        int[] number = { 0, 1, 2, 3, 4, 5, 6 };

        result =  number.Take(3);

        foreach(var res in result)
        {
            Console.WriteLine(res);
        }

        Console.WriteLine();

        result = number.Skip(10);

        foreach (var res in result)
        {
            Console.WriteLine(res);
        }


    }
}