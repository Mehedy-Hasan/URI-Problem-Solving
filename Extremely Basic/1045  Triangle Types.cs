//using System;
//using System.Linq;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] input = Console.ReadLine().Split(' ');

//            double A = double.Parse(input[0]);
//            double B = double.Parse(input[1]);
//            double C = double.Parse(input[2]);

//            double[] Order = new[] { A, B, C };
//            var orderByDesc = Order.OrderByDescending(x => x).ToArray();

//            A = orderByDesc[0];
//            B = orderByDesc[1];
//            C = orderByDesc[2];

//            if (A >= B + C) Console.WriteLine("NAO FORMA TRIANGULO");

//            else
//            {
//                if ((A * A) == (B * B) + (C * C)) Console.WriteLine("TRIANGULO RETANGULO");

//                if ((A * A) > (B * B) + (C * C)) Console.WriteLine("TRIANGULO OBTUSANGULO");

//                if ((A * A) < (B * B) + (C * C)) Console.WriteLine("TRIANGULO ACUTANGULO");

//                if (A == B && B == C && C == A && B == A && A == C) Console.WriteLine("TRIANGULO EQUILATERO");

//                if (A == B && B != C || B == C && B != A || C == A && A != B || B == A && A != C || A == C && C != B) Console.WriteLine("TRIANGULO ISOSCELES");
//            }

//            Console.ReadKey();
//        }
//    }
//}
