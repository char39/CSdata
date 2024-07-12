using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07_12NETCORE
{
    #region Test1
    // class NameCard
    // {
    //     private int age;
    //     private string name;
    //     public int Age {get; set;}
    //     public string? Name {get; set;} = "이름 없음";
    // }
    // internal class Test
    // {
    //     public static void Main()
    //     {
    //         NameCard MyCard = new NameCard()
    //         {
    //             Age = 24, Name = "박성순"
    //         };
    //         Console.WriteLine($"Age : {MyCard.Age}");
    //         Console.WriteLine($"Name : {MyCard.Name}");
    //     }
    // }
    #endregion
    #region 쪽지시험

    public class Property
    {
        private int age;
        private string name;
        public int Age {get; set;}
        public string? Name {get; set;}
    }

    internal class Test
    {
        static void Main()
        {
            Property obj = new Property() {Age = 25, Name = "박성순"};
            Console.WriteLine($"Age : {obj.Age}");
            Console.WriteLine($"Name : {obj.Name}");
        }
    }

    #endregion
}
