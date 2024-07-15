//using System.Reflection;

//namespace Csharp07_15NETCORE
//{
    /*  as 연산자로 형식 변환하기
    internal class Program
    {
        static void Main(string[] args)
        {
            object x = 1234;
            string? s = x as string;
            Console.WriteLine(s == null ? "x is not a string" : s);

            object x1 = "1234";
            string? s1 = x1 as string;
            Console.WriteLine(s1 == null ? "x1 is not a string" : s1);
        }
    }
    */
    /*  if문과 is 연산자 사용하기
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStars(null);
            PrintStars("하나");
            PrintStars(5);
        }
        static void PrintStars(object obj)
        {
            if (obj is null)
                return;
            if (obj is string)
                return;
            if (!(obj is int number))
                return;
            Console.WriteLine(new string ('*', number));
        }
    }
    */
    /*  문자열 다루기 ex) Trim()
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());

            string message1 = "  Hello  ";
            Console.Write(message1.Replace("Hello", "Hi").TrimStart());
            Console.WriteLine("a");
        }
    }
    */
    /*  String.Concat() 메서드
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "안녕" + "하세요";
            string s2 = String.Concat("반갑", "습니다");
            Console.WriteLine($"{s1} {s2}");
        }
    }
    */
    /*  문자열 대소문자 비교
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "RedPlus";
            string userNameInput = "redPlus";
            if (userName.ToLower() == userNameInput.ToLower())
                Console.WriteLine("[1] 같습니다.");
            if (string.Equals(userName, userNameInput, StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine("[2] 같습니다.");

            string s1 = "Gilbut";
            string s2 = "gilbut";
            if (s1 == s2)
                Console.WriteLine("같다.");
            else
                Console.WriteLine("다르다.");
            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("같다.");
        }
    }
    */
    /*  문자열 분리하기 Split()
    internal class Program
    {
        static void Main(string[] args)
        {
            string src = "Red, Green, Blue";
            string[] colors = src.Split(',');
            for (int i = 0; i < colors.Length; i++)
                colors[i] = colors[i].Trim();
            foreach (string color in colors)
                Console.WriteLine(color);

            var str1 = "";
            var str2 = String.Empty;
            if (str1 == null || str2 == "")
                Console.WriteLine("빈값");
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                Console.WriteLine("빈값2");
        }
    }
    */
//}
