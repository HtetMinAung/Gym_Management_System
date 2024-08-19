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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Display();
            autoId();
        }
        private void Display()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Enrollment";
            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgv1.DataSource = dt;
            cn.Close();
        }

        private void autoId()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max(Id) from Enrollment";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            txtID.Text = i.ToString();
        }
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgv1.Rows[e.RowIndex];

                txtID.Text = dgvRow.Cells["Id"].Value.ToString();
                txtName.Text = dgvRow.Cells["Name"].Value.ToString();
                string gender = dgvRow.Cells["Gender"].Value.ToString().Trim();

                if (gender == "Female")
                {
                    rdbF.Checked = true;
                }
                else if (gender == "Male")
                {
                    rdbM.Checked = true;
                }

                txtAge.Text = dgvRow.Cells["Age"].Value.ToString();
                txtMobile.Text = dgvRow.Cells["Mobile"].Value.ToString();
                txtEmail.Text = dgvRow.Cells["Email"].Value.ToString();
                cboHeightft.Text = dgvRow.Cells["Heightft"].Value.ToString();
                cboHeightin.Text = dgvRow.Cells["Heightin"].Value.ToString();
                txtWeight.Text = dgvRow.Cells["Weight"].Value.ToString();
                rtBAddress.Text = dgvRow.Cells["Address"].Value.ToString();
                cboDuration.Text = dgvRow.Cells["Member_Duration"].Value.ToString();




            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "";
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



                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Enrollment SET Name = '" + txtName.Text + "', Gender = '" + gender + "', Age = '" + txtAge.Text + "', Mobile = '" + txtMobile.Text + "', Email = '" + txtEmail.Text + "', HeightFt = '" + cboHeightft.Text + "', HeightIn = '" + cboHeightin.Text + "', Weight = '" + txtWeight.Text + "', Address = '" + rtBAddress.Text + "', Member_Duration = '" + cboDuration.Text + "' WHERE Id = '" + txtID.Text + "'";
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
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                Display();
                autoId();

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
                cmd.CommandText = "DELETE FROM Enrollment WHERE Id = '" + txtID.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                Display();
                autoId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var F2 = new Form2();
            this.Hide();
            F2.Show();
        }
    }
}
