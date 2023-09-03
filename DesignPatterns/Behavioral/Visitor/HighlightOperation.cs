namespace DesignPatterns.Behavioral.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("anchor-highlight");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("heading-highlight");
        }
    }
}
