using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Stack<int> binary_ = new Stack<int>();
        int remainder;

        while (n > 0)
        {
            remainder = n % 2;
            binary_.Push(remainder);
            n = (n / 2);
        }

        int lastCounter = 0;
        List<int> continuousRecord = new List<int>();

        foreach (var item in binary_)
        {
            if (item == 1)
            {
                lastCounter++;
            }
            else
            {
                lastCounter = 0;
            }
            continuousRecord.Add(lastCounter);
            //Console.Write($" item:{item}");
            //Console.Write($"-counter:{lastCounter}");
            //Console.Write("\n");
        }

        //Console.Write("\n");

        //foreach (var item in binary_)
        //{
        //    Console.Write(item);
        //}

        //Console.Write("\n");

        //foreach (var item in continuousRecord)
        //{
        //    Console.Write(item);
        //}

        Console.WriteLine(continuousRecord.Max());
    }
}
