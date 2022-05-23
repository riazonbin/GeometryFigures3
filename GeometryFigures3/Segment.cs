// Zaripov Riyaz 220th group, 27.04.22 Figures-2

using System;

namespace GeometryFigures3
{
    [Serializable]
    public class Segment : Figure
    {
        public Point point2;

        public Segment(Point point1, Point point2) : base(point1)
        {
            this.point2 = point2;
        }

        public override string Draw()
        {
            string result;
            result = $"Segment A {startingPoint} - B {point2}";

            return result;
        }
    }
}