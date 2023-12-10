using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_
{
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegisterFinancialReport registerFinancialReport = new RegisterFinancialReport();
            registerFinancialReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accaunts accaunts = new Accaunts();
            accaunts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDish addDish = new AddDish();   
            addDish.Show(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRicept addRicept = new AddRicept();
            addRicept.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DelDish delDish = new DelDish();
            delDish.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
