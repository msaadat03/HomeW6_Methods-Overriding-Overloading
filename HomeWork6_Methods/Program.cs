using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Test1(13);
            Test2(8, 4);
            Test3(3, 7);
            Test4(1, 5, 7, 8, 10);
            Test5(1, 5, 7, 8, 10);

        }


    //    //3-ə və 7-ə bölünüb-bölünməməsini tapın
    //    static void Test1(int n)
    //    {
    //        if (n % 3 == 0 && n % 7 == 0)
    //            Console.WriteLine("divisible");
    //        else
    //            Console.WriteLine("not divisible");

    //    }



    //    //n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın
    //    static void Test2(int n, int m)
    //    {
    //        var sum = n + m;
    //        if (n % 2 == 0 && m % 2 == 0)
    //            Console.WriteLine(sum);
    //        else
    //            Console.WriteLine("not even number");

    //    }


    //    //Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin
    //    static void Test3(int n, int m)
    //    {
    //        int sum = 0;
    //        if (n < m)
    //        {
    //            for (int i = n; i <= m; i++)
    //            {
    //                if (i % 2 == 1)
    //                    sum += i;
    //            }
    //            Console.WriteLine("sum");
    //        }
    //        else

    //            Console.Write("invalid");
    //    }




    //    tek ededlerin cemini tapin
    //        static void Test4(int[] arr)
    //        {
    //            int sum = 0;
    //            for (int i = 0; i < arr.Length; i++)
    //            {
    //                if (i % 2 != 0)
    //                    sum += arr[i];
    //            }

    //            Console.WriteLine(sum);
    //        }



    //    cut ededlerin sayini tapin
    //    static void Test5(int[] arr)
    //    {
    //        int count = 0;
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            if (i % 2 == 0)
    //                count += arr[i];
    //        }

    //        Console.WriteLine(count);
    //    }
    //}
    //}
    
  


