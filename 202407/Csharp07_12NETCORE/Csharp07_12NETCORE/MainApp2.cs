// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_12NETCORE
// {
//     class MyClass       // C나 C++에서 주로 사용하는 방법
//     {
//         private int myfield;                // 외부에서 직접 수정 불가
//         public int GetMyField()             // 외부에서 값을 불러오기 가능
//         {
//             return myfield;
//         }
//         public void SetMyField(int myField) // 외부에서 해당 메서드에 원하는 값으로 내부 myfield 반환
//         {
//             this.myfield = myField;
//         }
//     }
//     class YourClass     // C#에서 사용하는 방법. 프로퍼티를 사용
//     {
//         private int myfield;                // 외부에서 직접 수정 불가
//         public int MyField                  // 프로퍼티
//         {
//             get {return myfield;}       // 해당 변수값을 불러오기
//             set {myfield = value;}      // 프로퍼티에 값을 지정하면 해당 변수에 할당하기
//         }
//     }

//     internal class MainApp2
//     {
//         static void Main()
//         {
//             MyClass obj = new MyClass();
//             obj.SetMyField(3);
//             Console.WriteLine($"{obj.GetMyField()}");

//             YourClass obj2 = new YourClass();
//             obj2.MyField = 4;
//             Console.WriteLine($"{obj2.MyField}");
//         }
//     }
// }
