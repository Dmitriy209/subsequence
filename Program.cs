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
            string subsequence = Convert.ToString(startCycle); //Я забыл добавить объяснение выбора циклов

            for (int i = startCycle; i <= endCycle; i += stepCycle) //С помощью цикла for можно дойти от 5 до 103 за наименьшее количество итерация
            {
                if (i != 5) //Цикл if нужен для того, чтобы убрать лишнюю 5 в начале цикла, я думаю можно обойтись без него, но не знаю как
                {
                    subsequence = subsequence + " " + i;
                    if (i == endCycle) //Цикл if считаю достаточным для проверки окончания программы, хотя можно заменить на while или switch
                    {
                        Console.WriteLine(subsequence);
                    }
                }
            }
        }
    }
}
