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
    public partial class DellAcc : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public DellAcc()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);

        }

        private void btnDeleteAccountant_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Получение данных из формы
                int accountantID = int.Parse(txtAccountantID.Text);

                // Удаление бухгалтера по ID
                string query = "DELETE FROM Accountants WHERE ID = @AccountantID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AccountantID", accountantID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Бухгалтер удален!");
                    }
                    else
                    {
                        MessageBox.Show("Бухгалтер с указанным ID не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении бухгалтера: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void DellAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
