using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginwithdatabase.Forms
{
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }
        Classes.adminlogin adminlogin = new Classes.adminlogin();
        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin.user = textBox1.Text;
            adminlogin.pass = textBox2.Text;
            adminlogin.login();
        }
    }
}
