// Zaripov Riyaz 220th group, 24.05.22 Figures-3

using System;

namespace GeometryFigures3
{
    [Serializable]
    public class Rectangle : Figure
    {
        public int Width;
        public int Height;

        public Rectangle(Point point, int width, int height) : base(point)
        {
            this.Width = width;
            this.Height = height;
        }

        public override string Draw()
        {
            string result;
            result = $"Rectangle at {startingPoint}, Width: {Width}, Height: {Height}";

            return result;
        }
    }
}
