namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        private readonly Handler _next;

        protected Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;

            if (_next != null) 
                _next.Handle(request);
        }
        public abstract bool DoHandle(HttpRequest request);
    }
}
