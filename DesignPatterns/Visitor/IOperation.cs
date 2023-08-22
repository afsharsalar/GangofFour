namespace DesignPatterns.Visitor
{
    public interface IOperation
    {
        void Apply(AnchorNode node);
        void Apply(HeadingNode node);
    }
}
