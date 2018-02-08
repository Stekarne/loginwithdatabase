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
using Loginwithdatabase.Forms;

namespace Loginwithdatabase.Classes
{
    class Database
    {
        string usr,pwd;
        public string Username
        {
            set { usr = value; }
        }
        public string Pw
        {
            set { pwd = value; }
        }
        public void read()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Table;database=login;integrated security=SSPI";
            SqlCommand cmd = new SqlCommand("select count (*) as cnt from [Table] where UserName=@usr and Password=@pwd", cn);
            SqlCommand gettype = new SqlCommand("select count(*) as cnt from [Table] where Typ=@type", cn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usr", usr);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            if (usr == "" || pwd == "")
            {
                MessageBox.Show("Vänligen ange användarnamn och lösenord");
                return;
            }
            cn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cn.Close();

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Inloggning lyckades!");
                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Inloggning misslyckades :(");
            }
        }
    }
}
