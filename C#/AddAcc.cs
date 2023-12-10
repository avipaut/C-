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
    public partial class AddAcc : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public AddAcc()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAccountant_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    connection.Open();

                    // Получение данных из формы
                    string name = txtAccountantName.Text;
                    decimal salary = decimal.Parse(txtAccountantSalary.Text);

                    // Вставка данных в таблицу бухгалтеров
                    string query = "INSERT INTO Accountants (Name, Salary) VALUES (@Name, @Salary)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Salary", salary);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Бухгалтер добавлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении бухгалтера: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void AddAcc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
