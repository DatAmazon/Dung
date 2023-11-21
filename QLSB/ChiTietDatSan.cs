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
using static System.Net.WebRequestMethods;

namespace QuanLySanBong
{
    public partial class ChiTietDatSan : Form
    {
        private string connectionString = @"Data Source=DESKTOP-S3UOKJU\SQLEXPRESS;Initial Catalog=QuanLySanBong;Integrated Security=True";

        public ChiTietDatSan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ChiTietDatSan_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                //using (SqlCommand Cmd = new SqlCommand())
                //{
                //    Cmd.Connection = Cnn;
                //    Cmd.CommandType = CommandType.StoredProcedure;
                //    Cmd.CommandText = "addChiTietLichDatSanBong";
                //    Cnn.Open();
                //    Cmd.Parameters.AddWithValue("@ldsb", txtMaCD.Text);
                //    Cmd.Parameters.AddWithValue("@kvsb", txtHoten.Text);
                //    Cmd.Parameters.AddWithValue("@khungGioNhan", dtp.Value);
                //    Cmd.Parameters.AddWithValue("@khungGioTra", cbGioiTinh.Text);
                //    Cmd.Parameters.AddWithValue("@ghiChu", txtSDT.Text);
                //    Cmd.Parameters.AddWithValue("@trangThai", txtQueQuan.Text);

                //    int i = Cmd.ExecuteNonQuery();
                //    if (txtMaCD.Text.Equals(""))
                //    {
                //        MessageBox.Show("Mã CD không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    if (i == 0)
                //    {
                //        MessageBox.Show("Thêm thất bại");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Thêm thành công");
                //    }
                //    Cnn.Close();
                //    resetForm();
                //    layDSCD();
                //}

            }
        }

        private void sdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
