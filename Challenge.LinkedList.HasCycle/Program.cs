using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    class SLLNode
    {
        public int data;
        public SLLNode next;

        public SLLNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SLList
    {
        public SLLNode head;
        public SLLNode tail;

        public SLList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SLLNode node = new SLLNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SLLNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the hasCycle function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static bool hasCycle(SLLNode head)
    {
        var visited = new List<SLLNode>();
        if (head != null)
        {
            visited.Add(head);
            while (head.next!= null)
            {
                visited.Add(head.next);
                head = head.next;
                if (visited.GroupBy(x=>x).Any(y=>y.Count() > 1))
                {
                    return true;
                }
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        TextWriter textWriter = new StreamWriter(Path.Combine(@"C:\A\hackerrank", "has_cycle_output.txt"), true);
        StreamReader reader = new StreamReader(Path.Combine(@"C:\A\hackerrank", "has_cycle_input.txt"), true);

        //int tests = Convert.ToInt32(Console.ReadLine());
        int tests = Convert.ToInt32(reader.ReadLine());

        for (int testsItr = 0; testsItr < tests; testsItr++)
        {
            int index = Convert.ToInt32(reader.ReadLine());

            SLList llist = new SLList();

            int llistCount = Convert.ToInt32(reader.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(reader.ReadLine());
                llist.InsertNode(llistItem);
            }

            SLLNode extra = new SLLNode(-1);
            SLLNode temp = llist.head;

            for (int i = 0; i < llistCount; i++)
            {
                if (i == index)
                {
                    extra = temp;
                }

                if (i != llistCount - 1)
                {
                    temp = temp.next;
                }
            }

            temp.next = extra;

            bool result = hasCycle(llist.head);

            textWriter.WriteLine((result ? 1 : 0));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
