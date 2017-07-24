using System.Windows.Forms;
using AnnualTaxCalculator.Views;

namespace AnnualTaxCalculator
{
    public partial class FrmMain 
        : Form
    {
        private readonly MainFormViewModel _viewModel;

        public FrmMain(MainFormViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            this.BSViewModel.DataSource = _viewModel;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _viewModel.Calculate();
            this.BSViewModel.ResetBindings(false);
        }
    }
    
}
