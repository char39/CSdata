using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07_01NETCORE_Jumbo
{
    internal class SomeClass
    {
        int SomeValue = 10;
        public ref int SomeMethod()
        {
            return ref SomeValue;
        }
    }
}
