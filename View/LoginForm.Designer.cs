namespace TeaShop.View
{
    partial class LoginForm
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RegisterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterBtn.Location = new System.Drawing.Point(158, 101);
            this.RegisterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(223, 36);
            this.RegisterBtn.TabIndex = 53;
            this.RegisterBtn.Text = "Зарегистрироваться";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Email: ";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(107, 20);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(274, 20);
            this.email.TabIndex = 51;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBtn.Location = new System.Drawing.Point(11, 101);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(143, 36);
            this.LoginBtn.TabIndex = 50;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Пароль: ";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(107, 52);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(274, 20);
            this.password.TabIndex = 54;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 146);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.LoginBtn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
    }
}