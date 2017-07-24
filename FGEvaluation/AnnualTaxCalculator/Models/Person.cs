using System;
using System.ComponentModel.DataAnnotations;

namespace AnnualTaxCalculator.Models
{
    public class Person
    {
        private string _name;
        private decimal _salaryPerAnnum;
        private DateTime _dateOfBirth;

        [Required]
        [MaxLength(100, ErrorMessage = "The maximum number of characters is 100")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Required]
        public decimal SalaryPerAnnum
        {
            get { return _salaryPerAnnum; }
            set { _salaryPerAnnum = value; }
        }

        [Required]
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        #region Calculated Fields

        public int Age => Convert.ToInt32(DateTime.Today.Subtract(this.DateOfBirth).Days / 365);

        public decimal MonthlySalary => this.SalaryPerAnnum / 12;

        #endregion
    }
}
