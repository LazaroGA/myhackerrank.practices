using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dyamicarray
{
    class Result
    {

        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            var retList = new List<int>();
            var seqList = new List<List<int>>();
            var lastAnswer = 0;
            int seqIndex;

            //Create seqList
            for (int i = 0; i < n; i++)
            {
                seqList.Add(new List<int>());
            }

            for (int i = 0; i < queries.Count; i++)
            {
                var q = queries[i][0];
                var x = queries[i][1];
                var y = queries[i][2];

                seqIndex = (x ^ lastAnswer) % n;

                if (q == 1)// QueryType 1
                {
                    seqList[seqIndex].Add(y);
                }
                else       // QueryType 2
                {
                    lastAnswer = seqList[seqIndex][y % seqList[seqIndex].Count];
                    retList.Add(lastAnswer);
                }
            }
            return retList;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            TextWriter textWriter = new StreamWriter(Path.Combine(@"C:\A\hackerrank", "dynamicarray_output.txt"), true);
            StreamReader reader = new StreamReader(Path.Combine(@"C:\A\hackerrank", "dynamicarray_input.txt"), true);

            string[] firstMultipleInput = reader.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(reader.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> result = Result.dynamicArray(n, queries);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
