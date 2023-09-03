namespace DesignPatterns.Behavioral.Momento
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }


        public EditorState Pop()
        {
            var lastIndex = _states.Count - 1;
            var lastState = _states[lastIndex];
            _states.RemoveAt(lastIndex);
            return lastState;
        }
    }
}
