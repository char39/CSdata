// namespace Csharp07_11NETCORE
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             // 1. 변수 할당
//             // 2. 분해 (Deconstruction)

//             var tuple = (123, 456);
//             Console.WriteLine($"Item1: {tuple.Item1}, Item2: {tuple.Item2}");
//             var tuple2 = (Name: "Tuan", Age: 20);
//             Console.WriteLine($"Name: {tuple2.Name}, Age: {tuple2.Age}");
            
//             var tuple3 = (Name: "엄준식", Age: 21);
//             var (name, age) = tuple3;
//             Console.WriteLine($"Name: {name}, Age: {age}");
//             var tuple4 = (Name: "엄홍길", Age: 55);
//             var (name2, _) = tuple4;                        // _ : 사용하지 않는 변수
//             Console.WriteLine($"Name: {name2}");
//             var (name3, age3) = ("DDAI", 25);
//             Console.WriteLine($"Name: {name3}, Age: {age3}");

//             var unnamed = ("SuperMan", 9999);
//             var named = (Name: "Super", Age: 99);
//             named = unnamed;
//             Console.WriteLine($"Name: {named.Name}, Age: {named.Age}");
            
//         }
//     }
// }
