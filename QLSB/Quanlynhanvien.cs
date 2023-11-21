using QuanLySanBong.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBong
{
    public partial class Quanlynhanvien : Form
    {
        private string connectionString = @"Data Source=DESKTOP-S3UOKJU\SQLEXPRESS;Initial Catalog=QuanLySanBong;Integrated Security=True";

        bool Thoat = true;
        public Quanlynhanvien()
        {
            InitializeComponent();
            /*hienthi();*/
        }
        void hienthi()
        {
             /*listView1.Items.Clear();
            
            foreach (DTO.Quanlynhanvien item in )
                {
                    ListViewItem lsvItem = new ListViewItem(item.ID_NV.ToString());
                    lsvItem.SubItems.Add(item.HoTen.ToString());
                    lsvItem.SubItems.Add(item.SDT.ToString());
                    lsvItem.SubItems.Add(item.QuenQuan.ToString());
                    lsvItem.SubItems.Add(item.Username.ToString());
                    listView1.Items.Add(lsvItem);*/
                
            

      
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Trangchu f = new Trangchu();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datsan f = new Datsan();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thanhtoan f = new Thanhtoan();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thongtintaikhoan f = new Thongtintaikhoan();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thoat = false;
            this.Close();
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Trangchu f = new Trangchu();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Quanlykh f = new Quanlykh();
            f.Show();
            this.Hide();
        }

        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {
            layDS();
        }
        public void layDS()
        {
            try
            {
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand("select * from nhanvien", Cnn))
                    {
                        Cmd.CommandType = CommandType.Text;
                        Cnn.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(Cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgv.DataSource = dt;
                        }
                        Cnn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
