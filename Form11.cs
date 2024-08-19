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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");



        private void autoId()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(Id) from Admin";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                i++;
                txtId.Text = i.ToString();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            var F2 = new Form2();
            this.Hide();
            F2.Show();
        }

        private void Display()
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Id,Username,Password from Admin";
                cmd.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dgvData.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            Display();
            autoId();

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvData.Rows[e.RowIndex];

                txtId.Text = dgvRow.Cells["Id"].Value.ToString();
                txtUsername.Text = dgvRow.Cells["Username"].Value.ToString();
                txtPassword.Text = dgvRow.Cells["Password"].Value.ToString().Trim();


                btnAdd.BackColor = Color.White;
                btnAdd.Enabled = false;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Admin WHERE Id = '" + txtId.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                cn.Close();
                Display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "update Admin set Username = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "' where ID = '" + txtId.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated!!");
                    cn.Close();
                    txtId.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    Display();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill in all the required fields.");
                }
                else
                {

                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Admin(Id,Username,Password) Values ('" + txtId.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added!!");
                    cn.Close();
                    txtId.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    Display();
                    autoId();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            autoId();
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.SpringGreen;
        }
    }
}
