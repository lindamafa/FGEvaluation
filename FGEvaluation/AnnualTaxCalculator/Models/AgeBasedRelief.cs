namespace AnnualTaxCalculator.Models
{
    public class AgeBasedRelief
    {
        public int LowerAgeLimit { get; set; }
        public double MonthlySalaryRelief { get; set; }
        public decimal PercentageOfDeduction { get; set; }
    }
}
