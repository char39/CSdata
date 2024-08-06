using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp08_06NETCORE
{
    /*  LinQ (1)
        internal class Program
        {
            // static int Add(int a, int b)
            // {
            //     return a + b;
            // }
            static int Add(int a, int b) => a + b;

            static void Main()
            {
                Func<int, int, int> add = (a, b) => a + b;
                Console.WriteLine(Add(5, 3));
                Console.WriteLine(add(5, 5));
            }
        } */
    /*  LinQ (2)
    class Profile
    {
        public string? Name { get; set; }
        public int Weight { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Profile[] heightStat =
            {
                new Profile() {Name = "Cinnamon", Weight = 55},
                new Profile() {Name = "Vanilla", Weight = 60},
                new Profile() {Name = "Chocolate", Weight = 70},
                new Profile() {Name = "Strawberry", Weight = 65},
                new Profile() {Name = "Banana", Weight = 50},
                new Profile() {Name = "Apple", Weight = 40},
                new Profile() {Name = "Orange", Weight = 45},
                new Profile() {Name = "Grape", Weight = 55},
            };

            var select = from profile in heightStat
                            where profile.Weight >= 60
                            orderby profile.Weight descending
                            select new
                            {
                                Name = profile.Name,
                                Kg = profile.Weight,
                            };

            Console.WriteLine();
            foreach (var prof in select)
            {
                Console.Write($"Name : {prof.Name}".PadRight(20));
                Console.WriteLine($"Weight : {prof.Kg}kg");
            }

            
        }
    } */
    /*  // 175 이상과 175 이하도 같이 출력되게 하여라
    class Profile
    {
        public string? Name { get; set; }
        public int Height { get; set; }
    }
    class Profile2
    {
        public string? Name { get; set; }
        public int Weight { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성",Height =186},
                new Profile(){Name="우영우",Height =166},
                new Profile(){Name="주현영",Height =170},
                new Profile(){Name="하하 ",Height =171},
                new Profile(){Name="이정재",Height =182},
                new Profile(){Name="이수지",Height =168}
            };

            Profile2[] arrProfile2 =
            {
                new Profile2 { Name = "이문세", Weight = 88 },
                new Profile2 { Name = "비", Weight = 73 },
                new Profile2 { Name = "임창정", Weight = 70 },
                new Profile2 { Name = "주현영", Weight = 58 },
                new Profile2 { Name = "고은영", Weight = 55 },
                new Profile2 { Name = "이동훈", Weight = 66 }
            };

            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "175미만" : "175이상",
                                 Count = g.Count(),
                                 Max = g.Max(profile => profile.Height),
                                 Min = g.Min(profile => profile.Height),
                                 Average = g.Average(profile => profile.Height),
                                 profiles = g
                             };

            foreach (var stat in heightStat)
            {
                Console.Write($"{stat.Group} => Count : {stat.Count}, Max : {stat.Max}, ");
                Console.WriteLine($"Min : {stat.Min}, Average : {stat.Average}");
            }

            foreach (var group in heightStat)
            {
                Console.WriteLine($"조건 : {group.Group}");
                foreach (var pro in group.profiles)
                    Console.WriteLine($"    {pro.Name} - {pro.Height}cm");
            }



            var weightStat = from profile in arrProfile2
                             group profile by profile.Weight < 70 into w
                             select new
                             {
                                 Group = w.Key == true ? "70미만" : "70이상",
                                 Count = w.Count(),
                                 Max = w.Max(profile => profile.Weight),
                                 Min = w.Min(profile => profile.Weight),
                                 Average = w.Average(profile => profile.Weight),
                                 profiles = w
                             };
            foreach (var stat in weightStat)
            {
                Console.Write($"{stat.Group} => Count : {stat.Count}, Max : {stat.Max}, ");
                Console.WriteLine($"Min : {stat.Min}, Average : {stat.Average}");
            }

            foreach (var group in weightStat)
            {
                Console.WriteLine($"조건 : {group.Group}");
                foreach (var pro in group.profiles)
                    Console.WriteLine($"    {pro.Name} - {pro.Weight}kg");
            }

        }
    } */
    /*  LinQ (3) 고난이도
    public class Class_
    {
        public required string Name { get; set; }
        public required int[] Score { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Class_[] arrClass =
            {
                new Class_() { Name = "연두반", Score = new int[]{ 99, 80, 70, 24 } },
                new Class_() { Name = "분홍반", Score = new int[]{ 60, 45, 47, 87 } },
                new Class_() { Name = "파랑반", Score = new int[]{ 92, 30, 85, 94 } },
                new Class_() { Name = "노랑반", Score = new int[]{ 90, 88, 0, 17 } }
            };

            // var classes =   from c in arrClass              // c = arrClass
            //                 from s in c.Score               // s = c.Score
            //                 where s < 60                    // s < 60
            //                 orderby s ascending             // s 오름차순
            //                 select new                      // 새로운 객체 생성
            //                 {
            //                     c.Name, Lowest = s          // c.Name, Lowest = s
            //                 };
            
            // foreach (var stu in classes)
            //     Console.WriteLine($"낙제 : {stu.Name} ({stu.Lowest})"); 

            var classesSort =   from c in arrClass
                                from s in c.Score
                                where s >= 60
                                orderby c.Name ascending, s descending
                                select new
                                {
                                    c.Name,
                                    Score = s,
                                    Count = c.Score.Count(),
                                    Max = c.Score.Max(),
                                    Min = c.Score.Min(),
                                    Average = c.Score.Average(),

                                };
            foreach (var item in classesSort)
                Console.WriteLine($"Class: {item.Name}, Score: {item.Score}, Count: {item.Count}, Max: {item.Max}, Min: {item.Min}, Average: {item.Average}");

            var scores = arrClass
            .SelectMany(c => c.Score)
            .Where(score => score >= 60 && score < 100)
            .ToArray();

            var count = scores.Count();
            var average = scores.Average();
            var max = scores.Max();
            var min = scores.Min();

            Console.WriteLine($"60 ~ 100점의 개수 : {count}");
            Console.WriteLine($"평균 : {average}");
            Console.WriteLine($"최고점 : {max}");
            Console.WriteLine($"최저점 : {min}");

        }
    }*/
    /*  LinQ (4) 표준 연산자
    class Profile
    {
        public required string Name { get; set; }
        public required int Height { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "우영우", Height = 166 },
                new Profile() { Name = "주현영", Height = 170 },
                new Profile() { Name = "하하 ", Height = 171 },
                new Profile() { Name = "이정재", Height = 182 },
                new Profile() { Name = "이수지", Height = 168 }
            };
            // LinQ 표준 연산자로 원하는 값들을 추출

            var profile = arrProfile                    // arrProfile 배열에서
            .Where(profile => profile.Height < 175)     // Height가 175보다 작은 값들을
            .OrderBy(profile => profile.Height)         // Height를 오름차순으로 정렬
            .Select(profile =>                          // 새로운 객체를 생성
            new
            {
                Name = profile.Name,                        // Name
                InchHeight = profile.Height * 0.393         // Height를 인치로 변환
            });

            foreach (var pro in arrProfile)
            {
                Console.Write($"Name : {pro.Name}");
                Console.WriteLine($"Height : {pro.Height}");
            }
        }
    } */
    /*  LinQ (5) 내 외부 join
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
            Profile[] arrProfile =
            [
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "우영우", Height = 166 },
                new Profile() { Name = "주현영", Height = 170 },
                new Profile() { Name = "하하", Height = 171 },
                new Profile() { Name = "이정재", Height = 182 },
                new Profile() { Name = "이수지", Height = 168 }
            ];
            Product[] arrProduct =
            [
                new Product() { Title = "비트", StarName = "정우성" },
                new Product() { Title = "이상한변호사", StarName = "우영우" },
                new Product() { Title = "이상한변호사", StarName = "주현영" },      // 주현영 1
                new Product() { Title = "SNL", StarName = "주현영" },           // 주현영 2
                new Product() { Title = "오징어게임", StarName = "이정재" },
                new Product() { Title = "개그콘서트", StarName = "이수지" }
            ];

            var listProfile =   from profile in arrProfile                                              // arrProfile 배열에서
                                join product in arrProduct on profile.Name equals product.StarName      // profile.Name과 product.StarName이 같은 것을
                                select new                                                              // 새로운 객체를 생성
                                {
                                    Name = profile.Name, Work = product.Title, Height = profile.Height
                                };
            Console.WriteLine($"\nLinQ 내부 join 결과");
            foreach (var profile in listProfile)
            {
                Console.Write("이름 : "); Console.Write($"{profile.Name}   ");
                Console.Write("작품 : "); Console.Write($"{profile.Work}   ");
                Console.Write("키 : "); Console.WriteLine($"{profile.Height}   ");
            }



            listProfile = from profile in arrProfile
                          join product in arrProduct on profile.Name equals product.StarName
                          into ps
                          from product in ps.DefaultIfEmpty(new Product() {Title = "그런건 없다."})
                          select new
                          {
                              Name = profile.Name, Work = product.Title, Height = profile.Height
                          };
            Console.WriteLine($"\nLinQ 외부 join 결과");
            foreach (var profile in listProfile)
            {
                Console.Write("이름 : "); Console.Write($"{profile.Name}   ");
                Console.Write("작품 : "); Console.Write($"{profile.Work}   ");
                Console.Write("키 : "); Console.WriteLine($"{profile.Height}   ");
            }


        }
    } */

    public class Student
    {
        public string? name { get; set; }
        public int score { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { name = "zzz", score = 88},
                new Student { name = "kim", score = 50},
                new Student { name = "han", score = 76 },
                new Student { name = "park", score = 45 },
                new Student { name = "peter", score = 84 },
                new Student { name = "lee", score = 98 }
            };

            var sortName =  from student in students
                            where student.score >= 60
                            orderby student.name ascending
                            select student.name;
            
            foreach (var name in sortName)
                Console.WriteLine($"Name : {name}");

            var sort =  from student in students
                        group student by student.score >= 60 into g
                        select new
                        {
                            Group = g.Key == true ? "60점 이상" : "60점 미만",
                            Max = g.Max(student => student.score),
                            Min = g.Min(student => student.score),
                            Average = g.Average(student => student.score),
                            students = g
                        };

            foreach (var s in sort)
            {
                Console.Write($"   {s.Group}   Max : {s.Max}   Min : {s.Min}   Average : {s.Average}\n"); 
            }
        }
    }


}