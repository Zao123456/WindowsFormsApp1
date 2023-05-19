using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LIJFUH;Initial Catalog=Fruit;Integrated Security=True");
            con.Open();
            string sq;
            if (itembtn.Text == "")
            {
                if (pricebtn.Text == "")
                {
                    if (quantitybtn.Text == "")
                    {
                        sq = "select * from records";
                    }
                    else
                    {
                        sq = "select * from records where price quantity= " + quantitybtn.Text;
                    }
                }
                else
                {
                    sq = "select * from records where price= " + pricebtn.Text + " and quantity= " + quantitybtn.Text;
                }
            }
            else
            {
                sq = "select * from records where price= " + pricebtn.Text + " and quantity= " + quantitybtn.Text+" and item="+itembtn.Text;

            }

            SqlCommand cmd = new SqlCommand(sq, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }

