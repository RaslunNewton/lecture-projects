using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int userInput = 0;
        Console.WriteLine("Enter number:");

        userInput = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        MyLoop(userInput);
        
        static void MyLoop(int nrInteractions)
        {

            int sum = 0;

            for (int i = 0; i < nrInteractions; i++)
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

        Console.WriteLine("End Program!");
        Console.ReadKey();
        Console.Clear();
    }
}