using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07_09NETCORE_Test
{
    #region original
    //struct ACSetting
    //{
    //    public double currentInCelsius;
    //    public double target;

    //    public readonly double GetFahrenheit()
    //    {
    //        target = currentInCelsius * 1.8 + 32;
    //        return target;
    //    }

    //}
    //public class MainApp
    //{
    //    static void Main()
    //    {
    //        ACSetting acs;
    //        acs.currentInCelsius = 25;
    //        acs.target = 25;

    //        Console.WriteLine($"{acs.GetFahrenheit()}");
    //        Console.WriteLine($"{acs.target}");
    //    }
    //}

    #endregion
    #region just remove
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public readonly double GetFahrenheit()
        {
            return currentInCelsius * 1.8 + 32;
        }

    }
    public class MainApp
    {
        static void Main()
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
    #endregion


}
