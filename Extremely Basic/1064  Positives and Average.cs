//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double numberOne = double.Parse(Console.ReadLine());
//            double numberTwo = double.Parse(Console.ReadLine());
//            double numberThree = double.Parse(Console.ReadLine());
//            double numberFour = double.Parse(Console.ReadLine());
//            double numberFive = double.Parse(Console.ReadLine());
//            double numberSix = double.Parse(Console.ReadLine());

//            double[] convertToArray = new double[] { numberOne, numberTwo, numberThree, numberFour, numberFive, numberSix };

//            double sumOfPositiveNumber = 0;
//            int flag = 0;
//            foreach (var item in convertToArray)
//            {
//                if (item>=0)
//                {
//                    sumOfPositiveNumber += item;
//                    flag++;
//                }
//            }
//            double average = sumOfPositiveNumber / flag;
//            Console.WriteLine(flag + " valores positivos");
//            Console.WriteLine(average.ToString("0.0"));
//        }
//    }
//}
