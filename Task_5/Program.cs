using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                Console.Clear();

                double namber1 = UserInterface.InNumData("Введіть число 1: ");
                string mathOperato = UserInterface.InMathOperator();
                double namber2 = UserInterface.InNumData("Введіть число 2: ");

                double? resalt = mathOperato switch
                {
                    "+" => calculator.Add(namber1, namber2),
                    "-" => calculator.Sum(namber1, namber2),
                    "*" => calculator.Mul(namber1, namber2),
                    "/" => calculator.Div(namber1, namber2),
                    _ => double.NaN
                };

                if (resalt != null)
                {
                    Console.Clear();
                    Console.WriteLine($"Результат: {namber1} {mathOperato} {namber2} = {resalt}");
                }

                Console.ReadKey();
            }
        }
    }
}
