using System;
using System.Linq;

namespace Csharp08_28NETCORE
{
    /*  문제 1번 LinQ 그룹 활용
    class Profile
    {
        public string? Name { get; set; }
        public int Height { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)     // 175 미만과 175 이상으로 구분해서 출력 하기
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            var sort = from profile in arrProfile
                       orderby profile.Height
                       group profile by profile.Height < 175 into g
                       select new { GroupKey = g.Key, Profiles = g };

            foreach (var s in sort)
            {
                Console.WriteLine($"- 175cm 미만인가 : {s.GroupKey}");
                foreach (var h in s.Profiles)
                    Console.WriteLine($">>> {h.Name}, {h.Height}");
            }
        }
    } */
    /*  문제 2번 LinQ 내부 조인
    class Profile
    {
        public string? Name { get; set; }
        public required int Height { get; set; }
    }
    class Product
    {
        public string? Title { get; set; }
        public string? StarName { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Profile[] profiles =
            [
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171}
            ];
            Product[] products =
            [
                new Product(){Title = "비트", StarName = "정우성"},
                new Product(){Title = "CF 다수", StarName = "김태희"},
                new Product(){Title = "아이리스", StarName = "김태희"},
                new Product(){Title = "모래시계", StarName = "고현정"}
            ];

            var listProfile = from profile in profiles
                              join product in products on profile.Name equals product.StarName
                              select new
                              {
                                  Name = profile.Name,
                                  Title = product.Title,
                                  Height = profile.Height
                              };

            Console.WriteLine("---내부 Join 결과---");
            foreach (var list in listProfile)
                Console.WriteLine($"이름 : {list.Name}, 작품 : {list.Title}, 키 : {list.Height}cm");
        }
    }*/
    /*  문제 3번 LinQ 외부 조인
    class Profile
    {
        public string? Name { get; set; }
        public required int Height { get; set; }
    }
    class Product
    {
        public string? Title { get; set; }
        public string? StarName { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Profile[] profiles =
            [
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171}
            ];
            Product[] products =
            [
                new Product(){Title = "비트", StarName = "정우성"},
                new Product(){Title = "CF 다수", StarName = "김태희"},
                new Product(){Title = "아이리스", StarName = "김태희"},
                new Product(){Title = "모래시계", StarName = "고현정"},
                new Product(){Title = "Solo 예찬", StarName = "이문세"}
            ];

            var listProfile = from profile in profiles
                              join product in products on profile.Name equals product.StarName
                              into ps
                              from product in ps.DefaultIfEmpty(new Product(){Title = "그런 건 없다"})
                              select new
                              {
                                  Name = profile.Name,
                                  Title = product.Title,
                                  Height = profile.Height
                              };

            Console.WriteLine("---외부 Join 결과---");
            foreach (var list in listProfile)
                Console.WriteLine($"이름 : {list.Name}, 작품 : {list.Title}, 키 : {list.Height}cm");
        }
    }*/
    //  문제 4번 LinQ 그룹 활용
    class Profile
    {
        public string? Name { get; set; }
        public required int Height { get; set; }
    }
    class Product
    {
        public string? Title { get; set; }
        public string? StarName { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Profile[] profiles =
            [
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171}
            ];

            var listProfile = from profile in profiles
                                group profile by profile.Height >= 175 into gr
                                select new
                                {
                                    Group = gr.Key == true ? "175이상" : "175미만",
                                    Count = gr.Count(),
                                    Max = gr.Max(profile => profile.Height),
                                    Min = gr.Min(profile => profile.Height),
                                    Average = gr.Average(profile => profile.Height)
                                };

            foreach (var list in listProfile)
                Console.WriteLine($"{list.Group} - Count : {list.Count}, Max : {list.Max}, Min : {list.Min}, Average : {list.Average}");
        }
    }
}