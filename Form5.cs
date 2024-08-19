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

namespace COS210_Assignment_by_Htet_Min_Aung
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            var F1 = new Form1();
            this.Hide();
            F1.Show();

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {

            var F3 = new Form3();
            this.Hide();
            F3.Show();


        }

        private void btnTS_Click(object sender, EventArgs e)
        {
            var F6 = new Form6();
            this.Hide();
            F6.Show();
        }

        private void btnTrainers_Click(object sender, EventArgs e)
        {
            var F9 = new Form9();
            this.Hide();
            F9.Show();
        }
    }
}
