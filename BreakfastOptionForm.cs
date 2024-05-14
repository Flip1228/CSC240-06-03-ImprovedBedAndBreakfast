using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_06_01_BedAndBreakfast_MB
{
    public partial class BreakfastOptionForm : Form
    {
        private const double CONT_BREAKFAST_PRICE = 6.00;
        private const double FULL_BREAKFAST_PRICE = 9.95;
        private const double DELUXE_BREAKFAST_PRICE = 16.50;
        public BreakfastOptionForm()
        {
            InitializeComponent();
        }

        private void BreakfastOptionForm_Load(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void ContRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + CONT_BREAKFAST_PRICE.ToString("C");
        }

        private void FullRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + FULL_BREAKFAST_PRICE.ToString("C");
        }

        private void DeluxeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + DELUXE_BREAKFAST_PRICE.ToString("C");
        }
    }




}




