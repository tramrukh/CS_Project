using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstnumber, double argSecondnumber)
        {
            double result;
            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstnumber + argSecondnumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstnumber - argSecondnumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstnumber + argSecondnumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstnumber + argSecondnumber;
                    break;
                default:
                    throw new InvalidOperationException("Not a valid operation");

            }
            return result;
        }
    }
}
