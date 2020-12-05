using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalCalculator
{
    public class Calculator
    {
        public double Add(params double[] list)
        {
            double result = 0;
            foreach(double num in list)
            {
                result = result + num;
            }
            return result;
        }
        public double Subtract(params double[] list)
        {
            double result = 0;
            foreach (double num in list)
            {
                result = result - num;
            }
            return result;
        }
        public double Multiply(params double[] list)
        {
            double result = 0;
            foreach (double num in list)
            {
                result = result * num;
            }
            return result;
        }
        hpublic double Divide(params double[] list)
        {
            double result = 0;
            foreach (double num in list)
            {
                result = result / num;
            }
            return result;
        }
        public int Add(params int[] list)
        {
            int result = 0;
            foreach (int num in list)
            {
                result = result + num;
            }
            return result;
        }
        public int Subtract(params int[] list)
        {
            int result = 0;
            foreach (int num in list)
            {
                result = result - num;
            }
            return result;
        }
        public int Multiply(params int[] list)
        {
            int result = 0;
            foreach (int num in list)
            {
                result = result * num;
            }
            return result;
        }
        public int Divide(params int[] list)
        {
            int result = 0;
            foreach (int num in list)
            {
                result = result / num;
            }
            return result;
        }
    }
}

