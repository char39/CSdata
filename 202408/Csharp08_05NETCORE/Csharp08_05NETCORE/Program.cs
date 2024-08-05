using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp08_05NETCORE
{
    /*  LinQ가 아닌 방식
    class Profile
    {
        public string? Name { get; set; }
        public int Height { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =                                      // 배열 초기화
            {
                new Profile() {Name = "Cinnamon", Height = 170},
                new Profile() {Name = "Vanilla", Height = 160},
                new Profile() {Name = "Cocoa", Height = 180},
                new Profile() {Name = "Caramel", Height = 150},
                new Profile() {Name = "Hazel", Height = 190},
                new Profile() {Name = "Mint", Height = 200},
            };

            List<Profile> profiles = new();                             // List 생성
            foreach (Profile profile in arrProfile)                         // 배열의 요소를 List에 추가
            {
                if (profile.Height < 175)
                    profiles.Add(profile);
            }

            profiles.Sort((profile1, profile2) =>                       // List 정렬
            {
                return profile1.Height - profile2.Height;                   // 오름차순 정렬
            });

            foreach (Profile profile in profiles)                       // List 출력
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");     // 이름, 키 출력
            }
        }
    }*/
    /*  LinQ 방식
    class Profile
    {
        public string? Name { get; set; }
        public int Height { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =                                      // 배열 초기화
            {
                new Profile() {Name = "Cinnamon", Height = 170},
                new Profile() {Name = "Vanilla", Height = 160},
                new Profile() {Name = "Cocoa", Height = 180},
                new Profile() {Name = "Caramel", Height = 150},
                new Profile() {Name = "Hazel", Height = 190},
                new Profile() {Name = "Mint", Height = 200},
            };

            var profiles =  from profile in arrProfile              // 배열의 요소를 LinQ로 처리
                            where profile.Height < 175              // 175보다 작은 요소만
                            orderby profile.Height ascending        // 오름차순 정렬
                            select profile;                         // 선택

            foreach (Profile profile in profiles)                       // LinQ 출력
            {
                Console.WriteLine($"{profile.Name}, {profile.Height}");     // 이름, 키 출력
            }



            int[] numbers = { 9, 4, 6, 7, 8, 3, 5, 2, 1, 10 };
            {
                var result = from num in numbers
                             where num % 2 == 0
                             orderby num ascending
                             select num;
                foreach (int num in result)
                    Console.WriteLine(num);
            }
            {
                var result = from num in numbers
                             where num % 3 == 0
                             orderby num ascending
                             select num;
                foreach (int num in result)
                    Console.WriteLine(num);
            }

        }
    }*/
    /*  LinQ 방식 2
    class Profile
    {
        public string? Name { get; set; }
        public int Height { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =                                      // 배열 초기화
            {
                new Profile() {Name = "Cinnamon", Height = 170},
                new Profile() {Name = "Vanilla", Height = 160},
                new Profile() {Name = "Cocoa", Height = 180},
                new Profile() {Name = "Caramel", Height = 150},
                new Profile() {Name = "Hazel", Height = 190},
                new Profile() {Name = "Mint", Height = 200},
            };

            var profiles =  from profile in arrProfile              // 배열의 요소를 LinQ로 처리
                            where profile.Height < 175              // 175보다 작은 요소만
                            orderby profile.Height ascending        // 오름차순 정렬
                            select new                              // 선택
                            {
                                Name = profile.Name,
                                IncHeight = profile.Height * 0.393
                            };

            foreach (var profile in profiles)                       // LinQ 출력
            {
                Console.WriteLine($"{profile.Name}, {profile.IncHeight}");     // 이름, 키 출력
            }



        }
    }*/

    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Car[] cars = 
            {
                new Car(){Cost = 56, MaxSpeed = 120},
                new Car(){Cost = 70, MaxSpeed = 150},
                new Car(){Cost = 45, MaxSpeed = 180},
                new Car(){Cost = 32, MaxSpeed = 200},
                new Car(){Cost = 82, MaxSpeed = 280},
            };

            var selected = from car in cars
                            where car.Cost >= 50 && car.MaxSpeed >= 150
                            orderby car.Cost ascending
                            select car;
            
            foreach (Car c in selected)
                Console.WriteLine(c.Cost + ", " + c.MaxSpeed);
        }
    }

}