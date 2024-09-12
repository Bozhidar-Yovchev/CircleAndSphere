using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAndSphere
{
    static class Sphere
    {
        static public double S1(double r)
        {
            return 4 * Math.PI * r * r;
        }

        static public double V(double r)
        {
            return (4 * Math.PI * r * r * r) / 3;
        }
    }
}
