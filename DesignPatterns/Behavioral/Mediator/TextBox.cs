namespace DesignPatterns.Behavioral.Mediator
{
    internal class TextBox : UiControl
    {
        private string _content;
        public TextBox(DialogBox owner) : base(owner)
        {
        }
        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                _owner.Changed(this);
            }
        }
    }
}
