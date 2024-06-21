using System;

namespace AutoServiceApp
{
    partial class FormManageClients
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.TextBox txtCarColor;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.Label lblCarNumber;
        private System.Windows.Forms.Label lblCarBrand;
        private System.Windows.Forms.Label lblCarColor;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listViewClients = new System.Windows.Forms.ListView();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.txtCarBrand = new System.Windows.Forms.TextBox();
            this.txtCarColor = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.lblCarNumber = new System.Windows.Forms.Label();
            this.lblCarBrand = new System.Windows.Forms.Label();
            this.lblCarColor = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.maskedTxtClientPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // listViewClients
            // 
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(12, 74);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(917, 300);
            this.listViewClients.TabIndex = 0;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.SelectedIndexChanged += new System.EventHandler(this.listViewClients_SelectedIndexChanged);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(43, 409);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.ReadOnly = true;
            this.txtClientId.Size = new System.Drawing.Size(56, 20);
            this.txtClientId.TabIndex = 1;
            this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(105, 409);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(200, 20);
            this.txtClientName.TabIndex = 2;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Location = new System.Drawing.Point(479, 409);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(138, 20);
            this.txtCarNumber.TabIndex = 4;
            this.txtCarNumber.TextChanged += new System.EventHandler(this.txtCarNumber_TextChanged);
            // 
            // txtCarBrand
            // 
            this.txtCarBrand.Location = new System.Drawing.Point(623, 409);
            this.txtCarBrand.Name = "txtCarBrand";
            this.txtCarBrand.Size = new System.Drawing.Size(162, 20);
            this.txtCarBrand.TabIndex = 5;
            this.txtCarBrand.TextChanged += new System.EventHandler(this.txtCarBrand_TextChanged);
            // 
            // txtCarColor
            // 
            this.txtCarColor.Location = new System.Drawing.Point(791, 409);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.Size = new System.Drawing.Size(138, 20);
            this.txtCarColor.TabIndex = 6;
            this.txtCarColor.TextChanged += new System.EventHandler(this.txtCarColor_TextChanged);
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(37, 393);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(62, 13);
            this.lblClientId.TabIndex = 7;
            this.lblClientId.Text = "ID клиента";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(175, 393);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(34, 13);
            this.lblClientName.TabIndex = 8;
            this.lblClientName.Text = "ФИО";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(344, 393);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(93, 13);
            this.lblClientPhone.TabIndex = 9;
            this.lblClientPhone.Text = "Номер телефона";
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.Location = new System.Drawing.Point(494, 393);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(105, 13);
            this.lblCarNumber.TabIndex = 10;
            this.lblCarNumber.Text = "Номер автомобиля";
            // 
            // lblCarBrand
            // 
            this.lblCarBrand.AutoSize = true;
            this.lblCarBrand.Location = new System.Drawing.Point(667, 393);
            this.lblCarBrand.Name = "lblCarBrand";
            this.lblCarBrand.Size = new System.Drawing.Size(66, 13);
            this.lblCarBrand.TabIndex = 11;
            this.lblCarBrand.Text = "Марка авто";
            // 
            // lblCarColor
            // 
            this.lblCarColor.AutoSize = true;
            this.lblCarColor.Location = new System.Drawing.Point(824, 393);
            this.lblCarColor.Name = "lblCarColor";
            this.lblCarColor.Size = new System.Drawing.Size(58, 13);
            this.lblCarColor.TabIndex = 12;
            this.lblCarColor.Text = "Цвет авто";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(12, 550);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(146, 56);
            this.btnAddClient.TabIndex = 13;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(178, 550);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(146, 56);
            this.btnEditClient.TabIndex = 14;
            this.btnEditClient.Text = "Редактировать клиента";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(347, 550);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(146, 56);
            this.btnDeleteClient.TabIndex = 15;
            this.btnDeleteClient.Text = "Удалить клиента";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // maskedTxtClientPhone
            // 
            this.maskedTxtClientPhone.Location = new System.Drawing.Point(311, 409);
            this.maskedTxtClientPhone.Mask = "+7 (999) 000-0000";
            this.maskedTxtClientPhone.Name = "maskedTxtClientPhone";
            this.maskedTxtClientPhone.Size = new System.Drawing.Size(162, 20);
            this.maskedTxtClientPhone.TabIndex = 16;
            // 
            // FormManageClients
            // 
            this.ClientSize = new System.Drawing.Size(964, 618);
            this.Controls.Add(this.maskedTxtClientPhone);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblCarColor);
            this.Controls.Add(this.lblCarBrand);
            this.Controls.Add(this.lblCarNumber);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.txtCarColor);
            this.Controls.Add(this.txtCarBrand);
            this.Controls.Add(this.txtCarNumber);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.listViewClients);
            this.Name = "FormManageClients";
            this.Text = "Управление клиентами";
            this.Load += new System.EventHandler(this.FormManageClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormManageClients_Load(object sender, EventArgs e)
        {
        }

        private void txtCarColor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCarBrand_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCarNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtClientPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
        }

        private System.Windows.Forms.MaskedTextBox maskedTxtClientPhone;
    }
}
