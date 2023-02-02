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
    public partial class FormCalculator : Form
    {
        public delegate void InputEventHandler(Calculator calc);

        public event InputEventHandler OnInput;

        private bool isNewData = true;

        private Calculator calc;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) calc = new Calculator();

            if (cmbOperasi.Text == "Penjumlahan")
            {
                calc.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
            }
            else if (cmbOperasi.Text == "Pengurangan")
            {
                calc.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));
            }
            else if (cmbOperasi.Text == "Perkalian")
            {
                calc.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
            }
            else if (cmbOperasi.Text == "Pembagian")
            {
                calc.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " : " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) / int.Parse(txtNilaiB.Text));
            }

            if (isNewData)
            {
                OnInput(calc);
            }
        }
    }
}
