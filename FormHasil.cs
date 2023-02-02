using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FormHasil : Form
    {
        private IList<Calculator> listOfCalc = new List<Calculator>();
        public FormHasil()
        {
            InitializeComponent();
        }
        private void FormCalculator_OnInput(Calculator calc)
        {
            listOfCalc.Clear();
            listOfCalc.Add(calc);
            listHasil.Items.Add(calc.Hasil);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FormCalculator frmCal = new FormCalculator();
            frmCal.OnInput += FormCalculator_OnInput;
            frmCal.ShowDialog();
        }
    }
}
