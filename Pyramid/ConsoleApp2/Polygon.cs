using System;
using System.Collections.Generic;
using System.Text;

namespace pyramid
{
    class Polygon
    {
        private int x1;
        private int y1;
        private int r;
        private int n;
        private static int instances = 0;

        public Polygon(int x1, int y1, int r, int n)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.r = r;
            this.n = n;
            instances++; 
        }

        public static void GetCountOfCreatedObjects()
        {
            Console.WriteLine(instances);
        }

        public double Perimeter()
        {
            return 2 * n * r * Math.Sin(Math.PI / n);
        }
        public double Area() 
        {
            return n * Math.Pow(r, 2) / 2 * Math.Sin(2 * Math.PI / n);
        }
        public double PolygonSide()
        {
            return 2 * r * Math.Sin(Math.PI / n);
        }
        public double RadiusInscribedCircle()
        {
            return PolygonSide() / (2 * Math.Tan(Math.PI / n));
        }
        public double GetAngleOfPolygon()
        {
            return (Math.PI / 180 * (n - 2)) / (n);
        }
        public static bool operator ==(Polygon obj1, Polygon obj2)
        {
            return (obj1.x1 == obj2.x1
                        && obj1.y1 == obj2.y1
                        && obj1.r == obj2.r
                        && obj1.n == obj2.n);

        }
        public static bool operator !=(Polygon obj1, Polygon obj2)
        {
            return !(obj1.x1 == obj2.x1
                        && obj1.y1 == obj2.y1
                        && obj1.r == obj2.r
                        && obj1.n == obj2.n);
        
        }
    }
}
