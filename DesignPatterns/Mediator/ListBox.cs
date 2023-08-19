namespace DesignPatterns.Mediator
{
    public class ListBox : UiControl
    {
        private string _selection;

        public ListBox(DialogBox owner) : base(owner)
        {
        }


        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                
                _owner.Changed(this);
            }
        }

        
    }
}
