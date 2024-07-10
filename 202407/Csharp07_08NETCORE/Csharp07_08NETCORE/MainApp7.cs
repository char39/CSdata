// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// // 확장 메서드 (Extension Method)
// //      이미 정의된 클래스에 새로운 메서드를 추가하는 기술
// //      기존 클래스의 소스 코드를 변경하지 않고 새로운 메서드를 추가할 수 있음
// //      확장 메서드는 정적 클래스에 정적 메서드로 정의
// //      첫 번째 매개변수에 this 키워드를 사용하여 확장할 클래스의 형식을 지정
// //      확장 메서드는 인스턴스 메서드처럼 호출할 수 있음
// //      확장 메서드는 정적 메서드이므로 클래스 이름을 사용하여 호출할 수도 있음

// // 확장 메서드(Extension Method)는 기존의 클래스, 구조체, 인터페이스 등에
// // 새로운 메서드를 추가할 수 있게 해주는 C#의 기능입니다.
// // 이를 통해 기존 코드를 수정하지 않고도 새로운 기능을 추가할 수 있습니다.
// // 확장 메서드를 만들기 위해서는 정적 메서드를 정적 클래스 안에 선언해야 하며,
// // 첫 번째 매개변수 앞에 this 키워드를 사용하여 확장할 타입을 지정해야 합니다.

// // 확장 메서드 작성 방법
// // 정적 클래스 생성: 확장 메서드를 포함할 정적 클래스를 생성합니다.
// // 정적 메서드 정의: 해당 클래스 내에 정적 메서드를 정의합니다.
// // 첫 번째 매개변수에 this 사용: 확장하고자 하는 타입을 첫 번째 매개변수로 지정하고,
// // 이 매개변수 앞에 this 키워드를 붙입니다.


// namespace Csharp07_08NETCORE
// {
//     public static class IntegerExtension
//     {
//         public static int Square(this int myInt)
//         {
//             return myInt * myInt;
//         }
//         public static int Power(this int myInt, int exponent)
//         {
//             int result = myInt;
//             for (int i = 1; i < exponent; i++)
//             {
//                 result = result * myInt;
//             }
//             return result;
//         }
//     }
//     internal class MainApp7
//     {
//         static void Main()
//         {
//             Console.WriteLine($"3^2: {3.Square()}");
//             Console.WriteLine($"3^4: {3.Power(4)}");
//             Console.WriteLine($"2^10: {2.Power(10)}");
//         }
//     }
// }
