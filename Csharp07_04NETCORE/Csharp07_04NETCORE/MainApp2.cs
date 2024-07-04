//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp07_04NETCORE
//{
//    internal class MainApp2
//    {
//        static void Divide(int num1, int num2)
//        {
//            Console.WriteLine($"나눗셈의 몫 : {num1 / num2}");
//            Console.WriteLine($"나눗셈의 나머지 : {num1 % num2}");
//        }
//        static void Main(string[] args)
//        {
//            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            Console.WriteLine("두 개의 숫자를 나눕니다.");
//            Console.Write("첫번째 숫자 입력 : ");
//            int num1 = Int32.Parse(Console.ReadLine());
//            Console.Write("두번째 숫자 입력 : ");
//            int num2 = Int32.Parse(Console.ReadLine());
//            try
//            {
//                Divide(num1, num2);
//                for (int i = 0; i < arr.Length; i++)
//                {
//                    Console.WriteLine(arr[i]);
//                }
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                Console.WriteLine($"예외가 발생 했습니다. {ex.Message}");
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine($"0으로 나눌 수 없습니다. {ex.Message}");
//            }
//            finally
//            {
//                Console.WriteLine("프로그램 종료");
//            }

//        }
//    }
//}
