using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Csharp06_21
//{
    //internal class Program
    //{
        //static void Main(string[] args)
        //{
            // 배열은 메모리 동적 할당. 나중에 안쓰는것으로 판단되면 가비지컬렉터가 수거해감.
            #region 배열

            //int[] intArray;
            //intArray = new int[3];
            //intArray[0] = 1;
            //intArray[1] = 2;
            //intArray[2] = 3;

            ////for (int i = 0; i < intArray.Length; i++) // 원하는 배열 부분이나 전체 를 알 수 있음
            //{
            //    Console.WriteLine($"{i}번째 Index = {intArray[i]}");
            //}
            //foreach (int intValue in intArray)        // 배열 전체를 반복
            //{
            //    Console.WriteLine($"{intValue}");
            //}


            ////요소 개수 생략 가능. 생략하면 뒤에서 지정한 요소 개수만큼 자동생성.
            //var intArray = new int[] { 1, 2, 3 };
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine($"{i}번째 Index = {intArray[i]}");
            //}
            //foreach (int intValue in intArray)
            //{
            //    Console.WriteLine($"{intValue}");
            //}


            ////new 키워드와 int[] 생략하고 바로 초기화 가능.
            //int[] intArray = { 1, 2, 3 };
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine($"{i}번째 Index = {intArray[i]}");
            //}
            //foreach (int intValue in intArray)
            //{
            //    Console.WriteLine($"{intValue}");
            //}


            ////배열 인덱스
            //int[] arr = { 1, 2, 3 };

            //int index = 0;
            //Console.WriteLine(arr[index++]);
            //Console.WriteLine(arr[index++]);
            //Console.WriteLine(arr[index++]);
            //Console.WriteLine(arr[--index]);
            //Console.WriteLine(arr[--index]);
            //Console.WriteLine(arr[--index]);


            //int[] kor = new int[3];
            //int sum = 0;
            //float avg = 0;

            //Console.Write($"입력 : ");    kor[0] = Int32.Parse(Console.ReadLine());
            //Console.Write($"입력 : ");    kor[1] = Int32.Parse(Console.ReadLine());
            //Console.Write($"입력 : ");    kor[2] = Int32.Parse(Console.ReadLine());

            //sum = kor[0] + kor[1] + kor[2];
            //avg = sum / (float)3.0;

            //Console.WriteLine($"총점 : {sum}, 평균 : {avg:0.##}");


            //float[] arrf = { 10.5f, 20.1f, 30.2f };
            //float sum = 0.0f;
            //foreach (float f in arrf)
            //{
            //    sum += f;
            //}
            //Console.WriteLine($"{sum}");

            //decimal[] arrd = { 10.5m, 20.1m, 30.2m };
            //decimal sumd = 0.0m;
            //foreach (decimal f in arrd)
            //{
            //    sumd += f;
            //}
            //Console.WriteLine($"{sumd}");

            //bool isCorrect = ((decimal)sum == sumd);
            //Console.WriteLine(isCorrect); // ????



            #endregion
            #region 다차원 배열

            //int[] arr1 = new int[2];
            //int[,] arr2 = new int[2, 2];
            //int[,,] arr3 = new int[2, 2, 2];


            //char[,] arr = new char[2, 2];
            //arr[0, 0] = 'A';
            //arr[0, 1] = 'B';
            //arr[1, 0] = 'C';
            //arr[1, 1] = 'D';

            //int num = 65; //a 아스키코드
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        arr[i, j] = Convert.ToChar(num); num++;
            //    }

            //}

            //Console.WriteLine($"{arr[0, 0]}, {arr[0, 1]}");
            //Console.WriteLine($"{arr[1, 0]}, {arr[1, 1]}");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write($"{arr[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


            //int[,] intArr = new int[2, 3];
            //for (int i = 0; i < intArr.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < intArr.GetLength(1); j++)
            //    {
            //        intArr[i, j] = Convert.ToInt32(ReadLine());
            //    }
            //}
            //for (int i = 0; i < intArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < intArr.GetLength(1); j++)
            //    {
            //        Write($"{intArr[i, j]} ");
            //    }
            //    WriteLine();
            //}


            //int[,] intArr1 = new int[,]
            //{   { 1, 2, 3 },
            //    { 4, 5, 6 } };//for
            //int[,] intArr2 = new int[2, 3]
            //{   { 1, 2, 3 },
            //    { 4, 5, 6 } };//foreach
            //int[,] intArr3 =
            //{   { 1, 2, 3 },
            //    { 4, 5, 6 } };//foreach

            //for (int i = 0; i < 2; i++)
            //{
            //    Write("(");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Write($"{intArr1[i, j]} ");
            //    }
            //    Write(")\n");
            //}
            //foreach (int i in intArr2)
            //{
            //    Write($"{i}");
            //}


            //int[,] intArr = new int[3, 3];
            //for (int i = 0; i < intArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < intArr.GetLength(1); j++)
            //    {
            //        if (i == j)
            //            intArr[i, j] = 1;
            //        else
            //            intArr[i, j] = 0;
            //        Write(intArr[i, j]);
            //    }WriteLine();
            //}


            //int[,] scores =
            //{
            //    { 90, 100, 0, 0 },
            //    { 80, 90, 0, 0 },
            //    { 100, 80, 0, 0 }
            //};
            //for (int i = 0; i < 3; i++)
            //{
            //    scores[i, 2] = scores[i, 0] + scores[i, 1];
            //    scores[i, 3] = scores[i, 2] / 2;
            //}
            //Console.WriteLine("국어 영어 합계 평균");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{scores[i, j],4} ");
            //    }
            //    Console.WriteLine();
            //}



            #endregion
            #region 다차원 배열[문제]


            ////1.  성적 입력 집계
            //int[,] score = new int[3, 5];
            //string[] name = new string[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"이름 : "); name[i] = Console.ReadLine();
            //    Console.WriteLine("국어, 영어 순으로 점수를 입력하세요. ");
            //    for (int j = 1; j <= 2; j++)
            //    {
            //        score[i, j] = Int32.Parse(Console.ReadLine());
            //    }
            //    score[i, 3] = score[i, 1] + score[i, 2];
            //    score[i, 4] = score[i, 3] / 2;
            //}
            //Console.WriteLine("이름 국어 영어 합계 평균");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"{name[i],4} ");
            //    for (int j = 1; j < 5; j++)
            //    {
            //        Console.Write($"{score[i, j],4} ");
            //    }
            //    Console.WriteLine();
            //}


            ////2.  구구단 배열 사용
            //int[,] gugu = new int[8, 9];
            //for (int i = 0; i < gugu.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < gugu.GetLength(1); j++)
            //    {
            //        gugu[i, j] = (i + 2) * (j + 1);
            //        Console.Write($"{gugu[i, j],3} ");
            //    }
            //    Console.WriteLine();
            //}



            #endregion
            #region 다차원 배열 [3차원]

            //string[,,] names = new string[2, 2, 2];

            //names[0, 0, 0] = "C#";
            //names[0, 0, 1] = "ASP.NET";
            //names[0, 1, 0] = "Windows Forms";
            //names[0, 1, 1] = "WPF";
            //names[1, 0, 0] = "Xamarin";
            //names[1, 0, 1] = "Unity";
            //names[1, 1, 0] = "UWP";
            //names[1, 1, 1] = "Azure";

            //Console.WriteLine("\n0층");
            //Console.WriteLine($"{names[0, 0, 0],20}, {names[0, 0, 1],20}");
            //Console.WriteLine($"{names[0, 1, 0],20}, {names[0, 1, 1],20}");
            //Console.WriteLine("\n1층");
            //Console.WriteLine($"{names[1, 0, 0],20}, {names[1, 0, 1],20}");
            //Console.WriteLine($"{names[1, 1, 0],20}, {names[1, 1, 1],20}");


            //int[,,] intArr = new int[2, 3, 4];

            //for ( int i = 0; i < intArr.GetLength(0); i++ )
            //{
            //    for ( int j = 0; j < intArr.GetLength(1); j++ )
            //    {
            //        for (int k = 0; k < intArr.GetLength(2); k++)
            //        {
            //            Console.Write($"{i}층 {j}행 {k}열 : "); intArr[i, j, k] = Int32.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //for (int i = 0; i < intArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < intArr.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < intArr.GetLength(2); k++)
            //        {
            //            Console.Write($"{intArr[i, j, k]} ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}


            //int[,,] intArr = new int[2, 2, 2];

            //for (int i = 0; i < intArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < intArr.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < intArr.GetLength(2); k++)
            //        {
            //            Console.Write($"{i}층 {j}행 {k}열 : "); intArr[i, j, k] = Int32.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //Console.WriteLine($"차수 출력 : {intArr.Rank}");
            //Console.WriteLine($"길이 출력 : {intArr.Length}");
            //for (int i = 0; i < intArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < intArr.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < intArr.GetLength(2); k++)
            //        {
            //            Console.Write($"{intArr[i, j, k]}\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region 가변 배열

            //int[][] arr = new int[2][];
            //arr[0] = new int[] { 1, 2 };
            //arr[1] = new int[] { 3, 4, 5 };
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"{arr[i][j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();




            #endregion
            #region var로 배열 선언

            //var i = 5;
            //Console.WriteLine($"i : {i}, Type : {i.GetType()}");
            //var s = "Hello";
            //Console.WriteLine($"s : {s}, Type : {s.GetType()}");

            //var numbers = new int[] { 1, 2, 3 };
            //foreach ( var number in numbers )
            //{
            //    Console.WriteLine($"Item : {number}, Type : {number.GetType()}");
            //}

            #endregion
            

        //}
    //}
//}
