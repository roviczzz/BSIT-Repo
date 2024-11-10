using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegate_Rodriguez
{
        // Define the delegate for calculator operations
        public delegate double CalculatorOperation(double x, double y);

        public class Calculator
        {
            // Methods for different calculator operations
            public double Add(double x, double y)
            {
                return x + y;
            }

            public double Subtract(double x, double y)
            {
                return x - y;
            }

            public double Multiply(double x, double y)
            {
                return x * y;
            }

            public double Divide(double x, double y)
            {
                return y != 0 ? x / y : double.NaN; // Handle division by zero
            }
        }
        }

