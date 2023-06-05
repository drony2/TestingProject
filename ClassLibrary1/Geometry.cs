using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Geometry
    {
        public static double STreugol(double a,double h)
        {
            double S = a*h/2;
            return Math.Round(S,3);
        }
        public static double STreugol90Grad(double a, double b)
        {
            double S = (a * b) / 2;
            return Math.Round(S,3);
        }
        public static double SRectangle(double a, double b)
        {
            double S = a*b;
            return S;
        }
        public static double SCircle(double R)
        {
            double p = Math.PI;
            double S = p*(R*R);
            return Math.Round(S,3);
        }
        public static double STrapecia(double a, double b, double h)
        {
            double S = ((a + b) * h) / 2;
            return Math.Round(S,3);
        }


    }
}
