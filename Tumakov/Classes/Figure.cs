using System;
namespace Tumakov
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public bool IsVisible { get; set; }
        public Figure(string color, bool isVisible)
        {
            Color = color;
            IsVisible = isVisible;
        }
        public void ChangeVisibility()
        {
            IsVisible = !IsVisible;
        }
        public abstract void MoveHorizontal(double distance);
        public abstract void MoveVertical(double distance);
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Цвет: {Color}, Видимость: {(IsVisible ? "Видима" : "Невидима")}");
        }
    }
}
