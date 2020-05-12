using System;

namespace Day2Operators
{
    class Program
    {
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = meal_cost * ((double)tip_percent / 100);
            double tax = meal_cost * ((double)tax_percent / 100);
            int total = (int)Math.Round(meal_cost + tip + tax);
            Console.WriteLine(total);
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
