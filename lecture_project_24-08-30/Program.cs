using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;

        for (int i = 0; i < 4; i++)
        {
            sum += i;
            Console.WriteLine($"i: {i} \nsum = {sum}");

            if (sum == 3)
            {
                Console.WriteLine("We have now the magical sum of 3");
            }
            
            Console.WriteLine();
        }
    }
}