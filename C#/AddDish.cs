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
    public partial class AddDish : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public AddDish()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);

        }

        private void AddDish_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Получение данных из формы
                string dishName = txtDishName.Text;
                decimal dishPrice = decimal.Parse(txtDishPrice.Text);

                // Вставка данных в таблицу блюд
                string query = "INSERT INTO Dishes (DishName, DishPrice) VALUES (@DishName, @DishPrice)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@DishName", dishName);
                    cmd.Parameters.AddWithValue("@DishPrice", dishPrice);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Блюдо добавлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении блюда: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
