using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class FormManageWorks : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bogdans Garage;Integrated Security=True";

        public FormManageWorks()
        {
            InitializeComponent();
            SetBackgroundImage();

            // Настройка колонок ListView
            listViewWorks.View = View.Details;
            listViewWorks.Columns.Add("ID", 50);
            listViewWorks.Columns.Add("Название работы", 150);
            listViewWorks.Columns.Add("Описание", 250);
            listViewWorks.Columns.Add("Стоимость", 100);
            listViewWorks.Columns.Add("Дата начала", 100);
            listViewWorks.Columns.Add("Дата окончания", 100);
            listViewWorks.Columns.Add("ID Клиента", 100);
            

            LoadWorks();
        }

        private void SetBackgroundImage()
        {
            try
            {
                this.BackgroundImage = Properties.Resources.fon;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке фона: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormManageWorks_Load(object sender, EventArgs e)
        {
            LoadWorks();
        }

        private void LoadWorks()
        {
            listViewWorks.Items.Clear();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string sql = "SELECT * FROM Работы ORDER BY Id_Работы";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Id_Работы"].ToString());
                        item.SubItems.Add(reader["Название_Работы"].ToString());
                        item.SubItems.Add(reader["Описание"].ToString());
                        item.SubItems.Add(reader["Стоимость"].ToString());
                        item.SubItems.Add(reader["Дата_Начала"].ToString());
                        item.SubItems.Add(reader["Дата_Окончания"].ToString());
                        item.SubItems.Add(reader["Id_Клиента"].ToString());

                        listViewWorks.Items.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки работ: " + ex.Message);
            }
        }


        private void btnAddWork_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWorkName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtCost.Text) ||
                string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string sql = "INSERT INTO Работы (Название_Работы, Описание, Стоимость, Дата_Начала, Дата_Окончания, Id_Клиента) " +
                                 "VALUES (@Название_Работы, @Описание, @Стоимость, @Дата_Начала, @Дата_Окончания, @Id_Клиента)";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Название_Работы", txtWorkName.Text);
                    sqlCommand.Parameters.AddWithValue("@Описание", txtDescription.Text);
                    sqlCommand.Parameters.AddWithValue("@Стоимость", txtCost.Text);
                    sqlCommand.Parameters.AddWithValue("@Дата_Начала", dtpStartDate.Value);
                    sqlCommand.Parameters.AddWithValue("@Дата_Окончания", dtpEndDate.Value);
                    sqlCommand.Parameters.AddWithValue("@Id_Клиента", txtClientId.Text);

                    sqlCommand.ExecuteNonQuery();

                    LoadWorks();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления работы: " + ex.Message);
            }
        }

        private void btnEditWork_Click(object sender, EventArgs e)
        {
            if (listViewWorks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите работу для редактирования.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtWorkName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtCost.Text) ||
                string.IsNullOrWhiteSpace(txtClientId.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string sql = "UPDATE Работы SET Название_Работы = @Название_Работы, Описание = @Описание, Стоимость = @Стоимость, " +
                                 "Дата_Начала = @Дата_Начала, Дата_Окончания = @Дата_Окончания, Id_Клиента = @Id_Клиента " +
                                 "WHERE Id_Работы = @Id_Работы";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Название_Работы", txtWorkName.Text);
                    sqlCommand.Parameters.AddWithValue("@Описание", txtDescription.Text);
                    sqlCommand.Parameters.AddWithValue("@Стоимость", txtCost.Text);
                    sqlCommand.Parameters.AddWithValue("@Дата_Начала", dtpStartDate.Value);
                    sqlCommand.Parameters.AddWithValue("@Дата_Окончания", dtpEndDate.Value);
                    sqlCommand.Parameters.AddWithValue("@Id_Клиента", txtClientId.Text);
                    sqlCommand.Parameters.AddWithValue("@Id_Работы", listViewWorks.SelectedItems[0].Text);

                    sqlCommand.ExecuteNonQuery();

                    LoadWorks();
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования работы: " + ex.Message);
            }
        }

        private void btnDeleteWork_Click(object sender, EventArgs e)
        {
            if (listViewWorks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите работу для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту работу?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();

                        // Удаление выбранных записей
                        foreach (ListViewItem selectedItem in listViewWorks.SelectedItems)
                        {
                            int idToRemove = int.Parse(selectedItem.Text);
                            string sqlDelete = "DELETE FROM Работы WHERE Id_Работы = @Id_Работы";
                            SqlCommand sqlCommandDelete = new SqlCommand(sqlDelete, sqlConnection);
                            sqlCommandDelete.Parameters.AddWithValue("@Id_Работы", idToRemove);
                            sqlCommandDelete.ExecuteNonQuery();

                            // Опционально: можно добавить логику обновления id через DBCC CHECKIDENT,
                            // однако, учтите, что это может повлиять на производительность при большом объеме данных.
                        }

                        LoadWorks();
                        ClearTextBoxes();

                        MessageBox.Show("Работа(-ы) успешно удалена(-ы).");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка удаления работы: " + ex.Message);
                }
            }
        }

        private void ClearTextBoxes()
        {
            txtWorkName.Text = "";
            txtDescription.Text = "";
            txtCost.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            txtClientId.Text = "";
        }

        private void listViewWorks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWorks.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewWorks.SelectedItems[0];
                txtWorkName.Text = item.SubItems[1].Text;
                txtDescription.Text = item.SubItems[2].Text;
                txtCost.Text = item.SubItems[3].Text;
                dtpStartDate.Value = DateTime.Parse(item.SubItems[4].Text);
                dtpEndDate.Value = DateTime.Parse(item.SubItems[5].Text);
                txtClientId.Text = item.SubItems[6].Text;
            }
        }
    }
}
