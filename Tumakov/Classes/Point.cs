using System;
namespace Tumakov
{
    internal class Point : Figure
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(string color, bool isVisible, double x, double y) : base(color, isVisible)
        {
            X = x;
            Y = y;
        }
        public override void MoveHorizontal(double distance)
        {
            X += distance;
        }
        public override void MoveVertical(double distance)
        {
            Y += distance;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Координаты точки: ({X}, {Y})");
        }
    }
}
