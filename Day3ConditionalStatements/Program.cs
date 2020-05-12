using System;

namespace Day3ConditionalStatements
{

    /*
     Task
        Given an integer, , perform the following conditional actions:

        If  N is odd, print Weird
        If  N is even and in the inclusive range of 2 to 5, print Not Weird
        If  N is even and in the inclusive range of 6 to 20, print Weird
        If  N is even and greater than 20, print Not Weird
   */

    class Program
    {
        static void Main(string[] args)
        {
            const string WEIRD ="Weird";
            const string NOT_WEIRD = "Not Weird";

            int N = Convert.ToInt32(Console.ReadLine());

            if ((N % 2) > 0)
            {
                Console.WriteLine(WEIRD);
            }
            else
            {
                if (N>=2 && N<=5)
                {
                    Console.WriteLine(NOT_WEIRD);
                }
                else if (N >= 6 && N <= 20)
                {
                    Console.WriteLine(WEIRD);
                }
                else
                {
                    Console.WriteLine(NOT_WEIRD);
                }
            }
        }
    }
}
