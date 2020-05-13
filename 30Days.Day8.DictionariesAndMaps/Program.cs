using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int entries = int.Parse(Console.ReadLine());

        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        for (int i = 0; i < entries; i++)
        {
            string[] entry = Console.ReadLine().Split(' ');
            phonebook.Add(entry[0], entry[1]);
        }

        List<string> namesQ = new List<string>();
        string tempQ = Console.ReadLine();
        while (!string.IsNullOrEmpty(tempQ))
        {
            namesQ.Add(tempQ);
            tempQ = Console.ReadLine();
        };

        foreach (var itemName in namesQ)
        {
            if (phonebook.ContainsKey(itemName))
            {
                Console.WriteLine($"{itemName}={phonebook[itemName]}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }
}