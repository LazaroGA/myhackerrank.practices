using System.IO;
using System;
using System.Runtime.CompilerServices;

class Solution
{

    // Complete the factorial function below.
    static int factorial(int n)
    {
        Console.Write($"\nn: {n} \t n > 1 : {n > 1}");
        if (n > 1)
        {
            Console.Write($"\texecuting: {n} * factorial({n-1})");
            return n * factorial(n - 1);
        }
        Console.Write($"\treturning: {n}");
        return n;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        TextWriter textWriter = new StreamWriter(Path.Combine(@"C:\A\hackerrank", "factorial_output.txt"), true);
        StreamReader reader = new StreamReader(Path.Combine(@"C:\A\hackerrank", "factorial_input.txt"), true);


        int n = Convert.ToInt32(reader.ReadLine());

        Console.WriteLine($"Starting...");
        Console.WriteLine($"\nGet {n}!");

        int result = factorial(n);
        Console.WriteLine($"\n\nResult: {result}");
        Console.WriteLine($"\nFinished!");

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
