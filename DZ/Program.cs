using DZ.Classes;
using System;
namespace DZ
{
    class Program
    {
        static void Main()
        {
            var teams = new List<Team>
            {
                new Team("Россия"),
                new Team("Франция"),
                new Team("Китай"),
                new Team("Казахстан"),
            };
            var games = new List<IGame>
            {
                new Beach(),
                new Mousetrap(),
                new Sea(),
                new Fishing(),
                new Postmen(),
                new Slide()
            };
            var bigRaces = new BigRaces();
            foreach (var team in teams)
            {
                bigRaces.AddTeam(team);
            }
            foreach (var game in games)
            {
                bigRaces.AddGame(game);
            }
            bigRaces.AddGame(new Jungle());
            bigRaces.StartGames();
        }
    }
}