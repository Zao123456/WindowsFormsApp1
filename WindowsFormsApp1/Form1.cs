using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
           }
       
          
    
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LIJFUH;Initial Catalog=Fruit;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into records(item,quantity,price) values(@Item,@quantity,@price)", con);
            cmd.Parameters.AddWithValue("@Item", txtItem.Text);
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
            cmd.Parameters.AddWithValue("@price", float.Parse(txtPrice.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully saved");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LIJFUH;Initial Catalog=Fruit;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update records set price=@price,quantity=@quantity where item=@item",con);
            cmd.Parameters.AddWithValue("@item", txtItem.Text);
            cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
            cmd.Parameters.AddWithValue("@price", float.Parse(txtPrice.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully updated");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LIJFUH;Initial Catalog=Fruit;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from records where item=@item", con);
            cmd.Parameters.AddWithValue("@item", txtItem.Text);
         //   cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
           // cmd.Parameters.AddWithValue("@price", float.Parse(txtPrice.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully deleted it");
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //this.Hide();
        }

        private void select_btr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LIJFUH;Initial Catalog=Fruit;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from records",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        /*
private void label1_Click(object sender, EventArgs e)
{

}

private void button1_Click(object sender, EventArgs e)
{
string firstname = t_f.Text;
string lastname = t_l.Text;
string select = null;
foreach (RadioButton rb in groupBox1.Controls)
{
if (rb.Checked)
{
select = rb.Text;
}
}
if (validatefields())
{
//   Console.WriteLine(firstname + " " + lastname);
// Console.WriteLine("radio button value " + select);
MessageBox.Show("first name: " + firstname + " last name: " + lastname + " gender " + select);
foreach (RadioButton rb in groupBox1.Controls)
{
if (rb.Checked)
{
rb.Checked= false;
}
}
t_f.Clear();
t_l.Clear();

}
}
private bool validatefields()
{
string firstname = t_f.Text;
string lastname = t_l.Text;
if (firstname != null && lastname != null)
{
foreach (RadioButton rb in groupBox1.Controls)
{
if (rb.Checked)
{
return true;
}
}
return false;

}
return false;

}*/
    }
}
