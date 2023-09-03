namespace DesignPatterns.Behavioral.Mediator
{
    public class Button : UiControl
    {
        private bool _isEnable;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool Enable
        {
            get => _isEnable;
            set
            {
                _isEnable = value;
                _owner.Changed(this);
            }
        }



    }
}
