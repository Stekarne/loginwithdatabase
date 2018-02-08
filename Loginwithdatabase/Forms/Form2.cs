using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginwithdatabase
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Metod för att starta om program samt stänga föregående fönster. 
            //"Application.Exit();" fungerar även lika väl. 

            Close();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
