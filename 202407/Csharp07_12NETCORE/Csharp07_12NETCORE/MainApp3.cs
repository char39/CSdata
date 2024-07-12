// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_12NETCORE
// {
//     class BirthdayInfo
//     {
//         private string name;
//         private DateTime birthday;
//         public string Name
//         {
//             get {return name;}
//             set {name = value;}
//         }
//         public DateTime Birthday
//         {
//             get {return birthday;}
//             set {birthday = value;}
//         }
//         public int Age
//         {
//             get {return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;}
//             /*  Ticks에 관하여
//             DataTime.Now는 현재 시각을 나타내는 DateTime 객체를 가져온다.
//             Subtract(birthday)는 현재 시각에서 생일(birthday)을 빼서
//             두 날짜 사이의 시간 차이를 나타내는 TimeSpan 객체를 생성
//             Ticks : 
//                 TimeSpan 객체의 Ticks 속성은 시간 차이를 가장 작은 단위인
//                 '틱'으로 변환하여 반환합니다. 1틱은 100나노초를 의미함.
//                 Ticks 속성에서 얻은 값을 이용하여 새로운 DateTime 객체를 생성
//                 이렇게 생성된 DateTime 객체는 1900년 1월 1일부터 틱 수만큼 경과한 시각을 나타낸다.
//             */
//         }
//     }

//     internal class MainApp3
//     {
//         static void Main()
//         {
//             BirthdayInfo obj = new BirthdayInfo();
//             obj.Name = "박성순";
//             obj.Birthday = new DateTime(2000, 8, 3);
//             Console.WriteLine($"Name : {obj.Name}");
//             Console.WriteLine($"Birthday : {obj.Birthday}");
//             Console.WriteLine($"Age : {obj.Age}");
//         }
//     }
// }
