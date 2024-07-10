// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_08NETCORE
// {

//     class ArmorSuite
//     {
//         // 가상 메서드 : 파생클래스에서 재정의 가능한 메서드 (virtual)
//         // 가상 메서드는 override 키워드를 사용하여 파생클래스에서 재정의 가능
//         public virtual void Initialize()
//         {
//             Console.WriteLine("Armored");
//         }
//     }
//     class IronMan : ArmorSuite
//     {
//         public override void Initialize()
//         {
//             base.Initialize();                          // 부모의 기능을 물려받고
//             Console.WriteLine("Repulsor Rays Armed");   // 자식의 기능을 추가함
//         }
//     }
//     class WarMachine : ArmorSuite   
//     {
//         public override void Initialize()
//         {
//             base.Initialize();
//             Console.WriteLine("Double-Barrel Cannons Armed");
//             Console.WriteLine("Micro-Rocket Launcher Armed");
//         }
//     }
//     internal class MainApp2
//     {
//         static void Main()
//         {
//             Console.WriteLine("Creating ArmorSuite...");
//             ArmorSuite armorSuite = new ArmorSuite();
//             armorSuite.Initialize();
//             Console.WriteLine("\nCreating IronMan...");
//             ArmorSuite ironman = new IronMan();
//             ironman.Initialize();
//             Console.WriteLine("\nCreating WarMachine...");
//             ArmorSuite warmachine = new WarMachine();
//             warmachine.Initialize();
//         }
//     }
// }
