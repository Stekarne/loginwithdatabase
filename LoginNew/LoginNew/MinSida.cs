using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginNew
{
    public partial class MinSida : Form
    {
        public MinSida()
        {
            InitializeComponent();
        }

        private void administratörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            AdminLoginForm af = new AdminLoginForm();
            af.Show();

        }

        private void bokaSalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bokning1 form = new Bokning1();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinSida_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("mailto:aysen.furhoff@botkyrka.se");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Login form1 = new Login();
            form1.Show();
        }
    }

}