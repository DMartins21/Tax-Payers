namespace TaxPayer.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Payers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
