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
using static System.Net.WebRequestMethods;

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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgv.CurrentRow.Cells["ID_NV"].Value.ToString();
            txtName.Text = dgv.CurrentRow.Cells["HoTen"].Value.ToString();
            txtSDT.Text = dgv.CurrentRow.Cells["SDT"].Value.ToString();
            txtQueQuan.Text = dgv.CurrentRow.Cells["QueQuan"].Value.ToString();
            txtUserName.Text = dgv.CurrentRow.Cells["Username"].Value.ToString();
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn nuốn xóa không?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection Cnn = new SqlConnection(connectionString))
                        {
                            using (SqlCommand Cmd = new SqlCommand())
                            {
                                Cmd.Connection = Cnn;
                                Cmd.CommandType = CommandType.StoredProcedure;
                                Cmd.CommandText = "delNhanVien";
                                Cnn.Open();
                                Cmd.Parameters.AddWithValue("@idNhanVien", txtMa.Text);
                                int i = Cmd.ExecuteNonQuery();
                                if (i == 0)
                                {
                                    Console.WriteLine("Insert success");
                                }
                                else
                                {
                                    Console.WriteLine("Insert fail");
                                }
                                Cnn.Close();
                                layDS();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Giá trị tham chiếu đến bản ghi khác", "Lỗi không xóa được");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Bản ghi bị ràng buộc khóa");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand())
                    {
                        Cmd.Connection = Cnn;
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.CommandText = "addNhanVien";
                        Cnn.Open();
                        Cmd.Parameters.AddWithValue("@hoTen", txtName.Text);
                        Cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        Cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text);
                        Cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                       

                        int i = Cmd.ExecuteNonQuery();

                        if (i == 0)
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        Cnn.Close();
                        layDS();
                    }
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Bạn phải điền đủ các trường dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
