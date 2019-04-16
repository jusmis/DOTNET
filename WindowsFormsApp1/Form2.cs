using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 dodawanie = new Form1();
            dodawanie.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 usuwanie = new Form3();
            usuwanie.Show();
            this.Hide();
        }
    }
}
