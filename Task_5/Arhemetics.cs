using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public interface Arhemetics
    {
        //простодля практики 
        double Add(double operand1, double operand2);
        double Sum(double operand1, double operand2);
        double Mul(double operand1, double operand2);
        double? Div(double operand1, double operand2);
    }
}
