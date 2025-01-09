using System;
namespace Tumakov
{
    class Laba
    {
        static void Main()
        {
            ///Task1();
            Task2();
        }
        static void Task1()
        {
            Console.WriteLine("10.1");
            ICipher aCipher = new ACipher();
            ICipher bCipher = new BCipher();
            string input = "Привет, Мир!";
            string aEncoded = aCipher.Encode(input);
            string aDecoded = aCipher.Decode(aEncoded);
            Console.WriteLine($"ACipher: \nОригинал: {input}\nЗакодировано: {aEncoded}\nДекодировано: {aDecoded}\n");
            string bEncoded = bCipher.Encode(input);
            string bDecoded = bCipher.Decode(bEncoded);
            Console.WriteLine($"BCipher: \nОригинал: {input}\nЗакодировано: {bEncoded}\nДекодировано: {bDecoded}");
        }
        static void Task2()
        {
            Console.WriteLine("dz10.1");
            var point = new Point("Черный", true, 0, 0);
            point.DisplayInfo();
            point.MoveHorizontal(5);
            point.MoveVertical(10);
            point.ChangeVisibility();
            point.DisplayInfo();

            Circle circle = new Circle("Синий", true, 0, 0, 5);
            circle.DisplayInfo();
            circle.MoveHorizontal(-1);
            circle.MoveVertical(6);
            circle.DisplayInfo();

            Rectangle rectangle = new Rectangle("Зеленый", true, 1, 1, 10, 5);
            rectangle.DisplayInfo();
            rectangle.MoveHorizontal(5);
            rectangle.MoveVertical(-10);
            rectangle.DisplayInfo();
        }
    }
}
