using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            decimal rentAmount;
            decimal DarenAmount;
            decimal LukeAmount;
            decimal CJAmount;
            decimal SeamusAmount;
            lukeRentAmount.Clear();
            darenRentAmount.Clear();
            cjRentAmount.Clear();
            seamusRentAmount.Clear();
            if (!decimal.TryParse(rentTextBox.Text, out rentAmount))
            {
                MessageBox.Show("Error incorrect input please enter a number of the form 100.00");
                rentTextBox.Clear();
            }
            else
            {
                rentAmount = Math.Round(rentAmount - 150, 2);
                LukeAmount = Math.Round(rentAmount / 4, 2);
                if (LukeAmount <= 0)
                {
                    MessageBox.Show("Error incorrect input please enter the correct rent amount");
                    rentTextBox.Clear();
                }
                else
                {
                    CJAmount = SeamusAmount = DarenAmount = LukeAmount + 50;
                    if (LukeAmount + CJAmount + SeamusAmount + DarenAmount < rentAmount + 150)
                    {
                        LukeAmount = Decimal.Add(LukeAmount, .01m);
                        CJAmount = Decimal.Add(CJAmount, .01m);
                        DarenAmount = Decimal.Add(DarenAmount, .01m);
                        SeamusAmount = Decimal.Add(SeamusAmount, .01m);
                    }
                    lukeRentAmount.Text = LukeAmount.ToString();
                    darenRentAmount.Text = DarenAmount.ToString();
                    seamusRentAmount.Text = SeamusAmount.ToString();
                    cjRentAmount.Text = CJAmount.ToString();
                    rentTextBox.Clear();
                }
            }
        }
    }
}
