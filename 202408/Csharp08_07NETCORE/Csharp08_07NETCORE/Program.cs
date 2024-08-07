using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;      // Attribute 사용을 위해 추가

namespace Csharp08_07NETCORE
{
    /*  Attribute 사용 예시
    class MyClass
    {
        [Obsolete("\nNewMethod()를 사용해주세요.")]
        public void OldMethod()
        {
            Console.WriteLine("OldMethod");
        }
        public void NewMethod()
        {
            Console.WriteLine("NewMethod");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new();
            obj.OldMethod();
            obj.NewMethod();
        }
    } */
    /*  Attribute 예시 2
    class Trace()
    {
        public static void WriteLine
        (string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"\n{file}\t(Line : {line}, {member} : {message})\n");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Trace.WriteLine("복숭아 먹고싶다");
        }
    } */

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]  // Attribute 사용 대상 및 허용 여부 설정
    class History : Attribute           // Attribute 클래스 선언
    {
        private string programmer;
        public double Version { get; set; }
        public string? Changes { get; set; }
        public History(string programmer)
        {
            this.programmer = programmer;
            Version = 1.0f;
            Changes = "First Commit";
        }
        public string Programmer
        {
            get { return programmer; }
        }
    }

    [History("Sean", Changes = "20240806", Version = 0.1f)]
    [History("Bob", Changes = "20240807", Version = 0.2f)]
    class MyClass
    {
        public void Func()
        {
            Console.WriteLine("Func() 호출");
        }
    }

    internal class Program
    {
        static void Main()
        {

        }
    }

}