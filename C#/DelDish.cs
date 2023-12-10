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
    public partial class DelDish : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public DelDish()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);

        }

        private void DelDish_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Получение данных из формы
                int dishID = int.Parse(txtDishID.Text);

                // Удаление блюда по ID
                string query = "DELETE FROM Dishes WHERE DishID = @DishID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DishID", dishID);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Блюдо удалено!");
                    }
                    else
                    {
                        MessageBox.Show("Блюдо с указанным ID не найдено.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении блюда: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
