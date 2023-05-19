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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            add_account m= new add_account();
            m.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void checkture(object sender, EventArgs e)
        {
            
        }

        private void check(object sender, EventArgs e)
        {
            customer_login customer = new customer_login();
            add_customer_by_employee employee = new add_customer_by_employee();
            logedin admin = new logedin();
            string selected = "";

            foreach (RadioButton rb in options.Controls)
            {
                if (rb.Checked)
                { selected = rb.Text;
                  if (selected == "Admin")
                    { 
                        admin.Show();
                        this.Hide();
                    }
                
                }
                else if (selected == "Employee"){
                    
                    employee.Show();
                    this.Hide();

                }
                else if (selected == "Customer")
                {
                    
                    customer.Show();
                    this.Hide();   
                }
            }
        }
    }
    }

