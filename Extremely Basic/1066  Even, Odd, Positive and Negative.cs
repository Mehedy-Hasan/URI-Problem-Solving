//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int numberOne = int.Parse(Console.ReadLine());
//            int numberTwo = int.Parse(Console.ReadLine());
//            int numberThree = int.Parse(Console.ReadLine());
//            int numberFour = int.Parse(Console.ReadLine());
//            int numberFive = int.Parse(Console.ReadLine());

//            int[] convertToArray = new int[] { numberOne, numberTwo, numberThree, numberFour, numberFive };

//            int evenFlag = 0;
//            int oddFlag = 0;
//            int positiveFlag = 0;
//            int negativeFlag = 0;
//            foreach (var item in convertToArray)
//            {
//                if (item % 2 == 0)
//                {
//                    evenFlag++;
//                }
//                else
//                {
//                    oddFlag++;
//                }
//                if (item>0)
//                {
//                    positiveFlag++;
//                }
//                else
//                {
//                    if(item != 0) negativeFlag++;
//                }
               
//            }

//            Console.WriteLine(evenFlag + " valor(es) par(es)");
//            Console.WriteLine(oddFlag + " valor(es) impar(es)");
//            Console.WriteLine(positiveFlag + " valor(es) positivo(s)");
//            Console.WriteLine(negativeFlag + " valor(es) negativo(s)");

//            Console.ReadKey();
//        }
//    }
//}
