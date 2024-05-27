using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class CustomerForm : MaterialForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialComboBox1.Items.Add("One-store house");
            materialComboBox1.Items.Add("Two-store house");
            materialComboBox1.Items.Add("Office");

            materialComboBox2.Items.Add("until 10,000");
            materialComboBox2.Items.Add("10,000-15,000");
            materialComboBox2.Items.Add("15,000-20,000");
            materialComboBox2.Items.Add("20,000-30,000");
        }

        private void mt_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
