using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int tests = int.Parse(Console.ReadLine());

        List<string> sList = new List<string>();

        for (int i = 0; i < tests ; i++)
        {
            sList.Add(Console.ReadLine());
        }

        string evenS = string.Empty;
        string oddS = string.Empty;

        foreach (var stringItem in sList)
        {
            char[] charArr = stringItem.ToCharArray();
            for (int j = 0; j < stringItem.Length; j++)
            {
                if (j % 2 == 0)
                {
                    evenS += charArr[j];
                }
                else
                {
                    oddS += charArr[j];
                }
            }

            Console.WriteLine($"{evenS} {oddS}");
            evenS = string.Empty;
            oddS = string.Empty;
        }
    }
}