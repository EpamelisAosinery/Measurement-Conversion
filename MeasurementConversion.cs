using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class MeasurementConversion : Form
    {
        //public string[][] unit1 = new string[5][] {{"",""} };
        public string[] measurements =  Enum.GetNames(typeof(Measurement));
        public Dictionary<string, string[]> units = new Dictionary<string, string[]>();
        public MeasurementConversion()
        {
            InitializeComponent();
            foreach(string measurement in measurements)
            {
                cboMeasurement.Items.Add(measurement);
                units.Add(measurement, resolveUnits(measurement));
            }
            cboMeasurement.SelectedIndex = 0;

        }

        private string[] resolveUnits(string measurement)
        {
            switch (measurement)
            {
                case "Length":
                    return Enum.GetNames(typeof(Length));
                case "Mass":
                    return Enum.GetNames(typeof(Mass));
                case "Speed":
                    return Enum.GetNames(typeof(Speed));
                case "Temperature":
                    return Enum.GetNames(typeof(Temperature));
                case "Time":
                    return Enum.GetNames(typeof(Time));
                default:
                    return null;
            }
        }

        private void cmbMeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {
           cboUnit1.Items.Clear();
           cboUnit2.Items.Clear();
            
           foreach(string unit in units[(string)cboMeasurement.SelectedItem]){
                cboUnit1.Items.Add(unit);
                cboUnit2.Items.Add(unit);
           }
            cboUnit1.SelectedIndex = 0;
            cboUnit2.SelectedIndex = 0;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
            if (e.KeyChar == '-' && ((sender as TextBox).Text != ""))
                e.Handled = true;
        }

        /*private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
            if (e.KeyChar == '-' && ((sender as TextBox).Text != ""))
                e.Handled = true;
            //btnCalculate_Click();
        }*/

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            cboUnit2.SelectedItem = 0;
            if (txtInput.Text == null || txtInput.Text.Length == 0)
            {
                txtOutput.Text = "";
                return;
            }
            double numInput = double.Parse(txtInput.Text);
            string measurement = (string) cboMeasurement.SelectedItem;
            string fromUnit = (string) cboUnit1.SelectedItem;
            string toUnit = (string) cboUnit2.SelectedItem;
            txtOutput.Text = Converter.convert(measurement, fromUnit, toUnit, numInput).ToString();
            //txtOutput.Text = numInput.ToString("N");
        }

        /*private void btnReverseCalculate_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == null || txtOutput.Text.Length == 0)
            {
                txtInput.Text = "";
                return;
            }
            double numInput = double.Parse(txtOutput.Text);
            string measurement = (string)cboMeasurement.SelectedItem;
            string fromUnit = (string)cboUnit2.SelectedItem;
            string toUnit = (string)cboUnit1.SelectedItem;
            txtInput.Text = Converter.convert(measurement, fromUnit, toUnit, numInput).ToString();
        }*/
    }
}
