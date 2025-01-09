using System;
namespace DZ.Classes
{
    internal class Slide : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"Команда {teamName} играет в игру Горка");
        }
    }
}