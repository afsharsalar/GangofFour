namespace DesignPatterns.Behavioral.Observer
{
    public class DataSource : Subject
    {
        private int _value;


        public int Get()
        {
            return _value;
        }


        public void Set(int value)
        {
            _value = value;
            Notify();
        }
    }
}
