using System;
namespace Tumakov
{
    internal class Rectangle : Point
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(string color, bool isVisible, double x, double y, double height, double width) : base(color, isVisible, x, y)
        {
            Height = height;
            Width = width;
        }
        public double Area()
        {
            return Height * Width;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {Area():F2}");
        }
    }
}
