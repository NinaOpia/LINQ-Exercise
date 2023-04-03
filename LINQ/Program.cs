namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGamesList = new List<string>
           {
               "Mass Effect",
               "KOTOR",
               "Mortal Combat",
               "Halo",
               "Bricks"
            };

            Console.WriteLine("Original List:");
            videoGamesList.ForEach(Console.WriteLine);

            Console.WriteLine();

            Console.WriteLine("Ordered List:");
            var gamesListOrdered = videoGamesList.OrderBy(name => name.Length);

            foreach(var gameName in gamesListOrdered)
            {
                Console.WriteLine(gameName);
            }

            //Alternatively, one can rewrite the ordered list like this below:
            //Console.WriteLine("Ordered List:");
            //videoGamesList.OrderBy(name => name.Length).ToList().ForEach(Console.WriteLine);

        }
    }
}
