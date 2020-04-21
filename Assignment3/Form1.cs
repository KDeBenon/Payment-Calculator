using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLoanAmount.Select();
            cmbYears.SelectedIndex = 5;
        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            // Declare all variables
            double loanAmount, interestRate, monthlyPayment, totalPaid, interestPaid;
            int years, numberOfPayments;

            // Assign values to variables
            // User input
            try
            {
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);
                errorProvider1.SetError(txtLoanAmount, "");
            }
            catch
            {
                // MessageBox.Show("Invalid Loan Amount");
                errorProvider1.SetError(txtLoanAmount, "Invalid Loan Amount");
                txtLoanAmount.Select();
                return;
            }
            try
            {
                interestRate = Convert.ToDouble(txtFixedInterestRate.Text);
                errorProvider1.SetError(txtFixedInterestRate, "");
            }
            catch
            {
                // MessageBox.Show("Invalid Interest Rate!");
                errorProvider1.SetError(txtFixedInterestRate, "Invalid Interest Rate");
                txtFixedInterestRate.Select();
                return;
            }


            loanAmount = Convert.ToDouble(txtLoanAmount.Text);
            interestRate = Convert.ToDouble(txtFixedInterestRate.Text);
            years = Convert.ToInt32(cmbYears.Text);
            // Calculated
            monthlyPayment = calcPayment(loanAmount, years, interestRate);
            numberOfPayments = 12 * years;
            totalPaid = monthlyPayment * numberOfPayments;
            interestPaid = totalPaid - loanAmount;

            // Place values on screen

            // txtMonthlyPayment.Text = Convert.ToString(monthlyPayment);
            txtMonthlyPayment.Text = String.Format("{0:c}",monthlyPayment);
            txtNumberOfPayments.Text = Convert.ToString(numberOfPayments);
            txtPaymentTotal.Text = String.Format("{0:c}", totalPaid);
            txtInterestPaid.Text = String.Format("{0:c}", interestPaid);

        }

        public double calcPayment(double presentValue, double financingPeriod, double interestRatePerYear)
        {
            double a, b, x;
            double monthlyPayment;
            a = (1 + interestRatePerYear / 1200);
            b = financingPeriod * 12;
            x = Math.Pow(a, b);
            x = 1 / x;
            x = 1 - x;
            monthlyPayment = (presentValue) * (interestRatePerYear / 1200) / x;
            return (monthlyPayment);
        }

        private void txtLoanAmount_Validating(object sender, CancelEventArgs e)
        {
            double loanAmount;
            try
            {
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);
                errorProvider1.SetError(txtLoanAmount, "");
            }
            catch
            {
                // MessageBox.Show("Invalid Loan Amount");
                errorProvider1.SetError(txtLoanAmount, "Invalid Loan Amount");
                // txtLoanAmount.Select();
                return;
            }
        }

        private void txtFixedInterestRate_Validating(object sender, CancelEventArgs e)
        {
            double interestRate;
            try
            {
                interestRate = Convert.ToDouble(txtFixedInterestRate.Text);
                errorProvider1.SetError(txtFixedInterestRate, "");
            }
            catch
            {
                // MessageBox.Show("Invalid Interest Rate!");
                errorProvider1.SetError(txtFixedInterestRate, "Invalid Interest Rate");
                // txtFixedInterestRate.Select();
                return;
            }
        }
    }
}
