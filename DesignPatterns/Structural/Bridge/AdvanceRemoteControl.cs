namespace DesignPatterns.Structural.Bridge
{
    public class AdvanceRemoteControl : RemoteControl
    {
        public AdvanceRemoteControl(IDevice device) : base(device)
        {
        }


        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }
    }
}
