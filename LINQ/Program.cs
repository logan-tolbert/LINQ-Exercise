namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            {
                "The Elder Scrolls: Skyrim", "Fallout: New Vegas", "Halo: Combat Evolved", "Destiny", "Fortnite", "Mario", "Zelda: Breath of the Wild",
                "Final Fantasy VII", "Yakuza" };


            // OrderBy 
            // ForEach
            List<string> orderedGames = videoGames.OrderBy(game => game.Length).ToList();
            orderedGames.ForEach(Console.WriteLine);

            Console.WriteLine(Environment.NewLine);

            
            //  Take
            // OrderByDescending
            var aFewGames = orderedGames.OrderByDescending(game => game).Take(3);
            foreach (var game in aFewGames)
            {
                Console.WriteLine(game);
            } 
            Console.WriteLine(Environment.NewLine);


            // Sum
            var sumOfGames = videoGames.Sum(game => game.Length);
            Console.WriteLine(sumOfGames);

            Console.WriteLine(Environment.NewLine);


            // Where
            var falloutSeries = videoGames.Where(game => game.StartsWith(("Fa")));
            foreach (string game in falloutSeries)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine(Environment.NewLine);


            // Select
            var myGameArray = videoGames.Select(game => game.ToString()).ToArray();
            Console.WriteLine(myGameArray);

            
            // Average
            var gameAverage = videoGames.Average(game => game.Length);
            Console.WriteLine(gameAverage);


            // Count
            int gameCount = videoGames.Count();
            Console.WriteLine(gameCount);


            // Min
            int minGame = videoGames.Min(game => game.Length);
            Console.WriteLine(minGame);
            

            // Max
            int maxGame = videoGames.Max(game => game.Length);
            Console.WriteLine(maxGame);

            // Append
            List<string> newGamesList = videoGames.Append("Fallout 4").ToList();
            foreach (string game in newGamesList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine(Environment.NewLine);


            // ThenBy
            IEnumerable<string> organizedGames = videoGames.OrderBy(game => game.Max()).ThenBy(game => game.Length);
            foreach (var game in organizedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
