using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS210_Assignment_by_Htet_Min_Aung
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");



        private void autoId()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(Id) from Enrollment";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                i++;
                txtID.Text = i.ToString();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                string gender = "";


                if (txtName.Text == "" || txtAge.Text == "" || txtMobile.Text == "" || txtEmail.Text == "" || cboHeightft.SelectedIndex == -1 || cboHeightin.SelectedIndex == -1 || txtWeight.Text == "" || rtBAddress.Text == "" || cboDuration.SelectedIndex == -1)
                {

                    MessageBox.Show("Please fill in all the required fields.");
                    return;

                }



                if (rdbM.Checked)
                {
                    gender = "Male";
                }
                else if (rdbF.Checked)
                {
                    gender = "Female";
                }
                else
                {

                    MessageBox.Show("Please select a gender.");
                    return;
                }



                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Enrollment(Id,Name,Gender,Age,Mobile,Email,HeightFt,HeightIn,Weight,Address,Member_Duration) values ('" + txtID.Text + "','" + txtName.Text + "','" + gender + "','" + txtAge.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "', '" + cboHeightft.Text + "','" + cboHeightin.Text + "','" + txtWeight.Text + "', '" + rtBAddress.Text + "', '" + cboDuration.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved Info!");
                txtID.Text = "";
                txtName.Text = "";
                rdbM.Checked = false;
                rdbF.Checked = false;
                txtAge.Text = "";
                txtMobile.Text = "";
                txtEmail.Text = "";
                cboHeightft.Text = "";
                cboHeightin.Text = "";
                txtWeight.Text = "";
                rtBAddress.Text = "";
                cboDuration.Text = "";
                autoId();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            autoId();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var F5 = new Form5();
            this.Hide();
            F5.Show();
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtWeight.Text, out double pounds))
            {
                double kilograms = pounds * 0.45359237;
                txtkg.Text = kilograms.ToString("0.##") + " kg";
            }
            else
            {
                txtkg.Text = "";
            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            int age;

            if (int.TryParse(txtAge.Text, out age))
            {
                if (age < 14)
                {
                    ageerror.SetError(txtAge, "You are not yet eligible to join our gym. Minimum age requirement is 14.");
                    btnSave.Enabled = false;
                }
                else if (age >= 14)
                {
                    ageerror.Clear();
                    btnSave.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Age entered is not a valid integer. Please enter the correct input");
            }
        }
    }
}
