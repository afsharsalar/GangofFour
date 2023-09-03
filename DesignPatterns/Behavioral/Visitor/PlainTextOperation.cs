namespace DesignPatterns.Behavioral.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("text-anchor");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("text-heading");
        }
    }
}
