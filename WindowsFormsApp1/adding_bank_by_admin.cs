using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adding_bank_by_admin : Form
    {
        public adding_bank_by_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_bankD bankD = new show_bankD();
            bankD.Show();
            this.Hide();
        }
    }
}
