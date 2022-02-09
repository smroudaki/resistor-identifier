using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResistorIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbFirstBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFirstBand.Text)
            {
                case "Black": txtResult.Text += "0"; cmbFirstBand.ForeColor = Color.Black; break;
                case "Brown": txtResult.Text += "1"; cmbFirstBand.ForeColor = Color.Brown; break;
                case "Red": txtResult.Text += "2"; cmbFirstBand.ForeColor = Color.Red; break;
                case "Orange": txtResult.Text += "3"; cmbFirstBand.ForeColor = Color.Orange; break;
                case "Yellow": txtResult.Text += "4"; cmbFirstBand.ForeColor = Color.Yellow; break;
                case "Green": txtResult.Text += "5"; cmbFirstBand.ForeColor = Color.Green; break;
                case "Blue": txtResult.Text += "6"; cmbFirstBand.ForeColor = Color.Blue; break;
                case "Purple": txtResult.Text += "7"; cmbFirstBand.ForeColor = Color.Purple; break;
                case "Gray": txtResult.Text += "8"; cmbFirstBand.ForeColor = Color.Gray; break;
                case "White": txtResult.Text += "9"; cmbFirstBand.ForeColor = Color.White; break;

                default: txtResult.Text += ""; break;
            }
        }

        private void cmbSecondBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSecondBand.Text)
            {
                case "Black": txtResult.Text += "0"; cmbSecondBand.ForeColor = Color.Black; break;
                case "Brown": txtResult.Text += "1"; cmbSecondBand.ForeColor = Color.Brown; break;
                case "Red": txtResult.Text += "2"; cmbSecondBand.ForeColor = Color.Red; break;
                case "Orange": txtResult.Text += "3"; cmbSecondBand.ForeColor = Color.Orange; break;
                case "Yellow": txtResult.Text += "4"; cmbSecondBand.ForeColor = Color.Yellow; break;
                case "Green": txtResult.Text += "5"; cmbSecondBand.ForeColor = Color.Green; break;
                case "Blue": txtResult.Text += "6"; cmbSecondBand.ForeColor = Color.Blue; break;
                case "Purple": txtResult.Text += "7"; cmbSecondBand.ForeColor = Color.Purple; break;
                case "Gray": txtResult.Text += "8"; cmbSecondBand.ForeColor = Color.Gray; break;
                case "White": txtResult.Text += "9"; cmbSecondBand.ForeColor = Color.White; break;

                default: txtResult.Text += ""; break;
            }
        }

        private void cmbThirdBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbThirdBand.Text)
            {
                case "Black": txtResult.Text += ""; cmbThirdBand.ForeColor = Color.Black; break;
                case "Brown": txtResult.Text += "0"; cmbThirdBand.ForeColor = Color.Brown; break;
                case "Red": txtResult.Text += "00"; cmbThirdBand.ForeColor = Color.Red; break;
                case "Orange": txtResult.Text += "000"; cmbThirdBand.ForeColor = Color.Orange; break;
                case "Yellow": txtResult.Text += "0000"; cmbThirdBand.ForeColor = Color.Yellow; break;
                case "Green": txtResult.Text += "00000"; cmbThirdBand.ForeColor = Color.Green; break;
                case "Blue": txtResult.Text += "000000"; cmbThirdBand.ForeColor = Color.Blue; break;
                case "Purple": txtResult.Text += "0000000"; cmbThirdBand.ForeColor = Color.Purple; break;
                case "Gray": txtResult.Text += "00000000"; cmbThirdBand.ForeColor = Color.Gray; break;
                case "White": txtResult.Text += "000000000"; cmbThirdBand.ForeColor = Color.White; break;

                default: txtResult.Text += ""; break;
            }

            lblResistance.Focus();
            txtTolerance.Text = ((Convert.ToInt32(txtResult.Text) * 5) / 100).ToString();
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cmbUnit.Text)
                {
                    case "Kiloo":
                        {
                            txtUnit.Text = ((Convert.ToInt32(txtResult.Text)) / (Math.Pow(10, 3))).ToString();
                            lblUnit.Text = "K";
                            break;
                        }

                    case "Mega":
                        txtUnit.Text = (Convert.ToInt32(txtResult.Text) / Math.Pow(10, 6)).ToString();
                        lblUnit.Text = "M";
                        break;

                    default: txtResult.Text = ""; break;
                }
            }
            catch { MessageBox.Show("No Value For Resistance !"); } //how to change cmbUnit.Text after catch ?
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
            txtTolerance.ResetText();
            txtUnit.ResetText();

            cmbFirstBand.Text = "Select";
            cmbSecondBand.Text = "Select";
            cmbThirdBand.Text = "Select";
            cmbUnit.Text = "Unit";
            lblUnit.Text = "";

            cmbFirstBand.ForeColor = Color.Black;
            cmbSecondBand.ForeColor = Color.Black;
            cmbThirdBand.ForeColor = Color.Black;
        }
    }
}