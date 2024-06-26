using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp06_26NETCORE
{
    internal class BuiltInStruct
    {
        static void Main(string[] args)
        {
            //시간 차 (D-Day)구하기 : TimeSpan 구조체
            TimeSpan Dday = Convert.ToDateTime("2024-12-25") - DateTime.Now;
            Console.WriteLine($"{DateTime.Now.Year}년도 크리스마스는 {(int)Dday.TotalDays}일 남음");

            //지난 시간 구하기
            TimeSpan times = DateTime.Now - Convert.ToDateTime("2000-08-03");
            Console.WriteLine($"내가 지금까지 며칠 살았나 : {(int)times.TotalDays}");
        }
    }
}
