using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;  // .xlsx 포맷
using System.IO;
using NPOI.SS.Formula.Functions;


namespace Csharp08_08
{
/*  dynamic 예시
    class MyClass
    {
        public void FuncA()
        {

        }
    }

    internal class Program
    {
        static void Main()
        {
            dynamic obj = new MyClass();    // dynamic 키워드로 선언된 obj는 컴파일 시점에 MyClass의 FuncA()만 인식
            obj.FuncA();
            obj.FuncB();
        }
    } */
/*  dynamic 예시 2
    class Duck
    {
        public void Walk()
        {
            Console.WriteLine("Duck Walk");
        }
        public void Swim()
        {
            Console.WriteLine("Duck Swim");
        }
        public void Say()
        {
            Console.WriteLine("Duck Say");
        }
    }

    class Mallard : Duck {}
    class Robot
    {
        public void Walk()
        {
            Console.WriteLine("Robot Walk");
        }
        public void Swim()
        {
            Console.WriteLine("Robot Swim");
        }
        public void Say()
        {
            Console.WriteLine("Robot Say");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine();

            dynamic[] arr = [new Duck(), new Mallard(), new Robot()];
            foreach (dynamic duck in arr)
            {
                Console.WriteLine(duck.GetType());
                duck.Walk();
                duck.Swim();
                duck.Say();
                Console.WriteLine();
            }
        }
    } */
/*  dynamic 예시 3, 엑셀을 vscode에서 사용하는법

    // vscode에서 사용하는 방법
    // 상단 보기/터미널 탭을 열고, 디렉토리를 지금 cs파일의 csproj가 있는 폴더로 지정함.
    // dotnet add package NPOI    을 입력하고 엔터치고 존버하고, vscode를 전부 종료하고 재실행.
    // 설치 끝나고 빌드한번 해준뒤에 상단에 엑셀 포맷을 사용하기 위한 네임스페이스를 사용해줌.

    // using NPOI.SS.UserModel;
    // using NPOI.XSSF.UserModel;  // .xlsx 포맷

    // 그 후 아래 코드처럼 사용 가능

    internal class MainApp
    {
        public static void Oldway(string[,] data, string savePath)
        {
            // 새로운 엑셀 파일 생성
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");

            // 파일 저장
            using (FileStream fileStream = new FileStream("output.xlsx", FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fileStream);
            }

            // 데이터 설정
            for (int i = 0; i < data.GetLength(0); i++)
            {
                IRow row = sheet.CreateRow(i);
                row.CreateCell(0).SetCellValue(data[i, 0].ToString());
                row.CreateCell(1).SetCellValue(data[i, 1].ToString());
            }

            // 파일 저장
            using (FileStream fileStream = new FileStream(Path.Combine(savePath, "shpark-book-old.xlsx"), FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fileStream);
            }

            // 리소스 해제
            workbook.Close();
        }

        public static void Newway(string[,] data, string savePath)
        {
            // 새로운 엑셀 파일 생성
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");

            // 데이터 설정
            for (int i = 0; i < data.GetLength(0); i++)
            {
                IRow row = sheet.CreateRow(i);
                row.CreateCell(0).SetCellValue(data[i, 0]);
                row.CreateCell(1).SetCellValue(data[i, 1]);
            }

            // 파일 저장
            using (FileStream fileStream = new FileStream(Path.Combine(savePath, "shpark-book-dynamic.xlsx"), FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fileStream);
            }

            // 리소스 해제
            workbook.Close();
        }
        public static void Main()
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                { "유니티 버전 V.2020", "2020.07.09" },
                { "유니티 버전 V.2021", "2021.01.23" },
                { "유니티 버전 V.2022", "2022.01.07" },
                { "C sharp 8.0", "2023.04.12" },
                { "C sharp으로 서버 만들기", "2024.06.12" }
            };

            Console.WriteLine("유니티 버전 엑셀로 정리");
            Oldway(array, savePath);

            Console.WriteLine();
            
            Newway(array, savePath);
        }
    } */
/*  디렉토리 접근하여 파일 정보 불러오기
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            string directory;
            if (args.Length < 1)
                directory = ",";
            else
                directory = args[0];
            Console.WriteLine($"{directory} > directory Info");
            Console.WriteLine("- Directories : ");
            var directories = (from dir in Directory.GetDirectories(directory)
                               let info = new DirectoryInfo(dir)  // let은 LinQ에서 사용하는 변수 선언 키워드. LinQ의 var와 비슷한 역할을 함.
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes
                               }).ToList();
            
            foreach (var d in directories)
                Console.WriteLine($"{d.Name} : {d.Attributes}");

            Console.WriteLine("---Files : ");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes
                         }).ToList();

            foreach (var f in files)
                Console.WriteLine($"{f.Name} : {f.FileSize} : {f.Attributes}");

            Console.WriteLine();
        }
    } */

    internal class Program
    {
        static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type.");
            return;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage : Csharp08_08.exe<Path>[Type:File/Directory]");
                return;
            }

            string path = args[0];
            string type = "File";
            if (args.Length > 1)
                type = args[1];

            if (File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Updated   {path}   {type}");
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Created   {path}   {type}");
            }
        }
    }

}