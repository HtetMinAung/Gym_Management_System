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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");




        private void Display()
        {
            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Trainer";
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

        private void autoID()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(Id) from Trainer";
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

        private void Form10_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvData.Rows[e.RowIndex];

                txtId.Text = dgvRow.Cells["Id"].Value.ToString();
                txtName.Text = dgvRow.Cells["Trainer_Name"].Value.ToString();
                txtSpecialty.Text = dgvRow.Cells["Specialty"].Value.ToString();
                txtFees.Text = dgvRow.Cells["Fees_per_session"].Value.ToString().Trim();

                btnAdd.BackColor = Color.White;
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtSpecialty.Text == "" || txtFees.Text == "")
                {
                    MessageBox.Show("Please fill in all the required fields");
                }

                else
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Trainer(Id,Trainer_Name,Specialty,Fees_per_session) Values ('" + txtId.Text + "', '" + txtName.Text + "', '" + txtSpecialty.Text + "', '" + txtFees.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added!!");
                    cn.Close();
                    txtId.Text = "";
                    txtName.Text = "";
                    txtSpecialty.Text = "";
                    txtFees.Text = "";
                    Display();
                    autoID();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Trainer WHERE Id = '" + txtId.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                cn.Close();
                txtId.Text = "";
                txtName.Text = "";
                txtSpecialty.Text = "";
                txtFees.Text = "";
                Display();
                autoID();

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
                if (txtName.Text == "" || txtSpecialty.Text == "" || txtFees.Text == "")
                {
                    MessageBox.Show("Please fill in all the textboxes");
                }
                else
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Trainer set Trainer_Name = '" + txtName.Text + "', Specialty = '" + txtSpecialty.Text + "', Fees_per_session =  '" + txtFees.Text + "' where Id = '" + txtId.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated!!");
                    cn.Close();
                    txtId.Text = "";
                    txtName.Text = "";
                    txtSpecialty.Text = "";
                    txtFees.Text = "";
                    Display();
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
            txtName.Text = "";
            txtSpecialty.Text = "";
            txtFees.Text = "";
            autoID();
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.SpringGreen;

        }
    }
}
