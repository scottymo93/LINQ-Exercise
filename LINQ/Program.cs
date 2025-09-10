namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>() { "Tony Hawk Pro Skater", "Call of Duty", "Halo", "Mario Kart" };
            
            var orderedNames = gameNames.OrderBy(name => name.Length).ToList();
            orderedNames.ForEach(name => Console.WriteLine(name));
        }
    }
}
