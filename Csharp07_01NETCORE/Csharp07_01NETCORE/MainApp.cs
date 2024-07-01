//using System;
//using Csharp07_01NETCORE_Jumbo;
//using Csharp07_01NETCORE_Info;
//using System.Reflection.Metadata.Ecma335;

//namespace Csharp07_01NETCORE
//{
//    public class MainApp
//    {
//        public static void Swap(ref int a, ref int b)   //ref : 값(스택)이 아닌 주소(힙, 참조형식)에 전달
//        {
//            int temp = b;
//            b = a; a = temp;
//            Console.WriteLine($"Swap Method 에서 호출 : {a}, {b}");
//        }
//        static void Main(string[] args)
//        {
//            //int x = 3, y = 4;
//            //Console.WriteLine($"Main Method 에서 호출 : {x}, {y}");
//            //Swap(ref x, ref y);
//            //Console.WriteLine($"Main Method 에서 호출 : {x}, {y}");

//            //SomeClass obj = new SomeClass();
//            ////int result = obj.SomeMethod();
//            ////참조형 데이터. 즉 주소로 반환 받아야 하기 때문에
//            ////위와 같이 값으로 받으면안됨
//            ////아래의 내용처럼 주소로 참조형 변수로 받아야 한다.
//            //ref int result = ref obj.SomeMethod();
//            //Console.WriteLine(result);

//            Product carrot = new Product();
//            ref int ref_LocalPrice = ref carrot.GetPrice();
//            int normal_LocalPrice = carrot.GetPrice();

//            carrot.PrintPrice();
//            Console.WriteLine($"Ref LocalPrice : {ref_LocalPrice}\nNormal LocalPrice : {normal_LocalPrice}");

//            ref_LocalPrice = 200;
//            carrot.PrintPrice();
//            Console.WriteLine($"Ref LocalPrice : {ref_LocalPrice}\nNormal LocalPrice : {normal_LocalPrice}");

//            normal_LocalPrice = 300;
//            carrot.PrintPrice();
//            Console.WriteLine($"Ref LocalPrice : {ref_LocalPrice}\nNormal LocalPrice : {normal_LocalPrice}");

//        }
//    }
//}
