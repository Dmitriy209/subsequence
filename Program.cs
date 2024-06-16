using System;

namespace subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCycle = 5;
            int endCycle = 103;
            int stepCycle = 7;

            for (int i = startCycle; i <= endCycle; i += stepCycle)
            {
                Console.WriteLine(i);
            }
        }
    }
}
