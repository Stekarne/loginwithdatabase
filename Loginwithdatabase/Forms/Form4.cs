using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginwithdatabase.Forms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            panel3.Height = button1.Height;
            userControl11.BringToFront();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

    private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            Process.Start("http://www.tullingeymnasium.se");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Height = button5.Height;
            panel3.Top = button5.Top;
            userControl21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            Classes.Database database = new Classes.Database();
            form1.Show();
            database.Username = "";
            database.Pw = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vänligen använd endast om det verkligen behövs. Onödigt användande kommer att leda till avstängning!");

        }
    }
}
