using System;
namespace DZ.Classes
{
    internal class Mousetrap : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"Команда {teamName} играет в игру Мышеловка");
        }
    }
}