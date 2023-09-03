using DesignPatterns.Structural.Adapter.AvaFilter;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Caramel Adapter
    /// </summary>
    public class CaramelAdapter :Caramel, IFilter
    {
        
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
