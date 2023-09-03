namespace DesignPatterns.Behavioral.Visitor
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
