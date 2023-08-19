namespace DesignPatterns.Momento
{
    public class EditorState
    {
        private readonly string _content;

        public EditorState(string content)
        {
            _content = content;
            
        }


        public string Get()
        {
            return _content;
        }
    }
}
