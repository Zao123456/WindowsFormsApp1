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
    public partial class logedin : Form
    {
        public logedin()
        {
            InitializeComponent();
        }

        private void back_page_Click(object sender, EventArgs e)
        {
            main page = new main();
            page.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adding_bank_by_admin newbank = new adding_bank_by_admin();
            newbank.Show();
            this.Hide();
        }

        private void longintobank_Click(object sender, EventArgs e)
        {
            Find_bank Fbank = new Find_bank();
            Fbank.Show();
            this.Hide();

        }
    }
}
