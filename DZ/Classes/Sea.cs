using System;
namespace DZ.Classes
{
    internal class Sea : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"Команда {teamName} играет в игру Море");
        }
    }
}