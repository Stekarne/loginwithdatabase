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
    public partial class AdminNew : Form
    {
        public AdminNew()
        {
            InitializeComponent();
        }

        SqlConnection CON = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Table;database=testlogin;integrated security=SSPI");
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
   {
                //C:\Users\Aysen\Desktop\Source\Repos\LoginNew\LoginNew\testlogin.mdf
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aysen\Desktop\Source\Repos\LoginNew\LoginNew\testlogin.mdf;Integrated Security=True;Connect Timeout=30";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into login(username,password) values('" + this.textBox1.Text + "','" + this.textBox2.Text+ "');";
                //This is  SqlConnection here i have created the object and pass my connection string.  
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
        catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aysen\Desktop\Source\Repos\LoginNew\LoginNew\testlogin.mdf;Integrated Security=True;Connect Timeout=30";
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update login set username='" + this.textBox1.Text + "',password='" + this.textBox2.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aysen\Desktop\Source\Repos\LoginNew\LoginNew\testlogin.mdf;Integrated Security=True;Connect Timeout=30";
                string Query = "delete from login where username='" + this.textBox1.Text + "';";
                SqlConnection MyConn2 = new SqlConnection(MyConnection2);
                SqlCommand MyCommand2 = new SqlCommand(Query, MyConn2);
                SqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
