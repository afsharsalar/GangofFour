namespace DesignPatterns.Momento
{
    public class Editor
    {
        private string _content;

        public EditorState CreateState()
        {
            return new EditorState(_content);
        }

        public void Restore(EditorState state)
        {
            _content = state.Get();
        }

        public string Get()
        {
            return _content;
        }


        public void Set(string content)
        {
            _content = content;
        }


    }
}
