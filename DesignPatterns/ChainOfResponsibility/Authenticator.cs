namespace DesignPatterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
             var valid= request.Username=="admin" && request.Password=="admin";
             Console.WriteLine($"Authentication: {valid}" );
             return !valid;
        }
    }
}
