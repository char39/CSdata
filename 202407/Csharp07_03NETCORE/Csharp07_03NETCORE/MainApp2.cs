//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp07_03NETCORE
//{
//    public class Global
//    {
//        public static int count = 0;
//    }
//    public class ClassA
//    {
//        public ClassA()
//        {
//            Global.count++;
//        }
//    }
//    public class ClassB
//    {
//        public ClassB()
//        {
//            Global.count++;
//        }
//    }
//    public class ClassC
//    {
//        public ClassC()
//        {
//            Global.count++;
//        }
//    }
//    internal class MainApp2
//    {
//        public static void Main()
//        {
//            Console.WriteLine($"Global.count : {Global.count}");
//            new ClassA();
//            new ClassB();
//            new ClassC();
//            Console.WriteLine($"Global.count : {Global.count}");
//        }
//    }
//}
