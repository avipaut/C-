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
    public partial class AddRicept : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public AddRicept()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);

        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Получение данных из формы
                string dishName = txtDishName.Text;
                string recipeDetails = txtRecipeDetails.Text;

                // Проверка наличия блюда в базе
                string checkDishQuery = "SELECT COUNT(*) FROM Dishes WHERE DishName = @DishName";
                using (SQLiteCommand checkDishCmd = new SQLiteCommand(checkDishQuery, connection))
                {
                    checkDishCmd.Parameters.AddWithValue("@DishName", dishName);
                    int dishCount = Convert.ToInt32(checkDishCmd.ExecuteScalar());

                    if (dishCount == 0)
                    {
                        MessageBox.Show("Блюдо с таким названием не найдено. Пожалуйста, добавьте блюдо сначала.");
                        return;
                    }
                }

                // Вставка данных в таблицу рецептов
                string insertRecipeQuery = "INSERT INTO Recipes (DishName, RecipeDetails) VALUES (@DishName, @RecipeDetails)";
                using (SQLiteCommand cmd = new SQLiteCommand(insertRecipeQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@DishName", dishName);
                    cmd.Parameters.AddWithValue("@RecipeDetails", recipeDetails);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Рецепт добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении рецепта: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddRicept_Load(object sender, EventArgs e)
        {

        }
    }
}
