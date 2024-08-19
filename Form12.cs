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
    public partial class Form12 : Form
    {
        public Form12()
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
                cmd.CommandText = "select * from Class";
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

        private void autoId()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select max(Id) from Class";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvData.Rows[e.RowIndex];

                txtId.Text = dgvRow.Cells["Id"].Value.ToString();
                txttype.Text = dgvRow.Cells["Types_of_Workout"].Value.ToString();
                txtGymTime.Text = dgvRow.Cells["Gym_Time"].Value.ToString();
                cboIntensity.Text = dgvRow.Cells["Intensity_Level"].Value.ToString();
                txtEquipment.Text = dgvRow.Cells["Equipment"].Value.ToString();

                btnInsert.BackColor = Color.White;
                btnInsert.Enabled = false;


            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttype.Text == "" || txtGymTime.Text == "" || cboIntensity.SelectedIndex == -1 || txtEquipment.Text == "")
                {
                    MessageBox.Show("Please enter all the required fields.");

                }
                else
                {
                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Class(Id,Types_of_Workout,Gym_Time,Intensity_Level,Equipment) Values ('" + txtId.Text + "', '" + txttype.Text + "', '" + txtGymTime.Text + "', '" + cboIntensity.Text + "', '" + txtEquipment.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added!!");
                    cn.Close();
                    txtId.Text = "";
                    txttype.Text = "";
                    txtGymTime.Text = "";
                    cboIntensity.SelectedIndex = -1;
                    txtEquipment.Text = "";
                    Display();
                    autoId();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kyaw Myo Lwin\Documents\GymData.mdf"";Integrated Security=True;Connect Timeout=30");
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Class WHERE Id = '" + txtId.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                cn.Close();
                txtId.Text = "";
                txttype.Text = "";
                txtGymTime.Text = "";
                cboIntensity.SelectedIndex = -1;
                txtEquipment.Text = "";
                Display();
                autoId();

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
                if (txttype.Text == "" || txtGymTime.Text == "" || cboIntensity.SelectedIndex == -1 || txtEquipment.Text == "")
                {
                    MessageBox.Show("Please fill in all the textboxes");
                }
                else
                {

                    cn.Open();
                    SqlCommand cmd = cn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Class set Types_of_Workout = '" + txttype.Text + "', Gym_Time = '" + txtGymTime.Text + "', Intensity_Level =  '" + cboIntensity.Text + "', Equipment ='" + txtEquipment.Text + "' where Id = '" + txtId.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated!!");
                    cn.Close();
                    txtId.Text = "";
                    txttype.Text = "";
                    txtGymTime.Text = "";
                    cboIntensity.SelectedIndex = -1;
                    txtEquipment.Text = "";
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
            txttype.Text = "";
            txtGymTime.Text = "";
            cboIntensity.SelectedIndex = -1;
            txtEquipment.Text = "";
            autoId();
            btnInsert.Enabled = true;
            btnInsert.BackColor = Color.SpringGreen;

        }
    }
}
