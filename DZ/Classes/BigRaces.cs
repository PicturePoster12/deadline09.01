using System;
namespace DZ.Classes
{
    public class BigRaces
    {
        private List<IGame> games;
        private List<Team> teams;
        public BigRaces()
        {
            games = new List<IGame>();
            teams = new List<Team>();
        }
        public void AddGame(IGame game)
        {
            games.Add(game);
        }
        public void AddTeam(Team team)
        {
            teams.Add(team);
        }
        public void StartGames()
        {
            Console.WriteLine("Начало соревнований!\n");
            foreach (var team in teams)
            {
                Console.WriteLine($"Команда {team.Name} начинает испытания:");
                foreach (var game in games)
                {
                    game.Play(team.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
