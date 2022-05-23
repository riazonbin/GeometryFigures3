// Zaripov Riyaz 220th group, 27.04.22 Figures-2

using System;

namespace GeometryFigures3
{
    [Serializable]
    public class Triangle : Figure
    {
        public Point point2;
        public Point point3;

        public Triangle(Point point1, Point point2, Point point3) : base(point1)
        {
            this.point2 = point2;
            this.point3 = point3;
        }

        public override string Draw()
        {
            string result;
            result = $"Triangle A {startingPoint} - B {point2} - C {point3}";

            return result;
        }
    }
}
