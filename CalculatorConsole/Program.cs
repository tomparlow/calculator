using System;
using System.ComponentModel.DataAnnotations;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("Enter two numbers!");

            while (true)
            {
                var input = Console.ReadLine();
                var numbers = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var result = calculator.Addition(Convert.ToDouble(numbers[0]), Convert.ToDouble(numbers[1]));
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
