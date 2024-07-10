// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_03NETCORE
// {
//     class Emeloyee  // 직원 클래스
//     {
//         private string Name;
//         private string Position;
//         public string GetName()
//         {
//             return Name;
//         }
//         public void SetName(string Name)
//         { 
//             this.Name = Name; 
//         }
//         public string GetPosition()
//         {
//             return Position;
//         }
//         public void SetPosition(string Position)
//         {
//             this.Position = Position;
//         }
//     }

//     internal class MainApp4
//     {
//         public static void Main(String[] args)
//         {
//             Emeloyee eme = new Emeloyee();
//             eme.SetName("daniel");
//             eme.SetPosition("developer");
//             Console.WriteLine($"{eme.GetName()} {eme.GetPosition()}");

//             Emeloyee yee = new Emeloyee();
//             yee.SetName("benjamin");
//             yee.SetPosition("designer");
//             Console.WriteLine($"{yee.GetName()} {yee.GetPosition()}");
//         }
//     }   
// }
