using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeaShop.Controllers;

namespace TeaShop.View
{
    public partial class LoginForm : Form
    {
        private MainController _mainController;

        public LoginForm(MainController mainController)
        {
            InitializeComponent();
            _mainController = mainController;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            LoginResult result = UserController.LoginUser(email.Text, password.Text);
            switch (result)
            {
                case LoginResult.Done:
                    MessageBox.Show("Вы успешно вошли");
                    Close();
                    break;
                case LoginResult.WrongEmail:
                    MessageBox.Show("Неверный email");
                    break;
                case LoginResult.WrongPassword:
                    MessageBox.Show("Неверный пароль");
                    break;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_mainController);
            registerForm.ShowDialog();
        }
    }
}
