using FarmerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Test6();
            Test7();

            Console.ReadLine();
        }

        static void Test1()
        {
            double p = 20; // Периметр квадрата
            double s = Farmer.SquareArea(p);
            Console.WriteLine("Площадь квадрата с периметром " + p + ": " + s);
        }

        static void Test2()
        {
            double p = 30; // Периметр равностороннего треугольника
            double s = Farmer.EquilateralTriangleArea(p);
            Console.WriteLine("Площадь равностороннего треугольника с периметром " + p + ": " + s);
        }

        static void Test3()
        {
            double p = 40; // Периметр ромба
            double s = Farmer.RhombusArea(p);
            Console.WriteLine("Площадь ромба с периметром " + p + ": " + s);
        }

        static void Test4()
        {
            double p = 50; // Периметр правильного пятиугольника
            double s = Farmer.PentagonArea(p);
            Console.WriteLine("Площадь правильного пятиугольника с периметром " + p + ": " + s);
        }

        static void Test5()
        {
            double p = 60; // Периметр прямоугольника
            double s = Farmer.RectangleArea(p);
            Console.WriteLine("Площадь прямоугольника с периметром " + p + ": " + s);
        }

        static void Test6()
        {
            double p = 70; // Периметр круга (длина окружности)
            double s = Farmer.CircleArea(p);
            Console.WriteLine("Площадь круга с периметром " + p + ": " + s);
        }

        static void Test7()
        {
            double p = 80; // Периметр правильного шестиугольника
            double s = Farmer.HexagonArea(p);
            Console.WriteLine("Площадь правильного шестиугольника с периметром " + p + ": " + s);
        }
    }
}
