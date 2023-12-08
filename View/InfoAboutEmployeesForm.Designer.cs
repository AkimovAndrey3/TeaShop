namespace TeaShop
{
    partial class InfoAboutEmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteEmployeeBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(751, 428);
            this.DeleteEmployeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(142, 39);
            this.DeleteEmployeeBtn.TabIndex = 4;
            this.DeleteEmployeeBtn.Text = "Удалить";
            this.DeleteEmployeeBtn.UseVisualStyleBackColor = false;
            this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.PhoneNumber,
            this.Status,
            this.workBegin,
            this.workEnd});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(905, 411);
            this.dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Телефон";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Должность";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // workBegin
            // 
            this.workBegin.HeaderText = "Начало работы";
            this.workBegin.MinimumWidth = 6;
            this.workBegin.Name = "workBegin";
            this.workBegin.Width = 125;
            // 
            // workEnd
            // 
            this.workEnd.HeaderText = "Конец работы";
            this.workEnd.MinimumWidth = 6;
            this.workEnd.Name = "workEnd";
            this.workEnd.Width = 125;
            // 
            // InfoAboutEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 478);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InfoAboutEmployeesForm";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteEmployeeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn workBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn workEnd;
    }
}