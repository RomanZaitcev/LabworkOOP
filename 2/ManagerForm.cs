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
    public partial class ManagerForm : MaterialForm
    {
        public ManagerForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialComboBox1.Items.Add("Worker 1");
            materialComboBox1.Items.Add("Worker 2");
            materialComboBox1.Items.Add("Worker 3");
            materialComboBox1.Items.Add("Worker 4");
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void mtbtnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
