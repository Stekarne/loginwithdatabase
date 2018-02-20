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

namespace LoginNew
{
    public partial class Admin : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aysen\Desktop\Source\Repos\LoginNew\LoginNew\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
        public Admin()
        {
            InitializeComponent();
            show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = " ";
            this.textBox2.Text = " ";
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string username = textBox1.Text;
                string password = textBox2.Text;
                MessageBox.Show("username: " + username + ", password: " + password + "");
                string qry  = "INSERT INTO login VALUES ('"+username+"', '"+password+"')";
                SqlCommand sc = new SqlCommand( qry, con);
                int i=  sc.ExecuteNonQuery();

                if(i>=1)
                MessageBox.Show( "User Registred Succesfully" + username);
                else
                    MessageBox.Show("Try again" );
                
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("error is: " + exc.ToString());
            }
            con.Close();
           // }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();
                string username = textBox1.Text;
                string password = textBox2.Text;
                //MessageBox.Show("username: " + username + ", password: " + password + "");
                string qry = "update login set username = '" + username + "', password= '" + password + "' where username= '"+username+"'";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                    MessageBox.Show("User Updated Succesfully" );
                else
                    MessageBox.Show("Try again, updation failed");

            }
            catch (System.Exception exc)
            {
                MessageBox.Show("error is: " + exc.ToString());
            }
            con.Close();
            // }
        }
        void show() {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select* from login", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows) {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            con.Open();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string username = textBox1.Text;
                string password = textBox2.Text;
                //MessageBox.Show("username: " + username + ", password: " + password + "");
                string qry = "delete from login where username = '" + username + "'";
                SqlCommand sc = new SqlCommand(qry, con);
                int i = sc.ExecuteNonQuery();

                if (i >= 1)
                    MessageBox.Show("User Deleted Succesfully");
                
                else
                    MessageBox.Show("Try again, delete failed");

                //show();
                button1_Click(sender, e);
                //this.textBox1.Text = " ";
                //this.textBox2.Text = " ";
                con.Close();
            }
            catch (System.Exception exc)
            {
                MessageBox.Show("error is: " + exc.ToString());
            }
            con.Close();
            // }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select* from login where username like  '%" + textBox3.Text.ToString() + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                con.Close();
            }
        }

        private void minSidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Om du lämnar den view, måste du logga in igen som admin");
            Hide();
            MinSida form1 = new MinSida();
            form1.Show();
        }
    }
}
