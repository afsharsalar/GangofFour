namespace DesignPatterns.Template
{
    public class ReportGeneratorTask : Task
    {
        public ReportGeneratorTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generate report");
        }
    }
}
