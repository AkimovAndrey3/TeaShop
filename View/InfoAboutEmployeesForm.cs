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
    public partial class InfoAboutEmployeesForm : Form
    {
        private string _nameShop;
        private ShopController _shopController;
        private List<Employee> _employees;

        public InfoAboutEmployeesForm(string shopName, List<Employee> empl)
        {
            InitializeComponent();
            _nameShop = shopName;
            _employees = empl;

            _shopController = new ShopController();
            _shopController.OnUpdate += UpdateTable;

            int index = 0;
            foreach (Employee item in _employees)
            {
                string name = item.FirstName;
                string lname = item.LastName;
                string phone = item.PhoneNumber;
                string status = item.Status;
                string exp = item.Experience;
                string BeginWork = item.WorkBegin;
                string EndWork = item.WorkEnd;
                dataGridView1.Rows.Add(name, lname, phone, status, exp, BeginWork, EndWork);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }
        private void UpdateTable()
        {
            dataGridView1.Rows.Clear();
            int index = 0;
            foreach (Employee item in _employees)
            {
                string name = item.FirstName;
                string lname = item.LastName;
                string phone = item.PhoneNumber;
                string status = item.Status;
                string exp = item.Experience;
                string BeginWork = item.WorkBegin;
                string EndWork = item.WorkEnd;
                dataGridView1.Rows.Add(name, lname, phone, status, exp, BeginWork, EndWork);
                dataGridView1.Rows[index++].ReadOnly = true;
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(_nameShop);
            addEmployeeForm.Show();
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            DeleteEmployeeForm deleteEmployeeForm = new DeleteEmployeeForm(_nameShop);
            deleteEmployeeForm.Show();
        }
    }
}
