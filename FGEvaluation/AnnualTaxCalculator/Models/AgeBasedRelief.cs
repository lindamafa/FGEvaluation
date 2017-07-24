namespace AnnualTaxCalculator.Models
{
    public class AgeBasedRelief
    {
        public int LowerAgeLimit { get; set; }
        public decimal MonthlySalaryRelief { get; set; }
        public decimal PercentageOfDeduction { get; set; }
    }
}
