using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCycle = 5;
            int endCycle = 103;
            int stepCycle = 7;
            string subsequence = Convert.ToString(startCycle);

            for (int i = startCycle; i <= endCycle; i += stepCycle)
            {
                if (i != 5)
                {
                    subsequence = subsequence + " " + i;
                    if (i == endCycle)
                    {
                        Console.WriteLine(subsequence);
                    }
                }
            }
        }
    }
}
