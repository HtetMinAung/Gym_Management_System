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
using FontAwesome.Sharp;

namespace COS210_Assignment_by_Htet_Min_Aung
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            var F11 = new Form11();
            this.Hide();
            F11.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            var F7 = new Form7();
            this.Hide();
            F7.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var F8 = new Form8();
            this.Hide();
            F8.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var F12 = new Form12();
            this.Hide();
            F12.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            var F10 = new Form10();
            this.Hide();
            F10.Show();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            var F1 = new Form1();
            this.Hide();
            F1.Show();
        }
    }
}
