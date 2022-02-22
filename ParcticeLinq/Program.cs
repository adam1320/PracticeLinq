using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "RaceDriver", "FirstPersonShooter", "Basketball", "Football", "Soccer", "IceHockey", "KitchenChef", "MushroomLand"};

           var sortedVideoGames = videoGames.OrderBy(game => game.Length);
                foreach (var game in sortedVideoGames)
                {
                    Console.WriteLine($"{game}");
                }

        }
     
    }

}
