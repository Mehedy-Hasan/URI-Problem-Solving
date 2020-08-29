//using System;
//using System.Security;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double value = Convert.ToDouble(Console.ReadLine());
//            double doubleToInteger = (value * 100);
//            int valueInInteger = Convert.ToInt32(doubleToInteger);

//            Console.WriteLine("NOTAS:");

//            Console.WriteLine((valueInInteger / (100 * 100)) + " nota(s) de R$ 100.00");
//            int aux = (valueInInteger % (100 * 100));

//            Console.WriteLine((aux / (50 * 100)) + " nota(s) de R$ 50.00");
//            aux = (aux % (50 * 100));

//            Console.WriteLine(aux / (20 * 100) + " nota(s) de R$ 20.00");
//            aux = (aux % (20 * 100));

//            Console.WriteLine(aux / (10 * 100) + " nota(s) de R$ 10.00");
//            aux = (aux % (10 * 100));

//            Console.WriteLine(aux / (5 * 100) + " nota(s) de R$ 5.00");
//            aux = (aux % (5 * 100));

//            Console.WriteLine(aux / (2 * 100) + " nota(s) de R$ 2.00");
//            aux = (aux % (2 * 100));

//            Console.WriteLine("MOEDAS:");

//            Console.WriteLine((aux / 100).ToString("0") + " moeda(s) de R$ 1.00");
//            aux = aux % 100;

//            Console.WriteLine((aux / 50).ToString("0") + " moeda(s) de R$ 0.50");
//            aux = aux % 50;

//            Console.WriteLine((aux / 25).ToString("0") + " moeda(s) de R$ 0.25");
//            aux = aux % 25;

//            Console.WriteLine((aux / 10).ToString("0") + " moeda(s) de R$ 0.10");
//            aux = aux % 10;

//            Console.WriteLine((aux / 05).ToString("0") + " moeda(s) de R$ 0.05");
//            aux = aux % 05;

//            Console.WriteLine((aux / 01).ToString("0") + " moeda(s) de R$ 0.01");
//            aux = aux % 01;

//        }
//    }
//}
