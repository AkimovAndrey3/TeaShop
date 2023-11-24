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
    public partial class AddEmployeeForm : Form
    {
        private string _shopName;

        public AddEmployeeForm(string shopName)
        {
            InitializeComponent();
            _shopName = shopName;
        }
        
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            name.Text = "";
            lastname.Text = "";
            phone.Text = "";
            status.Text = "";
            experiense.Text = "";
            workBegin.Text = "";
            workEnd.Text = "";
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (name.TextLength > 0 &&
               lastname.TextLength > 0 &&
               phone.TextLength > 0 &&
               status.TextLength > 0 &&
               experiense.TextLength > 0 &&
               workBegin.TextLength > 0 &&
               workEnd.TextLength > 0 )
            {
                Employee worker = new Employee();
                worker.FirstName = name.Text;
                worker.LastName = lastname.Text;
                worker.PhoneNumber = phone.Text;
                worker.Status = status.Text;
                worker.Experience = experiense.Text;
                worker.WorkBegin = workBegin.Text;
                worker.WorkEnd = workEnd.Text;

                DBController.AddEmployeeDB(_shopName, worker);
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Поля не заполнены", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
