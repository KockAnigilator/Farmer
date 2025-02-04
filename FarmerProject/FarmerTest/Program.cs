using FarmerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerTest
{
    public class Program
    {
        static void Test1()
        {
            double p = 10;
            double s = Farmer.CircleArea(p);
            Console.WriteLine("Площадь круга:" + s);
        }
        
        static void Main(string[] args)
        {
            Test1();
            Console.ReadLine();
        }


        
    }
}
