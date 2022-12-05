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
    public partial class FormHasilPerhitungan : Form
    {
        private IList<Calculator> listCalculator = new List<Calculator>();
        public FormHasilPerhitungan()
        {
            InitializeComponent();
        }
        private void FormEntry_OnCreate(Calculator calc)
        {
            listCalculator.Clear();
            listCalculator.Add(calc);
            listHasil.Items.Add(calc.Hasil);
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            FormCalculator formCalc = new FormCalculator();
            formCalc.OnCreate += FormEntry_OnCreate;
            formCalc.ShowDialog();
        }
    }
}
