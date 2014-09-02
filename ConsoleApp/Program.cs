using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() > 0 && args.Count() == 3)
            {
                string action = args[0].ToLower();
                double a = double.Parse(args[1]);
                double b = double.Parse(args[2]);
                double result = 0;

                switch (action)
                {
                    case "add":
                        result = add(a, b);
                        break;
                    case "subtract":
                        result = subtract(a, b);
                        break;
                    case "multiply":
                        result = multiply(a, b);
                        break;
                    case "divide":
                        result = divide(a, b);
                        break;
                    default:
                        Console.WriteLine("No action provided");
                        break;
                }

                Console.WriteLine("Action {0}: {1}", action, result);
            }
            else
                Console.WriteLine("Please pass parameters in order to compute values");
        }
        private static double add(double a, double b)
        {
            return a + b;
        }
        private static double subtract(double a, double b)
        {
            return a - b;
        }
        private static double multiply(double a, double b)
        {
            return a * b;
        }
        private static double divide(double a, double b)
        {
            if (b == 0)
                return 0;
            return a / b;
        }
    }
}