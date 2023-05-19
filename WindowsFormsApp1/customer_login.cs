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
    public partial class customer_login : Form
    {
        public customer_login()
        {
            InitializeComponent();
        }

        private void back_page_Click(object sender, EventArgs e)
        {
            main page = new main();
            page.Show();
            this.Hide();
        }

        private void CAcc_Click(object sender, EventArgs e)
        {
            add_customr_account addacc = new add_customr_account();
            addacc.Show();
            this.Hide();
        }
    }
}
