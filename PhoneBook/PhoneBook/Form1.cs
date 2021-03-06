using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        const string CONNECTION_STRING = "Server=(localdb)\\MSSQLLocalDB;Initial Catalog=PhoneBook;Integrated Security=True;";
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            ShowData();
            btnDelete.Enabled = false;
        }

        SqlConnection connection = new SqlConnection(CONNECTION_STRING);
        
        /// <summary>
        /// Метод для отображения данных из базы данных в DataGridView
        /// </summary>
        public void ShowData()
        {
                SqlDataAdapter adapter = new SqlDataAdapter("sp_SelectAllContacts", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvData.DataSource = dataTable;
                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbPhone.Text != "")
            {
                    SqlCommand command = new SqlCommand("sp_AddOrUpdateContact", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@FirstName", tbFirstName.Text.Trim());
                    command.Parameters.AddWithValue("@LastName", tbLastName.Text.Trim());
                    command.Parameters.AddWithValue("@Phone", tbPhone.Text.Trim());
                    command.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                    command.Parameters.AddWithValue("@Adress", tbAdress.Text.Trim());
                    command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Fill all the required fields");
            }
            ShowData();
            btnClear_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                SqlCommand command = new SqlCommand("sp_DeleteContactById", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();

            ShowData();
            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbAdress.Text = string.Empty;

            Id = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// Позволяет нажимать на строку в DataGridView и переносить данные в textbox'ы для дальнейшего редактирования/удаления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow.Index != -1)
            {
                Id = Convert.ToInt32(dgvData.CurrentRow.Cells[0].Value.ToString());
                tbFirstName.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                tbLastName.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                tbPhone.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
                tbEmail.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
                tbAdress.Text = dgvData.CurrentRow.Cells[5].Value.ToString();

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        /// <summary>
        /// Событие, которое улавливает изменение текста в tbSearch и выводит в DataGried данные, соответствующие tbSearch.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
                SqlDataAdapter adapter = new SqlDataAdapter("sp_Search", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@SearchText", tbSearch.Text);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvData.DataSource = dataTable;
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "")
            {
                lbFirstNameAsterisk.Visible = true;
            }
            else
            {
                lbFirstNameAsterisk.Visible = false;
            }
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
            {
                lbPhoneAsterisk.Visible = true;
            }
            else
            {
                lbPhoneAsterisk.Visible = false;
            }
        }

        /// <summary>
        /// Событие при закрытие формы, проверяющее, сохранил ли пользователь свои данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbFirstName.Text == "" && tbLastName.Text == "" && tbPhone.Text == "" && tbEmail.Text == "" && tbAdress.Text == "")
            {
                Application.ExitThread();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to exit without saving your data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    connection.Close();
                    Application.ExitThread();
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
        }
    }
}
