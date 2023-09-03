namespace DesignPatterns.Behavioral.Observer
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("SpreadSheet got notified" + _dataSource.Get());
        }
    }
}
