//using System;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double input = double.Parse(Console.ReadLine());
//            double flag;

//            if (input >= 0 && input <= 2000.00)
//            {
//                Console.WriteLine("Isento");
//            }
//            else if (input > 2000.00 && input <= 3000.00)
//            {
//                input -= 2000;
//                flag = (input * 8) / 100;
//                Console.WriteLine("R$ " + flag.ToString(("0.00")));
//            }
//            else if (input > 3000.00 && input <= 4500.00)
//            {
//                input -= 3000;
//                flag = (input * 18) / 100 + 80;
//                Console.WriteLine("R$ " + flag.ToString("0.00"));
//            }
//            else
//            {
//                input -= 4500;
//                flag = (input * 28) / 100 + 350;
//                Console.WriteLine("R$ " + flag.ToString("0.00"));
//            }
//        }
//    }
//}
