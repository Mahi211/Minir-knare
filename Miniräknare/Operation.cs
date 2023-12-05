using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare
{
    public class Operation
    {
        public int Result { get; set; } = 0;
        public int NumberOperation(int firstNumber, int secondNumber, string tecken)
        {
            if (tecken == "+")
            {

                return firstNumber + secondNumber;
            }
            else if (tecken == "-")
            {
                return firstNumber - secondNumber;
            }
            else if (tecken == "/")
            {
                return firstNumber / secondNumber;
            }
            else if (tecken == "*" || tecken == "x" || tecken == "X")
            {
                return firstNumber * secondNumber;
            }
            else
            {
                return 0;
            }
        }
    }
}
