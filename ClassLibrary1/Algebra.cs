using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Algebra
    {
        public static double[] SqrtQuadraticQquation(int a,int b, int c)
        {
            double D = (b * b) - 4 * a * c;
            if (D>0)
            {
                double x1 = ((-1*b) + Math.Sqrt(D)) / (2 * a);
                double x2 = ((-1*b) - Math.Sqrt(D)) / (2 * a);
                
                double[] x12 = { Math.Round(x1, 3),Math.Round( x2,3) };
                return x12;
            }
            else if (D==0)
            {
                double x1 = -b / 2 * a;
                double[] x12 = {Math.Round(x1)};
                return x12;
            }
            return null;
  
        }

        public static string GetLinearRoots(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return "Корней нет";
            }
            else if (a == 0 && b == 0)
            {
                return "Корень пренадлежит множеству действительных чисел";
            }
            else
            {
                return $"{Math.Round(b / a * -1, 2)}";
            }
        }

        public static double GetRowSummary(double[] array)
        {
            double summary = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summary += array[i];
            }

            return summary;
        }

        public static double GetMaxFromRow(double[] array)
        {
            double max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static double GetRowAvg(double[] array)
        {
            return Math.Round(GetRowSummary(array) / array.Length, 2);
        }



    }
}
