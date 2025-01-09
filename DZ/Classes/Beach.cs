using System;
namespace DZ.Classes
{
    internal class Beach : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"Команда {teamName} играет в игру Пляж");
        }
    }
}