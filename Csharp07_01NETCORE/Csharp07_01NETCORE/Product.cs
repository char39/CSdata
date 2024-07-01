using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07_01NETCORE_Info
{
    internal class Product
    {
        private int price = 100;
        // public 함수에서 private 클래스 변수를 읽을수는 있으나 수정은 불가
        public ref int GetPrice()
        {
            return ref price;
        }
        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }
}
