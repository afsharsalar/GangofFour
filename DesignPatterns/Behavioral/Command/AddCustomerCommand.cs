namespace DesignPatterns.Behavioral.Command
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            //delegate
            _customerService.Add();
        }
    }
}
