namespace Csharp08_13NETCORE
{
    internal class Null
    {
        //static void Main(string[] args)
        //{
            /*  // null 예시 1
            string? strNull = null;
            string? strEmpty = "?";

            strNull = strNull ?? "null값이 입력되어 이 문장으로 대체됩니다.";
            strEmpty = strEmpty ?? "null값이 입력되어 이 문장으로 대체됩니다.";

            Console.WriteLine();
            Console.Write(strNull + "\n" + strEmpty + "\n\n");
             */
            /*  // null 예시 2
            var result = "";
            var message = "";

            message = null;
            result = message ?? "디폴트 값";
            Console.WriteLine(result);

            message = "있는 값";
            result = message ?? "디폴트 값";
            Console.WriteLine(result);
             */
            /*  // null 예시 3
            int? value = null;
            int defaultValue = value ?? -1;
            Console.WriteLine(defaultValue);

            int? x = null;
            int y = x ?? 100;
            int z = x ?? default;
            Console.WriteLine($"y : {y}, z : {z}");

            int? x2 = null;
            int z2 = x2 ?? default;
            Console.WriteLine(z2);
            */
            /*  // null 예시 4
            bool? unknown = null;           // null
            if (unknown ?? true)            // unknown이 null이면 ??연산자는 우측 true를 반환
                Console.WriteLine("출력");      // 출력
            Console.WriteLine(unknown);     // unknown = null 출력

            unknown = false;                // false
            if (!unknown ?? false)          // !unknown이 null이 아니므로 ??연산자는 좌측 !unknown을 반환하므로 true를 반환
                Console.WriteLine("출력");      // 출력
            Console.WriteLine(unknown);     // unknown = false 출력
            */


        //}
    }
}
