namespace DesignPatterns.Structural.Bridge
{
    public class SamsungTv : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Turn on: Samsung");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off: Samsung");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("set channel: Samsung");
        }
    }
}
