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
using System.Windows.Input;

namespace Loginwithdatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
        Classes.Database database = new Classes.Database();
        private void button1_Click(object sender, EventArgs e)
        {
            database.Username = textBox1.Text;
            database.Pw = textBox2.Text;
            database.read();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Adminform adminform = new Forms.Adminform();
            adminform.Show();
        }
    }
}
