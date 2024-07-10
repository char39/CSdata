// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// // 분할 클래스 (Partial Class)
// //      같은 클래스를 여러 번 나누어 작성할 수 있음

// namespace Csharp07_08NETCORE
// {
//     partial class MyClass
//     {
//         public void Method1()
//         {
//             Console.WriteLine("Method1");
//         }
//         public void Method2()
//         {
//             Console.WriteLine("Method2");
//         }
//     }
//     partial class MyClass
//     {
//         public void Method3()
//         {
//             Console.WriteLine("Method3");
//         }
//         public void Method4()
//         {
//             Console.WriteLine("Method4");
//         }
//     }
//     internal class MainApp6
//     {
//         static void Main()
//         {
//             MyClass obj = new MyClass();
//             obj.Method1();
//             obj.Method2();
//             obj.Method3();
//             obj.Method4();
//         }
//     }
// }
