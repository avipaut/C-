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
    public partial class RegisterFinancialReport : Form
    {
        private SQLiteConnection connection;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\source\\repos\\C#\\C#\\BakeryApp.db;Version=3;";

        public RegisterFinancialReport()
        {
            InitializeComponent();
            connection = new SQLiteConnection(connectionString);

        }

        private void btnRegisterFinancialReport_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Получение данных из формы
                string operationType = cmbOperationType.SelectedItem.ToString();
                string operationDetails = txtOperationDetails.Text;

                // Вставка данных в таблицу финансовых отчетов
                string query = "INSERT INTO FinancialReports (OperationType, OperationDetails) VALUES (@OperationType, @OperationDetails)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@OperationType", operationType);
                    cmd.Parameters.AddWithValue("@OperationDetails", operationDetails);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Финансовый отчет зарегистрирован!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации финансового отчета: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void txtOperationDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
