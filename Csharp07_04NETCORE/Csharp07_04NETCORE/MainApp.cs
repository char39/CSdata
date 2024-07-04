//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp07_04NETCORE
//{
//    internal class MainApp
//    {
//        static void Divide(int num1, int num2)
//        {
//            if (num2 == 0)
//                throw new Exception("제수는 0으로 나눌 수 없다.");
//            Console.WriteLine($"나눗셈의 몫 : {num1 / num2}");
//            Console.WriteLine($"나눗셈의 나머지 : {num1 % num2}");
//        }
//        static void Main(string[] args)
//        {
//            int count = 0;
//            while (true)
//            {
//                Console.WriteLine("두 개의 숫자를 나눕니다.");
//                Console.Write("첫번째 숫자 입력 : ");
//                int num1 = Int32.Parse(Console.ReadLine());
//                Console.Write("두번째 숫자 입력 : ");
//                int num2 = Int32.Parse(Console.ReadLine());

//                try
//                {
//                    Divide(num1, num2);
//                    Console.WriteLine("나눗셈을 마쳤습니다.");
//                }
//                catch (Exception expn)
//                {
//                    Console.WriteLine($"{expn.Message}");
//                    Console.WriteLine($"프로그램을 다시 실행하세요. {++count}번째 시도.");
//                }
//                finally     //예외 발생 유무 상관없이 실행
//                {
//                    Console.WriteLine("프로그램 종료.");
//                }
//                if (num2 != 0) break;
//                if (count == 3)
//                {
//                    Console.WriteLine("세번 이상 0으로 나누려고 시도함");
//                    break;
//                }
//            }
//        }
//    }
//}
