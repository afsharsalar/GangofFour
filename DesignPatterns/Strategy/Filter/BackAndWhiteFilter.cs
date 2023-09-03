namespace DesignPatterns.Strategy.Filter
{
    public class BackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applying black and white filter");
        }
    }
}
