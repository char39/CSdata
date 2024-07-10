using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

//namespace Csharp06_26NETCORE
//{
//    struct Point
//    {
//        public int X; public int Y;
//    }
//    struct BusinessCard
//    {
//        public string Name;
//        public int Age;
//        public string Address;
//    }
//    struct Member
//    {
//        public string Name;
//        public int Age;
//    }
//    internal class MainApp
//    {
//        //static void print(string name, int age)
//        //    => Console.WriteLine($"{name}은(는) {age}살입니다.");

//        static void Main(string[] args)
//        {
//            #region 랜덤함수 인스턴스
//            //랜덤함수 인스턴스
//            //Random random = new Random();

//            //for (int i = 0; i < 20; i++)
//            //{
//            //    int ran = random.Next(1, 7);
//            //    Console.WriteLine(ran);
//            //}
//            #endregion
//            #region 랜덤값 배열로 100까지
//            //랜덤값 1에서 100까지 1차원 배열에 저장한 후 2의 배수와 6의 배수를 출력
//            //배열개수 100개

//            //Random random = new Random();

//            //int[] ran = new int[100];
//            //for (int i = 0; i < 100; i++)
//            //    ran[i] = random.Next(1, 101);
//            //for (int i = 0; i < 100; i++)
//            //{
//            //    if ((ran[i] % 2 == 0) && (ran[i] % 6 == 0))
//            //        Console.WriteLine($"{ran[i],3} : 2, 6의 배수");
//            //    else if (ran[i] % 2 == 0)
//            //        Console.WriteLine($"{ran[i],3} : 2의 배수");
//            //    else if (ran[i] % 6 == 0)
//            //        Console.WriteLine($"{ran[i],3} : 6의 배수");
//            //}

//            #endregion
//            #region 구조체
//            //Point p;
//            //p.X = 100; p.Y = 200;
//            //Console.WriteLine($"{p.X}, {p.Y}");

//            //BusinessCard my;
//            //my.Name = Console.ReadLine();
//            //my.Age = Int32.Parse(Console.ReadLine());
//            //my.Address = Console.ReadLine();
//            //Console.WriteLine($"{my.Address}, {my.Name}, {my.Age}");
//            #endregion
//            #region 구조체를 사용해 변수 하나로 여러개 묶어 관리

//            //Product pd;
//            //pd.Id = 1;
//            //pd.Title = "Good Book";
//            //pd.Price = 10000m;

//            //Console.WriteLine($"Num : {pd.Id}\nTitle : {pd.Title}\nPrice : {pd.Price}");

//            #endregion
//            #region 구조체 배열
//            ////[1]구조체 변수
//            //BusinessCard biz;
//            //biz.Name = "백종원";
//            //biz.Age = 50;
//            //print(biz.Name, biz.Age);
//            ////[2]구조체 배열
//            //BusinessCard[] names = new BusinessCard[2];
//            //names[0].Name = "이세영"; names[0].Age = 102;
//            //names[1].Name = "권경민"; names[1].Age = 31;
//            //for (int i = 0; i < names.Length; i++)
//            //{
//            //    print(names[i].Name, names[i].Age);
//            //}



//            #endregion
//            #region 구조체 매개변수

//            //string name = "백승수";
//            //int age = 21;
//            //Print(name, age);

//            //Member m;
//            //m.Name = "이세영";
//            //m.Age = 100;
//            //Print(m);

//            #endregion
//        }
//        static void Print(string name, int age) =>
//            Console.WriteLine($"이름 : {name}, 나이 : {age}");
//        static void Print(Member member) =>
//            Console.WriteLine($"이름 : {member.Name}, 나이 : {member.Age}");
//        //위의 함수 2개 오버로딩
//    }
//    struct Product
//    {
//        public int Id;
//        public string Title;
//        public decimal Price;
//    }
//}
