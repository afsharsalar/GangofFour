 namespace DesignPatterns.Structural.Decorator
{
    public class EncryptedCloudStream : IStream
    {

        private readonly IStream _stream;

        public EncryptedCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            _stream.Write(encrypted);
        }


        private string Encrypt(string data)
        {
            return "!@@#2131sdsd23dfsdf";
        }
    }
}
