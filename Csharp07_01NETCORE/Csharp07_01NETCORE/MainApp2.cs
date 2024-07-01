using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07_01NETCORE
{
    internal class MainApp2
    {
        #region ref, out
        ////나누기를 위한 메서드            몫 결과    나머지 결과
        //static void Divide(int a , int b, out int c, out int d)
        //{
        //    c = a / b;
        //    d = a % b;
        //}
        //public static void Main(string[] args)
        //{
        //    int a = 20, b = 3, c = 0, d = 0;
        //    Divide(a, b, out c, out d);
        //    Console.WriteLine($"몫 : {c}, 나머지 : {d}");
        //}
        #endregion
        #region P294~295 인라인 out변수로 문자열 형식의 날짜를 날짜 형식으로 변환하기

        //static void Main()
        //{
        //    if (DateTime.TryParse("2024/12/25", out var xmas))
        //    {
        //        Console.WriteLine(xmas);
        //    }
        //}

        #endregion
        #region P295 1부터 8760까지 정수에 해당하는 날짜를 반환하는 함수

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(GetDateTimeFromYearlyHourNumber(1));
        //    Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760 / 2));
        //    Console.WriteLine(GetDateTimeFromYearlyHourNumber(8760));

        //}
        //static DateTime GetDateTimeFromYearlyHourNumber(int number)
        //{
        //    return (new DateTime(2024,1,1,0,0,0)).AddHours(--number);
        //}

        #endregion
        #region P296 문자 관련 구조체 사용하기

        //public static void Main()
        //{
        //    char a = 'A', b = 'a';
        //    char c = '1', d = '\t';
        //    if (Char.IsUpper(a))
        //        Console.WriteLine($"{a}은(는) 대문자");
        //    if (Char.IsUpper(b))
        //        Console.WriteLine($"{b}은(는) 소문자");
        //    if (Char.IsNumber(c))
        //        Console.WriteLine($"{c}은(는) 숫자형");
        //    if (Char.IsWhiteSpace(d))
        //        Console.WriteLine($"{d}은(는) 공백 문자");

        //    Console.WriteLine(Char.ToLower(a));     //A->a
        //    Console.WriteLine(Char.ToUpper(b));     //a->A

        //    string s = "abc";
        //    if (Char.IsUpper(s[0]))
        //        Console.WriteLine("첫 글자가 대문자로 시작합니다");
        //    else
        //        Console.WriteLine("첫 글자가 소문자로 시작합니다");

        //    Console.WriteLine(Char.MinValue);
        //    Console.WriteLine(Char.MaxValue);

        //}

        #endregion
        #region P299 열거형 형식

        //static void Main(string[] args)
        //{
        //    // 전경색
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    Console.WriteLine("Blue");
        //    Console.ResetColor();
        //    // 배경색
        //    Console.BackgroundColor = ConsoleColor.Yellow;
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("Red");
        //    Console.ResetColor();
        //}

        #endregion
        #region P300 열거형 만들기

        //enum Item
        //{
        //    HP = 1, SPEED = 2, WEAPON = 3, GRENADE = 4
        //}
        //public static void Main(string[] args)
        //{
        //    Item item = new Item();

        //    item = Item.HP;
        //    Console.WriteLine(item);

        //    switch (item)
        //    {
        //        case Item.HP:
        //            Console.WriteLine("아이템 회복");
        //            break;
        //        case Item.SPEED:
        //            Console.WriteLine("스피드 증가");
        //            break;
        //        case Item.WEAPON:
        //            Console.WriteLine("무기 강화");
        //            break;
        //        case Item.GRENADE:
        //            Console.WriteLine("수류탄 3개 보유");
        //            break;
        //    }
        //}

        #endregion
        #region P303 열거형으로 관련 있는 항목을 묶기

        //enum Animal
        //{
        //    Mouse, Cow, Tiger
        //}
        //static void Main()
        //{
        //    Animal animal = Animal.Tiger;
        //    Console.WriteLine(animal);

        //    if (animal == Animal.Tiger)
        //    {
        //        Console.WriteLine("호랑");
        //    }
        //}

        #endregion
        #region P305 열거형과 switch문 함께 사용

        //enum Animal
        //{
        //    Chicken, Dog, Pig
        //}
        //static void Main()
        //{
        //    //Animal animal = new Animal();
        //    Animal animal = Animal.Dog;

        //    switch (animal)
        //    {
        //        case Animal.Chicken:
        //            Console.WriteLine("닭");
        //            break;
        //        case Animal.Dog:
        //            Console.WriteLine("개");
        //            break;
        //        case Animal.Pig:
        //            Console.WriteLine("돼지");
        //            break;
        //        default:
        //            Console.WriteLine("기본값 설정 영역");
        //            break;
        //    }
        //}

        #endregion
    }
}
