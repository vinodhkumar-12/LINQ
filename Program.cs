using static Program;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] number1 = { 1, 1, 2, 3, 4, 5 };
        int[] number2 = { 2, 6, 7, 8, 9 };

        var union_result =  number1.Union(number2);

        foreach(var union in union_result)
        {
            Console.WriteLine(union);
        }

        Console.WriteLine();


        var intersect_result = number1.Intersect(number2);

        foreach (var intersect in intersect_result)
        {
            Console.WriteLine(intersect);
        }


        Console.WriteLine();


        var except_result = number1.Except(number2);

        foreach (var except in except_result)
        {
            Console.WriteLine(except);
        }

        Console.WriteLine();


        var concat_result = number1.Concat(number2);

        foreach (var concat in concat_result)
        {
            Console.WriteLine(concat);
        }

        Console.WriteLine();


        var distinct_result =  number1.Select(x=> new {y=x}).Distinct();

        foreach (var distinct in distinct_result)
        {
            Console.WriteLine(distinct.y);
        }
    }
}