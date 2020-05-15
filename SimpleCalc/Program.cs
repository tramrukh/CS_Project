using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputconverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputconverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputconverter.ConvertInputToNumeric(Console.ReadLine());
                string opertation = Console.ReadLine();

                double result = calculatorEngine.Calculate(opertation, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
