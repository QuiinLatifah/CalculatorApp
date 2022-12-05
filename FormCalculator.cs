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
        public delegate void CreateEventHandler(Calculator calc);

        public event CreateEventHandler OnCreate;

        private bool isNewData = true;

        private Calculator calc;
        
        public FormCalculator()
        {
            InitializeComponent();
        }

        public string select;
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) calc = new Calculator();

            if( select == "Penjumlahan")
            {
               calc.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + (int.Parse(txtNilaiB.Text)));
            }
            else if (select == "Pengurangan")
            {
                calc.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - (int.Parse(txtNilaiB.Text)));
            }
            else if (select == "Perkalian")
            {
                calc.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * (int.Parse(txtNilaiB.Text)));
            }
            else if (select == "Pembagian")
            {
                calc.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " / " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) / (int.Parse(txtNilaiB.Text)));
            }

            if (isNewData)
            {
                OnCreate(calc);
            }
        }
        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = cmbOperasi.SelectedItem.ToString();
        }
    }
}
