// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_08NETCORE
// {
//     // (기반)부모클래스와 (파생)자식클래스 사이의 형식 변환. is, as 연산자
//     class Mammal    // 포유류
//     {
//         public void Nurse() 
//         {
//             Console.WriteLine("Nurse()");
//         }
//     }
//     class Dog : Mammal
//     {
//         public void Bark()
//         {
//             Console.WriteLine("Bark()");
//         }
//     }
//     class Cat : Mammal
//     {
//         public void Meow()
//         {
//             Console.WriteLine("Meow()");
//         }
//     }
//     internal class MainApp
//     {
//         // is 연산자 : 형식 변환이 가능한지 확인하여 true, false 반환
//         // as 연산자 : 형식 변환이 가능하면 변환, 불가능하면 null 반환
//         // 다만 형식변환자가 변환에 실패하면 예외가 발생하지만, as 연산자는 null을 반환
//         // is, as 연산자는 형식 변환을 위한 안전한 방법

//         // ex) double은 float으로 형변환 가능하지만, float은 double로 형변환 불가능
//         // ex) 그래서 Mammal은 Dog로 형변환 가능하지만, Dog은 Mammal로 형변환 불가능

//         static void Main(string[] args)
//         {
//             Mammal mammal = new Dog();  // Dog는 Mammal의 파생클래스이므로 형변환 가능
//             Dog dog;
//             if (mammal is Dog)  // 형식 변환이 가능한지 확인
//             {
//                 dog = (Dog)mammal;
//                 dog.Bark();
//             }
            
//             Mammal mammal2 = new Cat();
//             Cat cat = mammal2 as Cat;   // 형식 변환 가능하므로 Cat 반환
//             if (cat != null)
//                 cat.Meow();
            
//             // mammal 객체는 Dog 클래스로 생성되었으므로 Cat 클래스로 형변환 불가능
//             Cat cat2 = mammal as Cat;   // 형식 변환이 불가능하므로 null 반환
//             if (cat2 != null)
//                 cat2.Meow();
//             else Console.WriteLine("cat2 is null");
//         }
//     }
// }
