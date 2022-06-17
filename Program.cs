using System;
using System.Linq;

namespace CalculatorApp
{

    public class Calculator
    {
        public double Plus(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Minus(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Multi(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Divide(double a, double b)
        {
            double result = a / b;
            return result;
        }

        public double TriangleSquare(double a, double b)
        {
            double result = 0.5 * a * b;
            return result;
        }

        public double RoundSquare(double a)
        {
            double result = Math.PI * (a * a);
            return result;
        }

        public double Average(double[] array)
        {

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public double Average2(double[] array)
        {
            double sum = array.Sum();
            return sum / array.Length;
        }


        public double Min(double[] array)
        {
            double res = array.Min();
            return res;
        }

        public double Max(double[] array)
        {
            double res = array.Max();
            return res;
        }

        public double AverageSimple(double[] array)
        {
            double res = array.Average();
            return res;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
