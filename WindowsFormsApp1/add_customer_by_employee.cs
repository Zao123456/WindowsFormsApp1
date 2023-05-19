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
    public partial class add_customer_by_employee : Form
    {
        public add_customer_by_employee()
        {
            InitializeComponent();
        }

        private void back_page_Click(object sender, EventArgs e)
        {
            main page = new main();
            page.Show();
            this.Hide();
        }
    }
}
