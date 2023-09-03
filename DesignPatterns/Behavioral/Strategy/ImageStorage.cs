using DesignPatterns.Behavioral.Strategy.Compress;
using DesignPatterns.Behavioral.Strategy.Filter;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ImageStorage
    {
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);

        }
    }
}
