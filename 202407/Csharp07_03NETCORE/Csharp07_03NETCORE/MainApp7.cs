// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Reflection.Metadata.Ecma335;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_03NETCORE
// {
//     internal class MainApp7
//     {
//         static void Main()
//         {
//             int iRandom = 0;
//             int iSelection = 0;
//             string[] choice = { "가위", "바위", "보" };
//             iRandom = (new Random()).Next(1, 4);

//             Console.WriteLine("가위(1), 바위(2), 보(3)를 입력하세요 : _\b");
//             Int32.TryParse(Console.ReadLine(), out iSelection);

//             Console.WriteLine($"\n사용자 : {choice[iSelection - 1]}");
//             Console.WriteLine($"컴퓨터 : {choice[iRandom - 1]}");
//             if (iSelection == iRandom)
//             {
//                 Console.WriteLine("비겼습니다.");
//             }
//             else
//             {
//                 switch (iSelection)
//                 {
//                     case 1:
//                         Console.WriteLine((iRandom == 2) ? "컴퓨터가 이겼습니다." : "사용자가 이겼습니다.");
//                         break;
//                     case 2:
//                         Console.WriteLine((iRandom == 3) ? "컴퓨터가 이겼습니다." : "사용자가 이겼습니다.");
//                         break;
//                     case 3:
//                         Console.WriteLine((iRandom == 1) ? "컴퓨터가 이겼습니다." : "사용자가 이겼습니다.");
//                         break;
//                 }
//             }
//         }
//     }
// }
