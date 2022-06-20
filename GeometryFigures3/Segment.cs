// Sharipov Kamil 220th group, 24.05.22 Figures-3

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
