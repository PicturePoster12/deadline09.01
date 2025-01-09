using System;
namespace DZ.Classes
{
    internal class Jungle : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"Команда {teamName} играет в игру Джунгли");
        }
    }
}
