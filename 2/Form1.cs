using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void mtbtnSingUp_Click(object sender, EventArgs e)
        {
            string userName = mttxtbxUserName.Text;
            string password = mttxtbxPassword.Text;
            if (userName == "123" && password == "123")
            {
                if (mtrdbtnManager.Checked == true)
                {
                    Hide();
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
                }
                else
                {
                    Hide();
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();
                }
               
            }
            else
            {
                MessageBox.Show("Incorrect user name or password");
            }
        }

        private void mtbtnLogIn_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm autorizationForm = new RegistrationForm();
            autorizationForm.Show();
        }
    }
}
