using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusExpense
{
    public partial class FormBus : Form
    {
        public FormBus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded); //inline variable creation
            bool costOneParkWithCardValid = Double.TryParse(txtOneParkWithCard.Text, out double costOneParkWithCard);
            bool costOneParkNoCardValid = Double.TryParse(txtOneParkNoCard.Text, out double costOneparkNoCard);

            if (creditValid && costOneParkWithCardValid && costOneParkNoCardValid)
            {
                int daysParking = (int)(creditAdded / costOneParkWithCard);
                double creditRemaining = creditAdded % costOneParkWithCard;
                double oneDaySavings = costOneparkNoCard - costOneParkWithCard;
                double totalSavings = daysParking * oneDaySavings;

                txtDaysParking.Text = daysParking.ToString();
                txtCreditRemaining.Text = creditRemaining.ToString("c");
                txtSavings.Text = totalSavings.ToString("c");
            }
            else
            {
                MessageBox.Show("Please enter numbers", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
