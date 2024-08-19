using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace COS210_Assignment_by_Htet_Min_Aung
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30";

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.ContainerControl = this;
            errorProvider2.ContainerControl = this;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM Member WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt != null && dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["Role"].ToString();
                MessageBox.Show("Logged in as: " + role, "Login successful");
                var F5 = new Form5();
                this.Hide();
                F5.Show();
            }
            else if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Please enter your name!");

                if (txtPassword.Text == "")
                {
                    errorProvider2.SetError(txtPassword, "Please enter your password");
                    MessageBox.Show("Please fill in all the required fields.");
                }
            }
            else
            {
                if (txtPassword.Text == "")
                {
                    errorProvider2.SetError(txtPassword, "Please enter your password");
                }
                else
                {
                    string adminSql = "SELECT * FROM Admin WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter adminAdp = new SqlDataAdapter(adminSql, con);
                    DataTable adminDt = new DataTable();
                    adminAdp.Fill(adminDt);

                    if (adminDt.Rows.Count > 0)
                    {
                        string role = adminDt.Rows[0]["Role"].ToString();
                        MessageBox.Show("Logged in as:" + role, "Login successful");
                        var F2 = new Form2();
                        this.Hide();
                        F2.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }

        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var F4 = new Form4();
            this.Hide();
            F4.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                errorProvider1.Clear();


            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                errorProvider2.Clear();
            }
        }
    }
}