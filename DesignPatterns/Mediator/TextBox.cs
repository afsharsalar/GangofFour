namespace DesignPatterns.Mediator
{
    internal class TextBox : UiControl
    {
        private string _content;
        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                //Owner.Changed(this);
                Notify();
            }
        }
        //public TextBox(DialogBox owner) : base(owner)
        //{
        //}


        
    }
}
