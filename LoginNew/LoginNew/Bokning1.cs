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
    public partial class Bokning1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aysen\Desktop\Source\Repos\LoginNew\LoginNew\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
        public Bokning1()
        {
            InitializeComponent();
            show();

        }
        private DateTime mPrevDate;
        void show()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select* from sal", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                con.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Bokning1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            con.Open();
            dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //save username from textBox1
            con.Open();
            string username = textBox1.Text;
            string qry = "INSERT INTO bokning VALUES ('" + username + "')";
            SqlCommand sc = new SqlCommand(qry, con);
            int i = sc.ExecuteNonQuery();
            con.Close();
            //save salnamn from datagridview(Column1)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aysen\Desktop\Source\Repos\LoginNew\LoginNew\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO bokning VALUES(@salnamn)", con))
                    {
                        cmd.Parameters.AddWithValue("salnamn", row.Cells["Column1"].Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            
            MessageBox.Show("Records inserted.");
        
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            MinSida form1 = new MinSida();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Login form1 = new Login();
            form1.Show();
        }
    }
}
