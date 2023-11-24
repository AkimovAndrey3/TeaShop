using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaShop
{
    public partial class DeleteEmployeeForm : Form
    {
        private string _nameShop { get; set; }

        public DeleteEmployeeForm(string shopName)
        {
            InitializeComponent();
            _nameShop = shopName;
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (NameTxtBox.TextLength > 0 && LastNameTxtBox.TextLength > 0)
            {
                DBController.DeleteEmployeeDB(_nameShop, NameTxtBox.Text, LastNameTxtBox.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
