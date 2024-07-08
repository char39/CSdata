// using System;
// using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// // 읽기 전용 필드 (Read-Only Field)
// //      필드를 선언할 때 readonly 키워드를 사용하면 읽기 전용 필드가 됨
// // 컴파일시 값이 할당되는 const 키워드와 다르게 런타임 시점에 값을 할당할 수 있음

// namespace Csharp07_08NETCORE
// {
//     class Configuration
//     {
//         private readonly int min;
//         private readonly int max;
//         public Configuration(int v1, int v2)
//         {
//             // 읽기 전용 필드는 생성자에서만 값을 할당할 수 있음
//             min = v1;
//             max = v2;
//         }
//         public void ChangeMax(int newMax)
//         {
//             // 읽기 전용 필드는 값을 변경할 수 없음
//             //max = newMax;
//         }
//     }
//     internal class MainApp4
//     {
//         static void Main()
//         {
//             Configuration config = new Configuration(100, 1000);
            
//         }
//     }
// }
