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
    public partial class Accaunts : Form
    {

        public Accaunts()
        {
            InitializeComponent();
        }

        private void Accaunts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAcc addAcc = new AddAcc();
            addAcc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DellAcc dellAcc = new DellAcc();
            dellAcc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdAcc updAcc = new UpdAcc();
            updAcc.Show();
        }
    }
}
