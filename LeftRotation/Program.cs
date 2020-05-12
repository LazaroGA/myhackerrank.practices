using System;
using System.IO;
using System.Linq;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Path.Combine(@"C:\A\hackerrank", "leftrotation_output.txt"), true);
            StreamReader reader = new StreamReader(Path.Combine(@"C:\A\hackerrank", "leftrotation_input.txt"), true);

            string[] nd = reader.ReadLine().Split(' ');
            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);
            int[] a = Array.ConvertAll(reader.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                var position = i - d;
                if (position < 0)
                {
                    position = n + position;
                }
                b[position] = a[i];
            }

            b.ToList().ForEach(r => textWriter.Write(r.ToString() + " "));
            textWriter.Flush();
            textWriter.Close();
        }

    }
}