using System;

namespace LabExercise
{
    public class MyCalc
    {
        public static  double Add (double op1, double op2)
        {
            return op1 + op2;
           
        }
        public static  double Sub (double op1, double op2)
        {
            return op1 - op2;
           
        }
        public static  double Mul (double op1, double op2)
        {
            return op1 * op2 ;
        }
        public static  double  Div (double op1, double op2)
        {
            return op1 / op2 ;
        }
        public static  int  Pow (int n1, int n2)
        {
            int n3 = n1;
            for (int i=1; i<n2; i++)
            {
                n3 = n3 * n1;
            }
            return n3;
        }
    }
}
