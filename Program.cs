public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };


        int sumofnumbers = numbers.Sum();

        int sumofEvenNumbers = numbers.Where(x => x % 2 == 0).Sum();

        int minnumber = numbers.Min();

        int maxnumber = numbers.Max();

        int multiplicationofnumber = numbers.Aggregate((a,b) => a*b);

        Console.WriteLine("Sum of all the numbers : {0}", sumofnumbers);
        Console.WriteLine("Sum of all the even numbers : {0}", sumofEvenNumbers);
        Console.WriteLine("Min number : {0}", minnumber);
        Console.WriteLine("Max number : {0}", maxnumber);
        Console.WriteLine("Multiplication of number : {0}", multiplicationofnumber);
    }
}