using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] x12 = Algebra.SqrtQuadraticQquation(4,16,10);
            if (x12 != null)
            {
                for (int i = 0; i < x12.Length; i++)
                {

                    Console.WriteLine(x12[i]);

                }
            }
            else
            {
                Console.WriteLine("Дискреминант < 0");
            }
            double[] a = {3,2,5,6};
            Console.WriteLine(Algebra.GetRowSummary(a));
            Console.WriteLine(Algebra.GetLinearRoots(10,5));
            Console.WriteLine(Algebra.GetRowAvg(a)) ;
            Console.WriteLine(Algebra.GetMaxFromRow(a));


            Console.WriteLine(Geometry.SCircle(7));
            Console.WriteLine(Geometry.STreugol90Grad(3,6));
            Console.WriteLine(Geometry.STreugol(4,6));
            Console.WriteLine(Geometry.SRectangle(6,2));
            Console.WriteLine(Geometry.STrapecia(5,3,2));


            Console.WriteLine(Triginometry.GetCotang(4,6));
            Console.WriteLine(Triginometry.GetSin(7, 4));
            Console.WriteLine(Triginometry.GetTang(8,4));
            Console.WriteLine(Triginometry.GetCos(2,5));
            Console.ReadKey();
        }
    }
}
