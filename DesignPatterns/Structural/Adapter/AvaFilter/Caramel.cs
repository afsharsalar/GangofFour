namespace DesignPatterns.Structural.Adapter.AvaFilter
{
    public class Caramel
    {
        public void Init()
        {
            Console.WriteLine("Init Caramel filter");
        }


        public void Render(Image image)
        {
            Console.WriteLine("Applying Caramel filter");
        }
    }
}
