// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// // 메서드 숨기기 (Method Hiding) : 
// // 부모클래스에서 구현된 메서드를 감추고 자식클래스에서 구현된 메서드를 보여주는 것.
// //      부모클래스에서 구현된 메서드를 자식클래스에서 다시 구현하면
// //      부모클래스의 메서드는 숨겨지고 자식클래스의 메서드가 보여짐

// namespace Csharp07_08NETCORE
// {
//     class Base
//     {
//         public void MyMethod()
//         {
//             Console.WriteLine("Base.MyMethod()");
//         }
//     }
//     class Derived : Base
//     {
//         public new void MyMethod()
//         {
//             Console.WriteLine("Derived.MyMethod()");
//         }
//     }
//     internal class MainApp3
//     {
//         static void Main()
//         {
//             Base baseObj = new Base();
//             baseObj.MyMethod();

//             Derived derivedObj = new Derived();
//             derivedObj.MyMethod();

//             Base baseOrDerived = new Derived();
//             baseOrDerived.MyMethod();
//         }
//     }
// }
