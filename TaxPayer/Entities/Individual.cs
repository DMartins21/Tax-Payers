namespace TaxPayer.Entities
{
    internal class Individual:Payers
    {
        public double HealthExpenses { get; set; }

        public Individual(string name, double annualIncome, double healthExpenses)
            : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HealthExpenses * 0.50;
            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenses * 0.50;
            }
        }
    }
}
