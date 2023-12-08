namespace TeaShop.View
{
    partial class RegisterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.shopBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Пароль: ";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(157, 43);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(256, 20);
            this.password.TabIndex = 59;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterBtn.Location = new System.Drawing.Point(109, 229);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(223, 36);
            this.RegisterBtn.TabIndex = 58;
            this.RegisterBtn.Text = "Зарегистрироваться";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Email: ";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(157, 11);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(256, 20);
            this.email.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Имя:";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(157, 74);
            this.fname.Margin = new System.Windows.Forms.Padding(2);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(256, 20);
            this.fname.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Фамилия:";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(157, 107);
            this.lname.Margin = new System.Windows.Forms.Padding(2);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(256, 20);
            this.lname.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Номер телефона:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(157, 137);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(256, 20);
            this.phoneNumber.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Должность:";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Консультант",
            "Менеджер"});
            this.status.Location = new System.Drawing.Point(157, 193);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(256, 21);
            this.status.TabIndex = 69;
            // 
            // shopBox
            // 
            this.shopBox.FormattingEnabled = true;
            this.shopBox.Items.AddRange(new object[] {
            ""});
            this.shopBox.Location = new System.Drawing.Point(157, 164);
            this.shopBox.Name = "shopBox";
            this.shopBox.Size = new System.Drawing.Size(256, 21);
            this.shopBox.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Магазин:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 276);
            this.Controls.Add(this.shopBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.ComboBox shopBox;
        private System.Windows.Forms.Label label7;
    }
}