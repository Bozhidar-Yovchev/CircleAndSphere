using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndSphere
{
    static class Circle
    {
        
        static public double Perimeter(double r)
        {
           return  2 * Math.PI* r;
        }
        static public double S(double r)
        {
             return Math.PI * r* r;
        }

    }
}
