using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetBackgroundImage();
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы управления клиентами
            FormManageClients formManageClients = new FormManageClients();
            formManageClients.ShowDialog(); 
        }

        private void btnManageWorks_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы управления работами
            FormManageWorks formManageWorks = new FormManageWorks();
            formManageWorks.ShowDialog();
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
    }
}
