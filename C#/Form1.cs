using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace C_
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Получение данных из формы
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string userType = cmbAccountType.SelectedItem.ToString();

                // Вставка данных в базу данных
                string query = "INSERT INTO Users (Username, Password, UserType) VALUES (@Username, @Password, @UserType)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Регистрация успешна!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Form1 registrationForm = this; // Сохраняем ссылку на текущую форму регистрации

            try
            {
                connection.Open();

                // Получение данных из формы
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string userType = cmbAccountType.SelectedItem.ToString();

                // Вставка данных в базу данных
                string query = "INSERT INTO Users (Username, Password, UserType) VALUES (@Username, @Password, @UserType)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@UserType", userType);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Регистрация успешна!");
                if (userType == "Пекарь")
                {
                    
                    BakerForm bakerForm = new BakerForm();
                    bakerForm.Show();
                }
                else if (userType == "Бухгалтер")
                {
                   
                    AccountantForm accountantForm = new AccountantForm();
                    accountantForm.Show();
                }

                // Закрытие текущей формы регистрации
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void CloseRegistrationForm()
        {
            // Ищем форму регистрации и закрываем ее
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Close();
                    break; // Прерываем цикл после закрытия формы регистрации
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
