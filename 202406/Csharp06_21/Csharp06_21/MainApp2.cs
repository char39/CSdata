using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YonIT;

namespace Csharp06_21
{
    internal class MainApp2
    {
        public static int Main(string[] args)
        {
            Calculator calculator = new Calculator(); // < new 동적 할당
            // 이렇게 선언해야 YonIT.Calculator 안의 함수들 사용가능
            Console.WriteLine("Add 함수 호출과 반환 : {0}", calculator.Add(3, 4));     
                        //동적(방금) 할당 < 자주 사용 안하는거에 메모리 아끼기 좋고
            Console.WriteLine("Multi 함수 호출과 반환 : {0}", Calculator.Multi(3, 4)); 
                        //정적(미리) 할당 < 자주 사용되는거에 좋음

            return 0;   // 0일때 이상없이 되었고, 그 이외의 값은 이상이 있다라고 약속됨. 다만 출력에 이상은 없으나 확인용.
        }
    }
}
