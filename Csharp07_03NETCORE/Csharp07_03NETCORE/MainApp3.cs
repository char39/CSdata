// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection.Metadata.Ecma335;
// using System.Text;
// using System.Threading.Tasks;

// // 객체 복사하기 : 얕은 복사와 깊은 복사 (얕은 복사는 주소값을 복사, 깊은 복사는 값 자체를 복사)
// namespace Csharp07_03NETCORE
// {
//     class MyClass
//     {
//         public int MyField1;
//         public int MyField2;
//         public MyClass DeepCopy()   // 깊은 복사 (값을 복사하기 때문에 값이 다름)
//         {                           // 자신의 멤버를 복사하여 새로운 객체를 만들어 반환
//             MyClass newCopy = new MyClass();
//             newCopy.MyField1 = this.MyField1;
//             newCopy.MyField2 = this.MyField2;
//             return newCopy;
//         }
//     }
//     internal class MainApp3
//     {
//         public static void Main(String[] args)
//         {
//             Console.WriteLine("-----SwallowCopy-----");
//             {
//             MyClass source = new MyClass();
//             source.MyField1 = 10;
//             source.MyField2 = 20;
//             MyClass target = source;    // 얕은 복사 (주소값을 복사 하기때문에 값이 같음)
//             target.MyField2 = 30;
//             source.MyField1 = 40;
//             Console.WriteLine($"{source.MyField1} {source.MyField2}");
//             Console.WriteLine($"{target.MyField1} {target.MyField2}");
//             }
//             Console.WriteLine("-----DeepCopy-----");
//             {
//             MyClass source = new MyClass();
//             source.MyField1 = 11;
//             source.MyField2 = 21;
//             MyClass target = source.DeepCopy();    // 깊은 복사 (값을 복사하기 때문에 값이 다름)
//             source.MyField1 = 41;
//             target.MyField2 = 31;
//             Console.WriteLine($"{source.MyField1} {source.MyField2}");
//             Console.WriteLine($"{target.MyField1} {target.MyField2}");
//             }
//         }
//     }
// }
