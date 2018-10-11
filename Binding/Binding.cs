using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bindings
{
    public class Binding
    {
        public void callID(string v)
        {
            Console.WriteLine("Indtast tal: ");
            if (v == "Add" || v == "Subtract" || v == "Multiply" || v == "Divide") // Checker hvad "v" er
            {
                int.TryParse(Console.ReadLine(), out int inputOne); // Checker om ReadLine er et tal
                int.TryParse(Console.ReadLine(), out int inputTwo); // Checker om ReadLine er et tal

                Console.Write("Result: ");
                switch (v) // Checker hvad v er og kalder metoderne i CalculatorLibrary
                {
                    case "Add":
                        Console.Write(Calculator.Add(inputOne, inputTwo));
                        break;
                    case "Subtract":
                        Console.Write(Calculator.Subtract(inputOne, inputTwo));
                        break;
                    case "Multiply":
                        Console.Write(Calculator.Multiply(inputOne, inputTwo));
                        break;
                    case "Divide":
                        Console.Write(Calculator.Divide(inputOne, inputTwo));
                        break;
                }

            }
            else if(v == "Sum" || v == "Minimum" || v == "Maximum" || v == "Average")
            {
                bool checkForEmptyness = true;
                List<double> tempList = new List<double>(); // Laver en midlertidig liste
                while (checkForEmptyness)
                {
                    string line = Console.ReadLine(); // Gemmer ReadLine
                    if (line == "") // Checker om ReadLine er tom
                    {
                        checkForEmptyness = false;
                    }
                    else if(int.TryParse(line, out int input)) // Checker om line er et tal
                    {
                        tempList.Add(input); // Tilføjer line til listen
                    }
                }

                double[] doubleArray = tempList.ToArray(); // Laver vores double liste om til et double array

                switch (v) // Checker hvad v er og kalder metoderne i CalculatorLibrary
                {
                    case "Sum":
                        Console.Write("Sum: ");
                        Console.Write(Calculator.Sum(tempList.ToArray()));
                        break;
                    case "Minimum":
                        Console.Write("Minimum: ");
                        Console.Write(Calculator.Minimum(tempList.ToArray()));
                        break;
                    case "Maximum":
                        Console.Write("Maximum: ");
                        Console.Write(Calculator.Maximum(tempList.ToArray()));
                        break;
                    case "Average":
                        Console.Write("Average: ");
                        Console.Write(Calculator.Average(tempList.ToArray()));
                        break;
                }

            }
        }
    }
}