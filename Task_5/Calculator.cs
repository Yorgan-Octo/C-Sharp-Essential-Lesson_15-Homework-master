using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Calculator : Arhemetics
    {
        public double Add(double operand1, double operand2) => operand1 + operand2;
        public double Sum(double operand1, double operand2) => operand1 - operand2;
        public double Mul(double operand1, double operand2) => operand1 * operand2;
        public double? Div(double operand1, double operand2)
        {
            double? sum = default;
            try
            {
                //цеif  щоб обійти Infinity() и double.NaN бо в тако випадку воно ігнорувалло catch і повертало NaN
                if (operand1 != 0 && operand2 != 0) 
                    sum = operand1 / operand2;
                else
                    throw new DivideByZeroException("На нуль ділити не можна! Спробуйте ще раз!");
            }
            catch (DivideByZeroException ex)
            {
                sum = null;
                UserInterface.ShowError(ex.Message);
            }

            return sum;

        }
    }
}
