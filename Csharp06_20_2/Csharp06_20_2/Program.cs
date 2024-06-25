using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp06_20_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 수업 마지막 * 삼각형 역삼각형 테스트
            #region 내 답안
            //Console.Write("원하는 별의 개수 : ");
            //int max_star = Int32.Parse(Console.ReadLine());

            //for (int i = 1; i <= max_star; i++)
            //{
            //    for (int star = max_star; star > 0; star--)
            //    {
            //        if (star == i)
            //        {
            //            for (int write_star = 1; write_star <= max_star; write_star++)
            //            {
            //                Console.Write("* ");
            //                if (write_star == i)
            //                    break;
            //            }
            //        }    
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= max_star; i++)
            //{
            //    for (int star = 1; star <= max_star; star++)
            //    {
            //        if (star == i)
            //        {
            //            for (int write_star = max_star; write_star >= 0; write_star--)
            //            {
            //                Console.Write("* ");
            //                if (write_star == i)
            //                    break;
            //            }
            //        }
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 의도된 답

            int i, j;
            Console.WriteLine("삼각형 별 찍기\n");
            for (i = 0; i < 10; i++)            //외부 for문 i는 0부터 9까지
            {
                for (j = 0; j < 10 - i; j++)    //내부 for문 j는 0부터 10 - i 까지
                    Console.Write(" ");
                for (j = 0; j < i; j++)         //내부 for문 j는 0부터 i 까지
                    Console.Write("* ");
                Console.WriteLine();
            }

            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < i + 1; j++)
                    Console.Write(" ");
                for (j = 0; j < 9 - i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }



            #endregion


        }
    }
}
