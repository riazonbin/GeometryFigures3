// Zaripov Riyaz 220th group, 24.05.22 Figures-3

using System;

namespace GeometryFigures3
{
    [Serializable]
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }
    }

    [Serializable]
    abstract public class Figure
    {
        public Point startingPoint;

        public Figure(Point point)
        {
            startingPoint = point;
        }

        public virtual string Draw()
        {
            string result;
            result = "Figure is drawn";

            return result;
        }
    }
}
