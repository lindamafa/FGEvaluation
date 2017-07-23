using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnualTaxCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
    }

    //Pseudocode
    //Create a person object with attributes FirstName,LastName,DOB,SalaryPerAnnum
    //Create a class AgeCalculator which calculates the age of the user based on the DOB entered
    //Create a class TaxCalculator which calculates how much tax a user should pay based on age and salary entered
    
}
