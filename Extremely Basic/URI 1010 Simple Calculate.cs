//using System;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int productCode1, unitOfProduct1, productCode2, unitOfProduct2;
//            double price1, price2, res;

//            string line = Console.ReadLine();
//            string[] tokens = line.Split(' ');
//            productCode1 = int.Parse(tokens[0]);
//            unitOfProduct1 = int.Parse(tokens[1]);
//            price1 = double.Parse(tokens[2]);

//            string line2 = Console.ReadLine();
//            string[] tokens2 = line2.Split(' ');
//            productCode2 = int.Parse(tokens2[0]);
//            unitOfProduct2 = int.Parse(tokens2[1]);
//            price2 = double.Parse(tokens2[2]);


//            res = (unitOfProduct1 * price1)+ (unitOfProduct2 * price2);


//            Console.WriteLine("VALOR A PAGAR: R$ " + res.ToString("0.00"));
//        }
//    }
//}
