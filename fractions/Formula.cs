using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractions
{
    class Formula
    {
        public enum OpType {
            Sum,
            Subtraction,
            Dividing,
            Multiplicaton
        }
        
        public double MathOperation(Fractions fraction1, OpType opType, Fractions fraction2)
        {
            if(opType.Equals("Sum"))
            {
                return fraction1.Sum(fraction2);
            }
            return 1.0;
        }
    }
}
