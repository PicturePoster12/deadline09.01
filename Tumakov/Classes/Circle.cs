using System;
namespace Tumakov
{
    internal class Circle : Point
    {
        public double Radius { get; set; }
        public Circle(string color, bool isVisible, double x, double y, double radius) : base(color, isVisible, x, y)
        {
            Radius = radius;
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Радиус: {Radius}, Площадь: {Area():F2}");
        }
    }
}
