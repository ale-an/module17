﻿namespace Module17
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public string GetDayOfWeek(int day)
        {
            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";

                default:
                    throw new InvalidOperationException("День недели должен быть в диапазоне 1 to 7");
            }
        }
    }
}