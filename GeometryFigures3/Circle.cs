// Zaripov Riyaz 220th group, 27.04.22 Figures-2

using System;

namespace GeometryFigures3
{
    [Serializable]
    public class Circle : Figure
    {
        public int Radius;

        public Circle(Point point, int radius) : base(point)
        {
            this.Radius = radius;
        }

        public override string Draw()
        {
            string result;
            result = $"Circle at {startingPoint}, Radius: {Radius}";

            return result;
        }
    }
}
