using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        public int firstNumber;
        public int secondNumber;
        

        public string Sum() {
            int addResult = firstNumber + secondNumber;
            return addResult.ToString();
        }

        public string Subs()
        {
            int subsResult = firstNumber - secondNumber;
            return subsResult.ToString();
        }

        public string Multiply()
        {
            int multiResult = firstNumber * secondNumber;
            return multiResult.ToString();
        }

        public string Divide()
        {
            int divideResult = firstNumber / secondNumber;
            return divideResult.ToString();
        }
    }
}
