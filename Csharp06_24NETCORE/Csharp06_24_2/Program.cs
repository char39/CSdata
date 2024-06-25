namespace Csharp06_24_2
{
    internal class Program
    {
        #region 디폴트 함수
        ////매개변수에서 값이 초기화 되었다면 디폴트 함수 또는 기본매개변수
        //static void Log(String message, byte level = 1)
        //{
        //    Console.WriteLine($"{message}, {level}");
        //}
        //static void Main(string[] args)
        //{
        //    Log("Debug");
        //    Log("Error", 4);

        //}
        #endregion

        #region 명명된 매개 변수
        //static void Sum(int first, int second) //명명된 매개 변수
        //{
        //    Console.WriteLine(2 * first + second);
        //}
        //static void Main(string[] args)
        //{
        //    Sum(10, 20);                //기본형태
        //    Sum(first: 10, second: 20); //매개 변수 이름과 :을 사용하여 호출
        //    Sum(second: 20, first: 10); //매개 변수 이름 지정하면 변수 위치 변경 가능
        //}
        #endregion

        #region 서로 다른 매개변수를 갖는 함수 오버로드

        //static void Multi()
        //{
        //    Console.WriteLine("안녕하세요.");
        //}
        //static void Multi(string message)
        //{
        //    Console.WriteLine($"{message}");
        //}
        //static void Multi(string message, int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine($"{message}");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Multi();
        //    Multi("반갑습니다.");
        //    Multi("또 만나요.", 3);
        //}

        #endregion


    }
}
