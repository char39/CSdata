// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_03NETCORE
// {
//     internal class MainApp6
//     {
//         private class WaterHeater
//         {
//             protected int temperature;
//             public void SetTemperature(int temperature)
//             {
//                 if (temperature < -5 || temperature > 42)
//                 {
//                     throw new Exception("Out of temperature range");
//                     // 예외를 발생시키는 throw문
//                 }
//                 this.temperature = temperature;
//             }
//             internal void TurnOnWater()
//             {
//                 Console.WriteLine($"Turn on water : {temperature}");
//             }
//         }
//         static void Main(String[] args)
//         {
//             try     // 예외가 발생할 수 있는 코드를 try 블록으로 감싼다.
//             {
//                 WaterHeater heater = new WaterHeater();
//                 heater.SetTemperature(20);
//                 heater.TurnOnWater();
//                 heater.SetTemperature(-2);
//                 heater.TurnOnWater();
//                 heater.SetTemperature(50);
//                 heater.TurnOnWater();
//             }
//             catch (Exception e)     // 예외가 발생하면 catch 블록이 실행된다.
//             {
//                 Console.WriteLine(e.Message);
//             }
//             finally     // finally 블록은 예외 발생 여부와 상관없이 실행된다.
//             {

//             }
//         }
//     }
// }
