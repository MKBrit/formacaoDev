using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Dez
{
    class Triangulo
    {
        private float a;
        private float b;
        private float c;
        public Triangulo(float x, float y, float z) 
        {
            a = x; b = y; c = z;
        }
        public double area(float x, float y, float z)
        {
            double s = (z + x + y) / 2;
            double area = Math.Sqrt(s * (s - x) * (s - z) * (s - y));
            return area;
        }
    }
}
