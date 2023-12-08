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
    public partial class RegisterForm : Form
    {
        private MainController _mainController;

        public RegisterForm(MainController mainController)
        {
            InitializeComponent();

            _mainController = mainController;

            UpdateShops();
        }

        private void UpdateShops()
        {
            shopBox.Items.Clear();

            foreach (var shop in _mainController.GetShops()) 
            { 
                shopBox.Items.Add(shop.Name);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) ||
                string.IsNullOrEmpty(shopBox.Text) || string.IsNullOrEmpty(fname.Text) ||
                string.IsNullOrEmpty(lname.Text) || string.IsNullOrEmpty(phoneNumber.Text) ||
                string.IsNullOrEmpty(status.Text))
            {
                MessageBox.Show("Заполните поля");
                return;
            }    

            RegisterResult result =  UserController.RegisterUser(email.Text, password.Text, shopBox.Text, fname.Text, lname.Text, phoneNumber.Text, status.Text);

            switch (result)
            {
                case RegisterResult.Done:
                    MessageBox.Show("Вы успешно зарегистрировались");
                    Close();
                    break;
                case RegisterResult.UserExists:
                    MessageBox.Show("Пользователь с такой почтой уже существует");
                    break;
            } 
        }
    }
}
