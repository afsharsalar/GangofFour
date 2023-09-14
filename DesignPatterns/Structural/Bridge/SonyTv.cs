namespace DesignPatterns.Structural.Bridge
{
    public class SonyTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("TurnOn: sony");
        }

        public void TurnOff()
        {
            Console.WriteLine("TurnOff: sony");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("Set Channel: sony");
        }
    }
}
