using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Dez
{
    class Retangulo
    {
        private float w;
        private float h;

        public Retangulo(float x, float y)
        {
            w = x;
            h = y;
        }
        public float getArea()
        {
            return h * w;
        }
        public float perimeter()
        {
            return h * 2 + w *2;
        }
    }
}
