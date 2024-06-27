//using System;



//namespace CsharpMidTest
//{
//    public class A
//    {
//        public string[] Day = { "월", "화", "수", "목", "금", "토", "일" };
//        static public int Sum(int x, int y)
//        {
//            return x + y;
//        }
//        public void Inst()
//        {
//            for (int i = 0; i < Day.Length; i++)
//                Console.WriteLine(Day[i]);
//        }
//    }
//    public class B
//    {
//        static public void Method()
//        {
//            int temp = A.Sum(5, 6);
//            Console.WriteLine($"더하기는 : {temp}");
//        }
//        static public void Method2()
//        {
//            A func = new A();
//            func.Inst();
//        }
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 5, num2 = 6;
//            B.Method();
//            B.Method2();

//            #region
//            /*
//            6개 번호를 출력하는데, 중복이 되면안됨
//            1부터 45번까지 의 랜덤번호

            
//             */
//            //Random Ran = new Random();
//            //int[] Lotto = {1,2,3,4,5,6};
//            //for (int i = 0; i < 6; i++)
//            //{
//            //    foreach (int j in Lotto)
//            //    {
//            //        if (i != 0)
//            //        {
//            //            if (j == Lotto[i])
//            //            {
//            //                i--;
//            //                break;
//            //            }
//            //        }
//            //        //if ((j == Lotto[i]) && !(i==0))
//            //        //{
//            //        //    break;
//            //        //}
//            //        //else
//            //        //{
//            //        //    break;
//            //        //}
//            //    }

//            //    Lotto[i] = Ran.Next(1, 46);
//            //    Console.WriteLine(Lotto[i]);

//            //}

//            //j랑 로또랑 같고, i가 0일때

//            //Random Ran = new Random();
//            //int[] Lotto = { 1, 2, 3, 4, 5, 6 };
//            //for (int i = 0; i < Lotto.Length; i++)
//            //{

//            //}

//            //void GiveNum()
//            //{
//            //    Lotto[i] = Ran.Next(1, 46);
//            //}
//            //Console.WriteLine($"더하기는 : {A.Sum(num1, num2)}");
//            #endregion
//        }
//    }
//}
