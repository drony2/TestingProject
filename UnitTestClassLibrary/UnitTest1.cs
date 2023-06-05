using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using System.Diagnostics.SymbolStore;

namespace UnitTestClassLibrary
{
    [TestClass]
    public class UnitTest1Library1
    {
        //Geometry
        //GeometryMethodSTreugol
        [TestMethod]
        public void Test1GeometryMethodSTreugol()
        {
            double a = 5;
            double h = 2;
            double S = 5;

            double res = ClassLibrary1.Geometry.STreugol(a, h);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test2GeometryMethodSTreugol()
        {
            double a = 10;
            double h = 6;
            double S = 30;

            double res = ClassLibrary1.Geometry.STreugol(a, h);

            Assert.AreEqual(res, S);
        
        }
        [TestMethod]

        public void Test3GeometryMethodSTreugol()
        {
            double a = 7;
            double h = 4;
            double S = 14;

            double res = ClassLibrary1.Geometry.STreugol(a, h);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test4GeometryMethodSTreugol()
        {
            double a = 14;
            double h = 7;
            double S = 49;

            double res = ClassLibrary1.Geometry.STreugol(a, h);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test5GeometryMethodSTreugol()
        {
            double a = 50;
            double h = 30;
            double S = 750;

            double res = ClassLibrary1.Geometry.STreugol(a, h);

            Assert.AreEqual(res, S);
        }

        //STreugol90Grad
        [TestMethod]
        public void Test1STreugol90Grad()
        {
            double a = 50;
            double b = 10;
            double S = 250;

            double res = ClassLibrary1.Geometry.STreugol90Grad(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test2STreugol90Grad()
        {
            double a = 10;
            double b = 5;
            double S = 25;

            double res = ClassLibrary1.Geometry.STreugol90Grad(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test3STreugol90Grad()
        {
            double a = 20;
            double b = 7;
            double S = 70;

            double res = ClassLibrary1.Geometry.STreugol90Grad(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test4STreugol90Grad()
        {
            double a = 5;
            double b = 5;
            double S = 12.5;

            double res = ClassLibrary1.Geometry.STreugol90Grad(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test5STreugol90Grad()
        {
            double a = 9;
            double b = 7;
            double S = 31.5;

            double res = ClassLibrary1.Geometry.STreugol90Grad(a, b);

            Assert.AreEqual(res, S);
        }

        //SRectangle
        [TestMethod]
        public void Test1SRectangle()
        {
            double a = 9;
            double b = 7;
            double S = 63;

            double res = ClassLibrary1.Geometry.SRectangle(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test2SRectangle()
        {
            double a = 10;
            double b = 5;
            double S = 50;

            double res = ClassLibrary1.Geometry.SRectangle(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test3SRectangle()
        {
            double a = 9;
            double b = 8;
            double S = 72;

            double res = ClassLibrary1.Geometry.SRectangle(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test4SRectangle()
        {
            double a = 2;
            double b = 4;
            double S = 8;

            double res = ClassLibrary1.Geometry.SRectangle(a, b);

            Assert.AreEqual(res, S);
        }
        [TestMethod]
        public void Test5SRectangle()
        {
            double a = 7;
            double b = 3;
            double S = 21;

            double res = ClassLibrary1.Geometry.SRectangle(a, b);

            Assert.AreEqual(res, S);
        }

        //SCircle
        [TestMethod]

        public void Test1SCircle()
        {
            double a = 7;
            double S = 153.938;

            double res = ClassLibrary1.Geometry.SCircle(a);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test2SCircle()
        {
            double a = 9;
            double S = 254.469;

            double res = ClassLibrary1.Geometry.SCircle(a);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test3SCircle()
        {
            double a = 2;
            double S = 12.566;

            double res = ClassLibrary1.Geometry.SCircle(a);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test4SCircle()
        {
            double a = 13;
            double S = 530.929;

            double res = ClassLibrary1.Geometry.SCircle(a);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test5SCircle()
        {
            double a = 20;
            double S = 1256.637;

            double res = ClassLibrary1.Geometry.SCircle(a);

            Assert.AreEqual(res, S);
        }

        //STrapecia
        [TestMethod]

        public void Test1STrapecia()
        {
            double a = 10;
            double b = 7;
            double h = 15;
            double S = 127.5;

            double res = ClassLibrary1.Geometry.STrapecia(a,b,h);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test2STrapecia()
        {
            double a = 1;
            double b = 2;
            double h = 3;
            double S = 4.5;

            double res = ClassLibrary1.Geometry.STrapecia(a, b, h);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test3STrapecia()
        {
            double a = 5;
            double b = 2;
            double h = 4;
            double S = 14;

            double res = ClassLibrary1.Geometry.STrapecia(a, b, h);

            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test4STrapecia()
        {
            double a = 13;
            double b = 6;
            double h = 15;
            double S = 142.5;

            double res = ClassLibrary1.Geometry.STrapecia(a, b, h);
            Assert.AreEqual(res, S);
        }
        [TestMethod]

        public void Test5STrapecia()
        {
            double a = 9;
            double b = 8;
            double h = 4;
            double S = 34;

            double res = ClassLibrary1.Geometry.STrapecia(a, b, h);

            Assert.AreEqual(res, S);
        }


        //Algebra
        //AlgebraSqrtQuadraticQquation
        [TestMethod]
        public void Test1AlgebraSqrtQuadraticQquation()
        {
            int a = 4;
            int b = 16;
            int c = 10;
            double[] x12 = new double[2] {-0.775, -3.225 };

            double[] res = new double[2];
            res= ClassLibrary1.Algebra.SqrtQuadraticQquation(a, b, c);

            CollectionAssert.AreEqual(res,x12);
        }
        [TestMethod]
        public void Test2AlgebraSqrtQuadraticQquation()
        {
            int a = 5;
            int b = 6;
            int c = 7;
            double[] x12 = null;

            double[] res = new double[2];
            res = ClassLibrary1.Algebra.SqrtQuadraticQquation(a, b, c);

            Assert.AreEqual(res, x12);
        }
        [TestMethod]
        public void Test3AlgebraSqrtQuadraticQquation()
        {
            int a = 4;
            int b = 8;
            int c = 4;
            double[] x12 = new double[1] {-16};

            double[] res = new double[2];
            res = ClassLibrary1.Algebra.SqrtQuadraticQquation(a, b, c);

            CollectionAssert.AreEqual(res, x12);
        }
        [TestMethod]
        public void Test4AlgebraSqrtQuadraticQquation()
        {
            int a = 1;
            int b = 2;
            int c = -3;
            double[] x12 = new double[2] {1,-3 };

            double[] res = new double[2];
            res = ClassLibrary1.Algebra.SqrtQuadraticQquation(a, b, c);

            CollectionAssert.AreEqual(res, x12);
        }
        [TestMethod]
        public void Test5AlgebraSqrtQuadraticQquation()
        {
            int a = 2;
            int b = -5;
            int c = 3;
            double[] x12 = new double[2] { 1.5 ,1 };

            double[] res = new double[2];
            res = ClassLibrary1.Algebra.SqrtQuadraticQquation(a, b, c);

            CollectionAssert.AreEqual(res, x12);
        }

        //GetLinearRoots
        [TestMethod]
        public void Test1GetLinearRoots()
        {
            double a = 4;
            double b = 16;
            string b1 = "-4";


            string res = ClassLibrary1.Algebra.GetLinearRoots(a, b);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test2GetLinearRoots()
        {
            double a = 4;
            double b = 20;
            string b1 = "-5";


            string res = ClassLibrary1.Algebra.GetLinearRoots(a, b);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test3GetLinearRoots()
        {
            double a = 0;
            double b = 1;
            string b1 = "Корней нет";


            string res = ClassLibrary1.Algebra.GetLinearRoots(a, b);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test4GetLinearRoots()
        {
            double a = 10;
            double b = 100;
            string b1 = "-10";


            string res = ClassLibrary1.Algebra.GetLinearRoots(a, b);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test5GetLinearRoots()
        {
            double a = 4;
            double b = 16;
            string b1 = "-4";


            string res = ClassLibrary1.Algebra.GetLinearRoots(a, b);

            Assert.AreEqual(res, b1);
        }
        //GetRowSummary
        [TestMethod]

        public void Test1GetRowSummary()
        {
            double[] a = { 1, 2, 4, 5, 6, 1, 2, 2.4 } ;
            double b1 = 23.4;


            double res = ClassLibrary1.Algebra.GetRowSummary(a);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test2GetRowSummary()
        {
            double[] a = { 1, 2, 4, 5, 6, 1, 2, 2.4,2.3 };
            double b1 = 25.7;


            double res = ClassLibrary1.Algebra.GetRowSummary(a);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test3GetRowSummary()
        {
            double[] a = { 9, 7 ,2,2.3 };
            double b1 = 20.3;


            double res = ClassLibrary1.Algebra.GetRowSummary(a);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test4GetRowSummary()
        {
            double[] a = { 1, 2, 4 };
            double b1 = 7;


            double res = ClassLibrary1.Algebra.GetRowSummary(a);

            Assert.AreEqual(res, b1);
        }
        [TestMethod]

        public void Test5GetRowSummary()
        {
            double[] a = { 2,5,6,1 };
            double b1 = 14;


            double res = ClassLibrary1.Algebra.GetRowSummary(a);

            Assert.AreEqual(res, b1);
        }

        [TestMethod]
        public void TestGetMaxFromRowTest1()
        {
            //Arrange

            double[] array = { 1, 5, 32, 7, 9, -100.33, 432.4 };

            double result = 432.4;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetMaxFromRowTest2()
        {
            //Arrange

            double[] array = { 0, 0, 0, 0, 0, 0 };

            double result = 0;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetMaxFromRowTest3()
        {
            //Arrange

            double[] array = { 4, 6, 4, 3, 7, 7 };

            double result = 7;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetMaxFromRowTest4()
        {
            //Arrange

            double[] array = { 1.23, 4.56, -5.34, 10, 23.444 };

            double result = 23.444;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetMaxFromRowTest5()
        {
            //Arrange

            double[] array = { -23.2, -5.4, -29.34, -0.45, -10 };

            double result = -0.45;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetMaxFromRow(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetRowAvgTest1()
        {
            //Arrange

            double[] array = { 1, 2, 3, 4, 5 };

            double result = 3;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetRowAvgTest2()
        {
            //Arrange

            double[] array = { 0.23, 45.23, 2, 23.1 };

            double result = 17.64;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetRowAvgTest3()
        {
            //Arrange

            double[] array = { 2, 3, 4, 5, 6 };

            double result = 4;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetRowAvgTest4()
        {
            //Arrange

            double[] array = { 1, 2, 3, 4, 5, 6 };

            double result = 3.5;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetRowAvgTest5()
        {
            //Arrange

            double[] array = { 1.23, 2.34, 45, 54.8 };

            double result = 25.84;

            //Act

            double methodRes = ClassLibrary1.Algebra.GetRowAvg(array);

            //Asset

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void TestGetSinTest1()
        {
            //Arrange
            double cathet = 6;
            double hypotenuse = 3;
            double sin = 2;

            //Act
            double result = ClassLibrary1.Triginometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetSinTest2()
        {
            //Arrange
            double cathet = 3;
            double hypotenuse = 6;
            double sin = 0.5;

            //Act
            double result = ClassLibrary1.Triginometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetSinTest3()
        {
            //Arrange
            double cathet = 4;
            double hypotenuse = 2;
            double sin = 2;

            //Act
            double result = ClassLibrary1.Triginometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetSinTest4()
        {
            //Arrange
            double cathet = 9;
            double hypotenuse = 3;
            double sin = 3;

            //Act
            double result = ClassLibrary1.Triginometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetSinTest5()
        {
            //Arrange
            double cathet = 10;
            double hypotenuse = 2;
            double sin = 5;

            //Act
            double result = ClassLibrary1.Triginometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetCosTest1()
        {
            //Arrange
            double cathet = 10;
            double hypotenuse = 2;
            double sin = 5;

            //Act
            double result = ClassLibrary1.Triginometry.GetSin(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetCosTest2()
        {
            //Arrange
            double cathet = 3;
            double hypotenuse = 6;
            double sin = 0.5;

            //Act
            double result = ClassLibrary1.Triginometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetCosTest3()
        {
            //Arrange
            double cathet = 4;
            double hypotenuse = 2;
            double sin = 2;

            //Act
            double result = ClassLibrary1.Triginometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetCosTest4()
        {
            //Arrange
            double cathet = 9;
            double hypotenuse = 3;
            double sin = 3;

            //Act
            double result = ClassLibrary1.Triginometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetCosTest5()
        {
            //Arrange
            double cathet = 10;
            double hypotenuse = 2;
            double sin = 5;

            //Act
            double result = ClassLibrary1.Triginometry.GetCos(cathet, hypotenuse);

            //Assert
            Assert.AreEqual(sin, result);
        }

        [TestMethod]
        public void TestGetTangTest1()
        {
            //Arrange
            double oppositeCathet = 3;
            double adjacentCathet = 1;

            double tang = 3;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TestGetTangTest2()
        {
            //Arrange
            double oppositeCathet = 6;
            double adjacentCathet = 2;

            double tang = 3;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TestGetTangTest3()
        {
            //Arrange
            double oppositeCathet = 2;
            double adjacentCathet = 4;

            double tang = 0.5;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TestGetTangTest4()
        {
            //Arrange
            double oppositeCathet = 8;
            double adjacentCathet = 2;

            double tang = 4;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TestGetTangTest5()
        {
            //Arrange
            double oppositeCathet = 9;
            double adjacentCathet = 2;

            double tang = 4.5;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetTang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TestGetCotangTest1()
        {
            //Arrange
            double oppositeCathet = 2;
            double adjacentCathet = 4;

            double tang = 2;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TetsGetCotangTest2()
        {
            //Arrange
            double oppositeCathet = 6;
            double adjacentCathet = 36;

            double tang = 6;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TetsGetCotangTest3()
        {
            //Arrange
            double oppositeCathet = 5;
            double adjacentCathet = 15;

            double tang = 3;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TestGetCotangTest4()
        {
            //Arrange
            double oppositeCathet = 10;
            double adjacentCathet = 100;

            double tang = 10;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }

        [TestMethod]
        public void TetsGetCotangTest5()
        {
            //Arrange
            double oppositeCathet = 6;
            double adjacentCathet = 3;

            double tang = 0.5;

            //Act

            double methodRes = ClassLibrary1.Triginometry.GetCotang(oppositeCathet, adjacentCathet);

            //Assert

            Assert.AreEqual(tang, methodRes);
        }


    }
}
