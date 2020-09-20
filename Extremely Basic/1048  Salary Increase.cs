//using System;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double salary = double.Parse(Console.ReadLine());

//            if (salary >= 0 && salary <= 400)
//            {
//                double moneyEarned = (salary * 15) / 100.00;
//                double incrementSalary = salary + moneyEarned;

//                Console.WriteLine("Novo salario: " + incrementSalary.ToString("0.00"));
//                Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("0.00"));
//                Console.WriteLine("Em percentual: 15 %");
//            }

//            if (salary >= 400.01 && salary <= 800.00)
//            {
//                double moneyEarned = (salary * 12) / 100;
//                double incrementSalary = salary + moneyEarned;

//                Console.WriteLine("Novo salario: " + incrementSalary.ToString("0.00"));
//                Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("0.00"));
//                Console.WriteLine("Em percentual: 12 %");
//            }
//            if (salary >= 800.01 && salary <= 1200.00)
//            {
//                double moneyEarned = (salary * 10) / 100;
//                double incrementSalary = salary + moneyEarned;

//                Console.WriteLine("Novo salario: " + incrementSalary.ToString("0.00"));
//                Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("0.00"));
//                Console.WriteLine("Em percentual: 10 %");
//            }
//            if (salary >= 1200.01 && salary <= 2000.00)
//            {
//                double moneyEarned = (salary * 7) / 100;
//                double incrementSalary = salary + moneyEarned;

//                Console.WriteLine("Novo salario: " + incrementSalary.ToString("0.00"));
//                Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("0.00"));
//                Console.WriteLine("Em percentual: 7 %");
//            }
//            if (salary > 2000.00)
//            {
//                double moneyEarned = (salary * 4) / 100;
//                double incrementSalary = salary + moneyEarned;

//                Console.WriteLine("Novo salario: " + incrementSalary.ToString("0.00"));
//                Console.WriteLine("Reajuste ganho: " + moneyEarned.ToString("0.00"));
//                Console.WriteLine("Em percentual: 4 %");
//            }
//        }
//    }
//}
