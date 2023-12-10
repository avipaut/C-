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
    public partial class UpdAcc : Form

    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public UpdAcc()
        {
            connection = new SQLiteConnection(connectionString);

            InitializeComponent();
        }

        private void UpdAcc_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Получение данных из формы
                int accountantID = int.Parse(txtAccountantID.Text);
                decimal newSalary = decimal.Parse(txtNewSalary.Text);

                // Обновление зарплаты бухгалтера
                string query = "UPDATE Accountants SET Salary = @NewSalary WHERE ID = @AccountantID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NewSalary", newSalary);
                    cmd.Parameters.AddWithValue("@AccountantID", accountantID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Зарплата обновлена!");
                    }
                    else
                    {
                        MessageBox.Show("Бухгалтер с указанным ID не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении зарплаты: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
