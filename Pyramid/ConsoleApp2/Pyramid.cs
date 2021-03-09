using System;
using System.Collections.Generic;
using System.Text;

namespace pyramid
{
    class Pyramid : Polygon
    {
        private int height;
        private int x2;
        private int y2;

        public Pyramid(int x1, int y1, int r, int n, int height, int x2, int y2) : base(x1, y1, r, n)
        {
            this.height = height;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double GetLateralArea()
        {
            return 1.0 / 2 * Perimeter() * Math.Sqrt(Math.Pow(height, 2) + Math.Pow(RadiusInscribedCircle(), 2));
        }
        public double GetVolumePyramid()
        {
            return 1.0 / 3 * Area() * height;
        }
        public static bool operator >=(Pyramid obj1, Pyramid obj2)
        {
            return obj1.GetVolumePyramid() >= obj2.GetVolumePyramid();
        }
        public static bool operator <=(Pyramid obj1, Pyramid obj2)
        {
            return obj1.GetVolumePyramid() <= obj2.GetVolumePyramid();
        }
    }
}
