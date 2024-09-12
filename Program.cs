using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndSphere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("R= ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter of the circle: " + Circle.Perimeter(radius));
            Console.WriteLine("Area of the circle: " + Circle.S(radius));
            Console.WriteLine("Surface area of the sphere: " + Sphere.S1(radius));
            Console.WriteLine("Volume of the sphere: " + Sphere.V(radius));
        }
    }
}
