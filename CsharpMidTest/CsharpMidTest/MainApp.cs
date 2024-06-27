using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMidTest
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Random Ran = new Random();
            int[] Lotto = { 1, 1, 1, 1, 1, 1 };

            for (int i = 0; i < Lotto.Length; i++)
            {
                if (i == 0)
                {
                    Lotto[i] = Ran.Next(1, 46);
                }
                else
                {
                    Lotto[i] = Ran.Next(1, 46);
                    for (int j = 0; j < i; j++)
                    {
                        while (Lotto[i] == Lotto[j])
                            Lotto[i] = Ran.Next(1, 46);
                    }
                }
            }
            for (int i = 0; i < Lotto.Length; i++)
                Console.WriteLine(Lotto[i]);
        }
    }
}
