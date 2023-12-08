namespace TeaShop
{
    partial class DeleteEmployeeForm
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
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(106, 86);
            this.DeleteEmployeeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(160, 33);
            this.DeleteEmployeeBtn.TabIndex = 10;
            this.DeleteEmployeeBtn.Text = "Удалить";
            this.DeleteEmployeeBtn.UseVisualStyleBackColor = false;
            this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
            // 
            // NameTxtBox
            // 
            this.IDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTxtBox.Location = new System.Drawing.Point(170, 38);
            this.IDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDTxtBox.Name = "NameTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(180, 26);
            this.IDTxtBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id сотрудника:";
            // 
            // DeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 130);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeleteEmployeeForm";
            this.Text = "Уволить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteEmployeeBtn;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.Label label1;
    }
}