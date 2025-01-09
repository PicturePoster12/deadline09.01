using System;
namespace DZ.Classes
{
    internal class Fishing : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"Команда {teamName} играет в игру Рыбалка");
        }
    }
}