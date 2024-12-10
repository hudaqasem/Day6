using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class WeeklyTemperature
    {
        private double[] temperatures = new double[7];

        public double this[int day]
        {
            get
            {
                if (day >= 0 && day < temperatures.Length)
                {
                    return temperatures[day];
                }
                else
                {
                    throw new IndexOutOfRangeException("Day must be between 0 and 6.");
                }
            }
            set
            {
                if (day >= 0 && day < temperatures.Length)
                {
                    temperatures[day] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Day must be between 0 and 6.");
                }
            }
        }

        
        public void DisplayTemperatures()
        {
            string[] days = { "Saturday", "Sunday" , "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"{days[i]}: {temperatures[i]}°C");
            }
        }
    }
}
