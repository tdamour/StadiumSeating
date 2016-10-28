using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumSeating
{
    public partial class StadiumSeating : Form
    {
        public StadiumSeating()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassASeats.Text = "";
            txtClassBSeats.Text = "";
            txtClassCSeats.Text = "";

            revA.Text = "";
            revB.Text = "";
            revC.Text = "";
            Total.Text = ""; 

        }

        private void btnCalcRev_Click(object sender, EventArgs e)
        {
            int aSeats, bSeats, cSeats;
            double aRevTotal, bRevTotal,cRevTotal,total;

            aSeats = int.Parse(txtClassASeats.Text);
            bSeats = int.Parse(txtClassBSeats.Text);
            cSeats = int.Parse(txtClassCSeats.Text);

            aRevTotal = aSeats * 15.0;
            bRevTotal = bSeats * 12.0;
            cRevTotal = cSeats * 9.0;

            total = aRevTotal + bRevTotal + cRevTotal;

            revA.Text = aRevTotal.ToString("C");
            revB.Text = bRevTotal.ToString("C");
            revC.Text = cRevTotal.ToString("C");

            Total.Text = total.ToString("C"); 

        }
    }
}
