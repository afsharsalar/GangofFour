namespace DesignPatterns.Behavioral.Template
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
