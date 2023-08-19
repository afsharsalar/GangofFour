namespace DesignPatterns.Strategy
{
    public class CustomFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("applying  custom filter");
        }
    }
}
