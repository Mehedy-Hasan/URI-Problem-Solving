//using System;
//using System.IO;
//using System.Linq;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] input = Console.ReadLine().Split(' ');
//            int a = int.Parse(input[0]);
//            int b = int.Parse(input[1]);
//            int c = int.Parse(input[2]);

//            int[] intArray = new int[] { a, b, c };
//            int[] sortedArray = intArray.OrderBy(x => x).ToArray();

//            foreach (var item in sortedArray)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine();

//            foreach (var item in intArray)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
