// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_12NETCORE
// {
//     #region 자동구현 프로퍼티
//     // public class NameCard
//     // {
//     //     private string name;
//     //     private string phonenumber;
//     //     public string? Name
//     //     {
//     //         // get {return name;}
//     //         // set {name = value;}
//     //         get; set;
//     //     } = "Unknown";                      // 이건 .NET 7.0 이상부터 지원
//     //     public string? PhoneNumber
//     //     {
//     //         get; set;
//     //     } = "000-0000-0000";
//     // }

//     // internal class MainApp4
//     // {
//     //     static void Main()
//     //     {
//     //         NameCard obj = new NameCard();
//     //         obj.Name = "Sans";
//     //         obj.PhoneNumber = "010 5959 5959";
//     //         Console.WriteLine($"{obj.Name}");
//     //         Console.WriteLine($"{obj.PhoneNumber}");
//     //     }
//     // }
//     #endregion
//     #region 
//     class BirthdayInfo
//     {
//         private string name;
//         private DateTime birthday;
//         public string Name
//         {
//             get; set;
//         }
//         public DateTime Birthday
//         {
//             get; set;
//         }
//         public int Age
//         {
//             get {return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;}
//         }
//     }

//     internal class MainApp4
//     {
//         static void Main()
//         {
//             BirthdayInfo obj = new BirthdayInfo()
//             {
//                 Name = "Cinnamon", Birthday = new DateTime(2000, 8, 3)
//             };
//             Console.WriteLine($"Name : {obj.Name}");
//             Console.WriteLine($"Birthday : {obj.Birthday}");
//             Console.WriteLine($"Age : {obj.Age}");
//         }
//     }
//     #endregion
// }
