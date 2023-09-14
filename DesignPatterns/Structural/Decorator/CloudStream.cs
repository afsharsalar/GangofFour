namespace DesignPatterns.Structural.Decorator
{
    public class CloudStream : IStream
    {
        public virtual void Write(string data)
        {
            Console.WriteLine("Storing " +data);
        }
    }
}
