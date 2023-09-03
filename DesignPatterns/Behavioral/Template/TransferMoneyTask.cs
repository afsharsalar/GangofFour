namespace DesignPatterns.Behavioral.Template
{
    public class TransferMoneyTask : Task
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Transfer money");
        }
    }
}
