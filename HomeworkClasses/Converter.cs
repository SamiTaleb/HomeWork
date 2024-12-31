using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Homework1.HomeworkClasses
{
    public class Converter
    {
        public string DecimalToBinary(int decimalNumber)
        {
            if (decimalNumber == 0)
                return "0";
            if (decimalNumber == 1)
                return "1";

            return DecimalToBinary(decimalNumber / 2) + (decimalNumber % 2).ToString();
        }
    }
}
