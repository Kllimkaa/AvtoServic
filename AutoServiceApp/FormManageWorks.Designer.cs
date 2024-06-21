using System;

namespace AutoServiceApp
{
    partial class FormManageWorks
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewWorks;
        private System.Windows.Forms.TextBox txtWorkId;
        private System.Windows.Forms.TextBox txtWorkName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblWorkId;
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Button btnAddWork;
        private System.Windows.Forms.Button btnEditWork;
        private System.Windows.Forms.Button btnDeleteWork;

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
            this.listViewWorks = new System.Windows.Forms.ListView();
            this.txtWorkId = new System.Windows.Forms.TextBox();
            this.txtWorkName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblWorkId = new System.Windows.Forms.Label();
            this.lblWorkName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.btnEditWork = new System.Windows.Forms.Button();
            this.btnDeleteWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewWorks
            // 
            this.listViewWorks.HideSelection = false;
            this.listViewWorks.Location = new System.Drawing.Point(12, 12);
            this.listViewWorks.Name = "listViewWorks";
            this.listViewWorks.Size = new System.Drawing.Size(856, 309);
            this.listViewWorks.TabIndex = 0;
            this.listViewWorks.UseCompatibleStateImageBehavior = false;
            this.listViewWorks.View = System.Windows.Forms.View.Details;
            this.listViewWorks.SelectedIndexChanged += new System.EventHandler(this.listViewWorks_SelectedIndexChanged);
            // 
            // txtWorkId
            // 
            this.txtWorkId.Location = new System.Drawing.Point(15, 380);
            this.txtWorkId.Name = "txtWorkId";
            this.txtWorkId.Size = new System.Drawing.Size(100, 20);
            this.txtWorkId.TabIndex = 1;
            this.txtWorkId.TextChanged += new System.EventHandler(this.txtWorkId_TextChanged);
            // 
            // txtWorkName
            // 
            this.txtWorkName.Location = new System.Drawing.Point(133, 380);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(150, 20);
            this.txtWorkName.TabIndex = 2;
            this.txtWorkName.TextChanged += new System.EventHandler(this.txtWorkName_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(303, 380);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(472, 380);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 4;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 456);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 20);
            this.dtpStartDate.TabIndex = 5;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(183, 456);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 20);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(353, 456);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(150, 20);
            this.txtClientId.TabIndex = 7;
            this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
            // 
            // lblWorkId
            // 
            this.lblWorkId.AutoSize = true;
            this.lblWorkId.Location = new System.Drawing.Point(22, 355);
            this.lblWorkId.Name = "lblWorkId";
            this.lblWorkId.Size = new System.Drawing.Size(18, 13);
            this.lblWorkId.TabIndex = 8;
            this.lblWorkId.Text = "ID";
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Location = new System.Drawing.Point(130, 355);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(97, 13);
            this.lblWorkName.TabIndex = 9;
            this.lblWorkName.Text = "Название работы";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(300, 355);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(57, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Описание";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(470, 355);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(102, 13);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Стоимость работы";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 428);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(71, 13);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Дата начала";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(180, 428);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(89, 13);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "Дата окончания";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(350, 428);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(63, 13);
            this.lblClientId.TabIndex = 14;
            this.lblClientId.Text = "ID Клиента";
            // 
            // btnAddWork
            // 
            this.btnAddWork.Location = new System.Drawing.Point(12, 533);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(100, 30);
            this.btnAddWork.TabIndex = 15;
            this.btnAddWork.Text = "Добавить";
            this.btnAddWork.UseVisualStyleBackColor = true;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // btnEditWork
            // 
            this.btnEditWork.Location = new System.Drawing.Point(118, 533);
            this.btnEditWork.Name = "btnEditWork";
            this.btnEditWork.Size = new System.Drawing.Size(100, 30);
            this.btnEditWork.TabIndex = 16;
            this.btnEditWork.Text = "Редактировать";
            this.btnEditWork.UseVisualStyleBackColor = true;
            this.btnEditWork.Click += new System.EventHandler(this.btnEditWork_Click);
            // 
            // btnDeleteWork
            // 
            this.btnDeleteWork.Location = new System.Drawing.Point(224, 533);
            this.btnDeleteWork.Name = "btnDeleteWork";
            this.btnDeleteWork.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteWork.TabIndex = 17;
            this.btnDeleteWork.Text = "Удалить";
            this.btnDeleteWork.UseVisualStyleBackColor = true;
            this.btnDeleteWork.Click += new System.EventHandler(this.btnDeleteWork_Click);
            // 
            // FormManageWorks
            // 
            this.ClientSize = new System.Drawing.Size(904, 575);
            this.Controls.Add(this.btnDeleteWork);
            this.Controls.Add(this.btnEditWork);
            this.Controls.Add(this.btnAddWork);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWorkName);
            this.Controls.Add(this.lblWorkId);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtWorkName);
            this.Controls.Add(this.txtWorkId);
            this.Controls.Add(this.listViewWorks);
            this.Name = "FormManageWorks";
            this.Text = "Управление работами";
            this.Load += new System.EventHandler(this.FormManageWorks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void txtWorkId_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtWorkName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
