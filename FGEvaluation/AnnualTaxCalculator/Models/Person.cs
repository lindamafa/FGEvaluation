using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualTaxCalculator.Models
{
    public class Person
    {
        [Required]
        [MaxLength(100,ErrorMessage = "The maximum number of characters is 100")]
        public string Name { get; set; }
        [Required]
        public double SalaryPerAnnum { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
