using System;

namespace _04._Back_In_30_Minutes_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());


            int hourInMinutes = hours * 60;
            int timeInMinuttes = hourInMinutes + minutes;

            int newTime = timeInMinuttes + 30;

            int newHour = newTime / 60;
            int newMinutes = newTime % 60;
            if (newHour > 23)
            {
                newHour = 0;
            }

            Console.WriteLine($"{newHour}:{newMinutes:d2}");

        }
    }
}
