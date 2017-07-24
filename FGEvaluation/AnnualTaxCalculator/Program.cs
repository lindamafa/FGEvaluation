using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnnualTaxCalculator.Models;
using AnnualTaxCalculator.Views;

namespace AnnualTaxCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var person = new Person { DateOfBirth = DateTime.Now };
            var viewModel = new MainFormViewModel(person);
            Application.Run(new FrmMain(viewModel));
        }
    }
}
