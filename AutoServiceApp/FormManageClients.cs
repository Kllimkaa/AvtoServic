using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class FormManageClients : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Bogdans Garage;Integrated Security=True";
        private DataSet dataSet;
        private SqlDataAdapter adapter;

        public FormManageClients()
        {
            InitializeComponent();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter();
            SetBackgroundImage();

            // Инициализация колонок ListView
            InitializeListView();

            // Загрузка данных клиентов
            LoadClientsData();
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

        // Инициализация колонок ListView
        private void InitializeListView()
        {
            listViewClients.View = View.Details;
            listViewClients.Columns.Add("Id Клиента", 100);
            listViewClients.Columns.Add("ФИО", 150);
            listViewClients.Columns.Add("Номер Телефона", 120);
            listViewClients.Columns.Add("Номер Автомобиля", 120);
            listViewClients.Columns.Add("Марка Авто", 120);
            listViewClients.Columns.Add("Цвет Авто", 120);
        }

        // Загрузка данных клиентов из базы данных в DataSet и отображение в ListView
        private void LoadClientsData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT Id_Клиента, ФИО, Номер_Телефона, Номер_Автомобиля, Марка_Авто, Цвет_Авто FROM Клиенты";
                    adapter.SelectCommand = new SqlCommand(sql, connection);

                    // Заполняем DataSet
                    dataSet.Clear(); // Очищаем предыдущие данные
                    adapter.Fill(dataSet, "Клиенты");

                    // Отображаем данные в ListView
                    DisplayClients(dataSet.Tables["Клиенты"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных клиентов: " + ex.Message);
            }
        }

        // Отображение клиентов из DataTable в ListView
        private void DisplayClients(DataTable dataTable)
        {
            listViewClients.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["Id_Клиента"].ToString());
                item.SubItems.Add(row["ФИО"].ToString());
                item.SubItems.Add(row["Номер_Телефона"].ToString());
                item.SubItems.Add(row["Номер_Автомобиля"].ToString());
                item.SubItems.Add(row["Марка_Авто"].ToString());
                item.SubItems.Add(row["Цвет_Авто"].ToString());

                listViewClients.Items.Add(item);
            }
        }

        // Добавление нового клиента в базу данных и обновление ListView
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text) ||
                string.IsNullOrWhiteSpace(maskedTxtClientPhone.Text) ||
                string.IsNullOrWhiteSpace(txtCarNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCarBrand.Text) ||
                string.IsNullOrWhiteSpace(txtCarColor.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Клиенты (ФИО, Номер_Телефона, Номер_Автомобиля, Марка_Авто, Цвет_Авто) " +
                                 "VALUES (@ФИО, @НомерТелефона, @НомерАвтомобиля, @МаркаАвто, @ЦветАвто)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ФИО", txtClientName.Text);
                    command.Parameters.AddWithValue("@НомерТелефона", maskedTxtClientPhone.Text);
                    command.Parameters.AddWithValue("@НомерАвтомобиля", txtCarNumber.Text);
                    command.Parameters.AddWithValue("@МаркаАвто", txtCarBrand.Text);
                    command.Parameters.AddWithValue("@ЦветАвто", txtCarColor.Text);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Клиент добавлен успешно!");

                        // Очистка текстовых полей
                        ClearTextBoxes();

                        // Обновление данных клиентов и отображение в ListView
                        LoadClientsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении клиента: " + ex.Message);
            }
        }

        // Редактирование информации о клиенте в базе данных
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите клиента для редактирования!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClientName.Text) ||
                string.IsNullOrWhiteSpace(maskedTxtClientPhone.Text) ||
                string.IsNullOrWhiteSpace(txtCarNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCarBrand.Text) ||
                string.IsNullOrWhiteSpace(txtCarColor.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Клиенты SET ФИО=@ФИО, Номер_Телефона=@НомерТелефона, Номер_Автомобиля=@НомерАвтомобиля, Марка_Авто=@МаркаАвто, Цвет_Авто=@ЦветАвто WHERE Id_Клиента=@Id_Клиента";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ФИО", txtClientName.Text);
                    command.Parameters.AddWithValue("@НомерТелефона", maskedTxtClientPhone.Text);
                    command.Parameters.AddWithValue("@НомерАвтомобиля", txtCarNumber.Text);
                    command.Parameters.AddWithValue("@МаркаАвто", txtCarBrand.Text);
                    command.Parameters.AddWithValue("@ЦветАвто", txtCarColor.Text);
                    command.Parameters.AddWithValue("@Id_Клиента", listViewClients.SelectedItems[0].Text);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Информация о клиенте обновлена успешно!");

                        // Очистка текстовых полей
                        ClearTextBoxes();

                        // Обновление данных клиентов и отображение в ListView
                        LoadClientsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при редактировании клиента: " + ex.Message);
            }
        }

        // Удаление клиента из базы данных
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите клиента для удаления!");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого клиента?", "Удаление клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sql = "DELETE FROM Клиенты WHERE Id_Клиента=@Id_Клиента";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@Id_Клиента", listViewClients.SelectedItems[0].Text);

                        int deleteResult = command.ExecuteNonQuery();
                        if (deleteResult > 0)
                        {
                            MessageBox.Show("Клиент удален успешно!");

                            // Очистка текстовых полей
                            ClearTextBoxes();

                            // Обновление данных клиентов и отображение в ListView
                            LoadClientsData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении клиента: " + ex.Message);
                }
            }
        }

        // Очистка всех текстовых полей
        private void ClearTextBoxes()
        {
            txtClientId.Text = "";
            txtClientName.Text = "";
            maskedTxtClientPhone.Text = "";
            txtCarNumber.Text = "";
            txtCarBrand.Text = "";
            txtCarColor.Text = "";
        }

        // Обновление текстовых полей при изменении выбора в ListView
        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewClients.SelectedItems[0];
                txtClientId.Text = item.Text;
                txtClientName.Text = item.SubItems[1].Text;
                maskedTxtClientPhone.Text = item.SubItems[2].Text; // Заменяем на MaskedTextBox
                txtCarNumber.Text = item.SubItems[3].Text;
                txtCarBrand.Text = item.SubItems[4].Text;
                txtCarColor.Text = item.SubItems[5].Text;
            }
        }
    }
}
