//using System;
//using System.Runtime.InteropServices;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double A, B, C;
//            string line = Console.ReadLine();
//            string[] numbers = line.Split(' ');

//            A = double.Parse(numbers[0]);
//            B = double.Parse(numbers[1]);
//            C = double.Parse(numbers[2]);

//            double traingleArea = 0.5 * A * C;
//            double circle = 3.14159 * C * C;
//            double trapezium = 0.5 * (A + B) * C;
//            double square = B * B;
//            double rectangle = A * B;

//            Console.WriteLine("TRIANGULO: " + traingleArea.ToString("0.000"));
//            Console.WriteLine("CIRCULO: " + circle.ToString("0.000"));
//            Console.WriteLine("TRAPEZIO: " + trapezium.ToString("0.000"));
//            Console.WriteLine("QUADRADO: " + square.ToString("0.000"));
//            Console.WriteLine("RETANGULO: " + rectangle.ToString("0.000"));
//            Console.ReadKey();
//        }
//    }
//}
