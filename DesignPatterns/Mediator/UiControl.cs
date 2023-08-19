namespace DesignPatterns.Mediator
{
    public abstract class UiControl
    {
        //protected DialogBox Owner;

        //public UiControl(DialogBox owner)
        //{
        //    Owner = owner;
        //}
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        protected void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
