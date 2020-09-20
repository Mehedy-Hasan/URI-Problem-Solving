//using System;

//namespace Extremely_Basic
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] input = Console.ReadLine().Split(' ');

//            int initialHour = int.Parse(input[0]);
//            int initialMinute = int.Parse(input[1]);
//            int endHour = int.Parse(input[2]);
//            int endMinute = int.Parse(input[3]);
//            int durationHour, durationMinute;

//            if (endMinute > initialMinute)
//            {
//                durationMinute = endMinute - initialMinute;

//                if (endHour < initialHour)
//                {
//                    durationHour = (endHour + 24) - initialHour;
//                }
//                else
//                {
//                    durationHour = endHour - initialHour;
//                }

//                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", durationHour, durationMinute);
//            }

//            else if (endHour == initialHour && endMinute == initialMinute)
//            {
//                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
//            }

//            else if (endMinute < initialMinute)
//            {
//                durationMinute = (endMinute + 60) - initialMinute;
//                endHour = endHour - 1;

//                if (endHour < initialHour)
//                {
//                    durationHour = (endHour + 24) - initialHour;
//                }
//                else
//                {
//                    durationHour = endHour - initialHour;
//                }

//                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", durationHour, durationMinute);
//            }
//        }
//    }
//}
