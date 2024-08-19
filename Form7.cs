using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace COS210_Assignment_by_Htet_Min_Aung
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];

                txtID.Text = dgvRow.Cells["Id"].Value.ToString();
                txtUsername.Text = dgvRow.Cells["Username"].Value.ToString();
                txtPassword.Text = dgvRow.Cells["Password"].Value.ToString();

            }


        }




        private void Display()
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,Username,Password from Member";
                cmd.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
                dataGridView1.Columns["Password"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            Display();
        }






        private void btnBack_Click(object sender, EventArgs e)
        {
            var F2 = new Form2();
            this.Hide();
            F2.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Member WHERE Id = '" + txtID.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    txtUsername.Text = "";
                    cn.Close();
                    Display();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill in all the textboxes");
                }
                else
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Member set Username = '" + txtUsername.Text + "' where ID = '" + txtID.Text + "'";
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Updated!!");
                    cn.Close();
                    txtID.Text = "";
                    txtUsername.Text = "";
                    Display();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtconfidential.Hide();

        }
    }
}
