using System;

namespace Extremely_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startday = Console.ReadLine().Split(' ');
            string[] startTime = Console.ReadLine().Split(' ');
            int startHour = int.Parse(startTime[0]);
            int startMinute = int.Parse(startTime[2]);
            int startSecond = int.Parse(startTime[4]);

            string[] endDay = Console.ReadLine().Split(' ');
            string[] endTime = Console.ReadLine().Split(' ');
            int endHour = int.Parse(endTime[0]);
            int endMinute = int.Parse(endTime[2]);
            int endSecond = int.Parse(endTime[4]);

            int startDurationSecond = startSecond + startMinute * 60 + startHour * 60 * 60 + int.Parse(startday[1]) * 24 * 60 * 60;
            int endDurationSecond = endSecond + endMinute * 60 + endHour * 60 * 60 + int.Parse(endDay[1]) * 24 * 60 * 60;

            int data = endDurationSecond - startDurationSecond;

            int durationDay = data / (24 * 60 * 60);
            int durationHour = (data - durationDay * 24 * 60 * 60) / (60 * 60);
            int durationMinute = (data - durationDay * 24 * 60 * 60 - durationHour * 60 * 60) / 60;
            int durationSecond = data - durationDay * 24 * 60 * 60 - durationHour * 60 * 60 - durationMinute * 60;

            Console.WriteLine(durationDay + " dia(s)");
            Console.WriteLine(durationHour + " hora(s)");
            Console.WriteLine(durationMinute + " minuto(s)");
            Console.WriteLine(durationSecond + " segundo(s)");
        }
    }
}
