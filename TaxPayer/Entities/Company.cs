namespace TaxPayer.Entities
{
    internal class Company:Payers
    {
        public int Employees { get; set; }

        public Company(string name, double annualIncome, int employees)
            : base(name, annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if(Employees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
