namespace DesignPatterns.Structural.Decorator
{
    public class CompressCloudStream : IStream
    {
        private readonly IStream _stream;

        public CompressCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var compressed = Compress(data);
            _stream.Write(data);
        }


        public string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
