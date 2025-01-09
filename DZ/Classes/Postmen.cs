using System;
namespace DZ.Classes
{
    internal class Postmen : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"Команда {teamName} играет в игру Почтальоны");
        }
    }
}