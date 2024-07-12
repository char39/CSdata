// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace Csharp07_12NETCORE
// {
//     #region interface 예제 1.
//     // interface ILogger
//     // {
//     //     void WriteLog(string message);
//     // }
//     // interface IFormattableLogger : ILogger
//     // {
//     //     void WriteLog(string format, params Object[] args);
//     // }
//     // class ConsoleLogger2 : IFormattableLogger
//     // {
//     //     public void WriteLog(string message)
//     //     {
//     //         Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
//     //     }
//     //     public void WriteLog(string format, params object[] args)
//     //     {
//     //         string message = String.Format(format, args);
//     //         Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
//     //     }
//     // }

//     // internal class MainApp
//     // {
//     //     static void Main(string[] args)
//     //     {
//     //         IFormattableLogger logger = new ConsoleLogger2();
//     //         logger.WriteLog("지구평평");
//     //         logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
//     //     }
//     // }
//     #endregion
//     #region interface 예제 2. 여러 개의 인터페이스 상속
    
//     interface IRunable
//     {
//         void Run();
//     }
//     interface IFlyable
//     {
//         void Fly();
//     }
//     class FlyingCar : IRunable, IFlyable
//     {
//         public void Run()
//         {
//             Console.WriteLine("Run");
//         }
//         public void Fly()
//         {
//             Console.WriteLine("Fly");
//         }
//     }

//     internal class MainApp
//     {
//         static void Main()
//         {
//             FlyingCar car = new FlyingCar();
//             car.Run();
//             car.Fly();
//             IRunable runable = car as IRunable;
//             runable.Run();
//             IFlyable flyable = car as IFlyable;
//             flyable.Fly();
//         }
//     }
//     #endregion
//     #region abstract class 예제 1.
//     abstract class AbstractBase
//     {
//         protected void PrivateMethodA()
//         {
//             Console.WriteLine($"AbstractBase.PrivateMethodA()");
//         }
//         public void PublicMethodA()
//         {
//             Console.WriteLine($"AbstractBase.PublicMethodA()");
//         }
//         public abstract void AbstractMethodA();
//     }
//     class Derived : AbstractBase
//     {
//         public override void AbstractMethodA()
//         {
//             Console.WriteLine("Derived.AbstractMethodA()");
//             PrivateMethodA();
//         }
//     }
//     internal class MainApp2
//     {
//         static void Main()
//         {
//             AbstractBase obj = new Derived();
//             obj.AbstractMethodA();
//             obj.PublicMethodA();
//         }
//     }
//     #endregion
// }
