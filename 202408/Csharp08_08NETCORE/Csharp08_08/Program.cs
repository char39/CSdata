using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Csharp08_08
{
/*  dynamic 예시
    class MyClass
    {
        public void FuncA()
        {

        }
    }

    internal class Program
    {
        static void Main()
        {
            dynamic obj = new MyClass();    // dynamic 키워드로 선언된 obj는 컴파일 시점에 MyClass의 FuncA()만 인식
            obj.FuncA();
            obj.FuncB();
        }
    } */
/*  dynamin 예시 2
    class Duck
    {
        public void Walk()
        {
            Console.WriteLine("Duck Walk");
        }
        public void Swim()
        {
            Console.WriteLine("Duck Swim");
        }
        public void Say()
        {
            Console.WriteLine("Duck Say");
        }
    }

    class Mallard : Duck {}
    class Robot
    {
        public void Walk()
        {
            Console.WriteLine("Robot Walk");
        }
        public void Swim()
        {
            Console.WriteLine("Robot Swim");
        }
        public void Say()
        {
            Console.WriteLine("Robot Say");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine();

            dynamic[] arr = [new Duck(), new Mallard(), new Robot()];
            foreach (dynamic duck in arr)
            {
                Console.WriteLine(duck.GetType());
                duck.Walk();
                duck.Swim();
                duck.Say();
                Console.WriteLine();
            }
        }
    } */


    internal class Program
    {
        public static void OldWay(string[] data, string savePath)
        {
            Excel.Application excelApp = new Excel().Application();
            excelApp.Workbooks.Add(Type.Missing);
        }

        static void Main()
        {

        }
    }

}