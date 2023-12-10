using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_
{
    public partial class BakerForm : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public BakerForm()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);

        }

        private void BakerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {

        }

       
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterFinancialReport registerFinancialReport = new RegisterFinancialReport();
            registerFinancialReport.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddDish addDish = new AddDish();
            addDish.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRicept addRicept = new AddRicept();
            addRicept.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
