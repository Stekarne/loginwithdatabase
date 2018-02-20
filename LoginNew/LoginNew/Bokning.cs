using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LoginNew
{
    public partial class Bokning : Form
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aysen\Source\Repos\LoginNew\LoginNew\testlogin.mdf;Integrated Security=True;Connect Timeout=30");
        public Bokning()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void Bokning_Shown(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message,Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand cm = new SqlCommand
        ("SELECT * FROM sal ORDER BY salnamn", cn);

            try {
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read()) {
                    ListViewItem item = new ListViewItem(dr["salnamn"].ToString());
                    item.SubItems.Add(dr["antalperson"].ToString());
                    item.SubItems.Add(dr["bokningsläge"].ToString());
                    listView1.Items.Add(item);
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }
    }
}
