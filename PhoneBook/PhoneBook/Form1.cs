using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=PhoneBook;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
            ShowData();
        }

        /// <summary>
        /// Метод для отображения данных из базы данных в DataGridView
        /// </summary>
        public void ShowData()
        {
            string sqlExpression = "SELECT * FROM PhoneBook";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression,connection);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                dgvData.DataSource = dataset.Tables[0];
            }
        }
    }
}
