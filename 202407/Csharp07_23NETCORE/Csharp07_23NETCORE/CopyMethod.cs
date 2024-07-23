using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp07_23NETCORE
{
    internal class CopyMethod
    {
        /* 메서드 오버로드 기존 방법
        public void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
        public void CopyArray(double[] source, double[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
        public void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        } */

        // 메서드 오버로드 없이 하는 방법
        // T는 자료형을 결정하지 않겠다라는 의미. source와 target은 동일한 자료형을 가지고 있어야 예외처리가 발생하지 않음.
        public void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }

    }
}