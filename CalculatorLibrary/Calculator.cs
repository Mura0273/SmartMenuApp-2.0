using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {

        public static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }
        public static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }
        public static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }
        public static double Sum(double[] numbers)
        {
            int i;
            double sumNumbers;
            sumNumbers = 0;
            for (i = 0; i < numbers.Length; i++)
            {
                // Kan ændres til sumInts += ints[i], men det kan Allan ikke lide,
                // så det kan vi heller ikke lide.
                // han kan heller ikke rigtigt lide kommentarer, så vi må nok hellere slette det her
                sumNumbers = sumNumbers + numbers[i];
            }
            return sumNumbers;
        }
        public static double Minimum(double[] numbers)
        {
            int i;
            double minNumbers;
            minNumbers = numbers[0];
            for (i = 0; i < numbers.Length; i = i + 1)
            {
                if (numbers[i] < minNumbers)
                {
                    minNumbers = numbers[i];
                }
            }
            return minNumbers;
        }
        public static double Maximum(double[] numbers)
        {
            int i;
            double maxNumbers;
            maxNumbers = numbers[0];
            for (i = 0; i < numbers.Length; i = i + 1)
            {
                if (numbers[i] > maxNumbers)
                {
                    maxNumbers = numbers[i];
                }
            }
            return maxNumbers;
        }
        public static double Average(double[] numbers)
        {
            int i;
            double avgNumbers;
            avgNumbers = 0;
            for (i = 0; i < numbers.Length; i++)
            {
                avgNumbers = avgNumbers + numbers[i];
            }
            avgNumbers = avgNumbers / numbers.Length;
            return avgNumbers;
        }
    }
}
