using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace main
{
    public partial class frm_chi_so_rac : Form
    {
        public frm_chi_so_rac()
        {
            InitializeComponent();
        }

        DataSet TongQuan1()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 1', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan2()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 2', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan3()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 3', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan4()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 4', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan5()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 5', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan6()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 6', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan7()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 7', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan8()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 8', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan9()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 9', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan10()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 10', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan11()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 11', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet TongQuan12()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận 12', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongbinhthanh()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận Bình Thạnh', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongthuduc()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận Thủ Đức', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tonggovap()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận Gò Vấp', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongphunhuan()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận Phú Nhuận', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongtanbinh()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận Tân Bình', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongtanphu()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận Tân Phú', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongbinhtan()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Quận Bình Tân', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongnhabe()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Huyện Nhà Bè', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tonghocmon()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Huyện Hóc Môn', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongbinhchanh()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Huyện Bình Chánh', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongcuchi()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Huyện Củ Chi', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }
        DataSet Tongcangio()
        {
            DataSet Get = new DataSet();
            string sql = "EXEC dbo.LayTongRac N'Huyện Cần Giờ', '" + cbnam.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(Get);
                con.Close();
                con.Dispose();
            }
            return Get;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // lấy năm 
            var dap = new SqlDataAdapter("EXEC dbo.LayNam", ConnectionString.connection);
            var tb = new DataTable();
            dap.Fill(tb);
            cbnam.DisplayMember = "Nam";
            cbnam.DataSource = tb;

            // đổ data vào datagrid view
            dgvquan1.DataSource = TongQuan1().Tables[0];
            dgvquan2.DataSource = TongQuan2().Tables[0];
            dgvquan3.DataSource = TongQuan3().Tables[0];
            dgvquan4.DataSource = TongQuan4().Tables[0];
            dgvquan5.DataSource = TongQuan5().Tables[0];
            dgvquan6.DataSource = TongQuan6().Tables[0];
            dgvquan7.DataSource = TongQuan7().Tables[0];
            dgvquan8.DataSource = TongQuan8().Tables[0];
            dgvquan9.DataSource = TongQuan9().Tables[0];
            dgvquan10.DataSource = TongQuan10().Tables[0];
            dgvquan11.DataSource = TongQuan11().Tables[0];
            dgvquan12.DataSource = TongQuan12().Tables[0];
            dgvbinhthanh.DataSource = Tongbinhthanh().Tables[0];
            dgvthuduc.DataSource = Tongthuduc().Tables[0];
            dgvgovap.DataSource = Tonggovap().Tables[0];
            dgvphunhuan.DataSource = Tongphunhuan().Tables[0];
            dgvtanbinh.DataSource = Tongtanbinh().Tables[0];
            dgvtanphu.DataSource = Tongtanphu().Tables[0];
            dgvbinhtan.DataSource = Tongbinhtan().Tables[0];
            dgvnhabe.DataSource = Tongnhabe().Tables[0];
            dgvhocmon.DataSource = Tonghocmon().Tables[0];
            dgvbinhchanh.DataSource = Tongbinhchanh().Tables[0];
            dgvcuchi.DataSource = Tongcuchi().Tables[0];
            dgvcangio.DataSource = Tongcangio().Tables[0];

            // hiển thị lên TextBox
            txtquan1.DataBindings.Clear();
            txtquan1.DataBindings.Add("Text", dgvquan1.DataSource, "Tong");
            txtquan2.DataBindings.Clear();
            txtquan2.DataBindings.Add("Text", dgvquan2.DataSource, "Tong");
            txtquan3.DataBindings.Clear();
            txtquan3.DataBindings.Add("Text", dgvquan3.DataSource, "Tong");
            txtquan4.DataBindings.Clear();
            txtquan4.DataBindings.Add("Text", dgvquan4.DataSource, "Tong");
            txtquan5.DataBindings.Clear();
            txtquan5.DataBindings.Add("Text", dgvquan5.DataSource, "Tong");
            txtquan6.DataBindings.Clear();
            txtquan6.DataBindings.Add("Text", dgvquan6.DataSource, "Tong");
            txtquan7.DataBindings.Clear();
            txtquan7.DataBindings.Add("Text", dgvquan7.DataSource, "Tong");
            txtquan8.DataBindings.Clear();
            txtquan8.DataBindings.Add("Text", dgvquan8.DataSource, "Tong");
            txtquan9.DataBindings.Clear();
            txtquan9.DataBindings.Add("Text", dgvquan9.DataSource, "Tong");
            txtquan10.DataBindings.Clear();
            txtquan10.DataBindings.Add("Text", dgvquan10.DataSource, "Tong");
            txtquan11.DataBindings.Clear();
            txtquan11.DataBindings.Add("Text", dgvquan11.DataSource, "Tong");
            txtquan12.DataBindings.Clear();
            txtquan12.DataBindings.Add("Text", dgvquan12.DataSource, "Tong");
            txtbinhthanh.DataBindings.Clear();
            txtbinhthanh.DataBindings.Add("Text", dgvbinhthanh.DataSource, "Tong");
            txtthuduc.DataBindings.Clear();
            txtthuduc.DataBindings.Add("Text", dgvthuduc.DataSource, "Tong");
            txtgovap.DataBindings.Clear();
            txtgovap.DataBindings.Add("Text", dgvgovap.DataSource, "Tong");
            txtphunhuan.DataBindings.Clear();
            txtphunhuan.DataBindings.Add("Text", dgvphunhuan.DataSource, "Tong");
            txttanbinh.DataBindings.Clear();
            txttanbinh.DataBindings.Add("Text", dgvtanbinh.DataSource, "Tong");
            txttanphu.DataBindings.Clear();
            txttanphu.DataBindings.Add("Text", dgvtanphu.DataSource, "Tong");
            txtbinhtan.DataBindings.Clear();
            txtbinhtan.DataBindings.Add("Text", dgvbinhtan.DataSource, "Tong");
            txtnhabe.DataBindings.Clear();
            txtnhabe.DataBindings.Add("Text", dgvnhabe.DataSource, "Tong");
            txthocmon1.DataBindings.Clear();
            txthocmon1.DataBindings.Add("Text", dgvhocmon.DataSource, "Tong");
            txtbinhchanh.DataBindings.Clear();
            txtbinhchanh.DataBindings.Add("Text", dgvbinhchanh.DataSource, "Tong");
            txtcuchi.DataBindings.Clear();
            txtcuchi.DataBindings.Add("Text", dgvcuchi.DataSource, "Tong");
            txtcangio.DataBindings.Clear();
            txtcangio.DataBindings.Add("Text", dgvcangio.DataSource, "Tong");

            // Quận 1
            if (Convert.ToInt32(txtquan1.Text) >= 0 && Convert.ToInt32(txtquan1.Text) < 26)
            {
                lblquan1.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan1.Text) > 25 && Convert.ToInt32(txtquan1.Text) < 51)
            {
                lblquan1.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan1.Text) > 50 && Convert.ToInt32(txtquan1.Text) < 76)
            {
                lblquan1.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan1.Text) > 75 && Convert.ToInt32(txtquan1.Text) < 101)
            {
                lblquan1.BackColor = Color.Red;
            }

            // Quận 2
            if (Convert.ToInt32(txtquan2.Text) >= 0 && Convert.ToInt32(txtquan2.Text) < 26)
            {
                lblquan2.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan2.Text) > 25 && Convert.ToInt32(txtquan2.Text) < 51)
            {
                lblquan2.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan2.Text) > 50 && Convert.ToInt32(txtquan2.Text) < 76)
            {
                lblquan2.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan2.Text) > 75 && Convert.ToInt32(txtquan2.Text) < 101)
            {
                lblquan2.BackColor = Color.Red;
            }

            // Quận 3
            if (Convert.ToInt32(txtquan3.Text) >= 0 && Convert.ToInt32(txtquan3.Text) < 26)
            {
                lblquan3.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan3.Text) > 25 && Convert.ToInt32(txtquan3.Text) < 51)
            {
                lblquan3.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan3.Text) > 50 && Convert.ToInt32(txtquan3.Text) < 76)
            {
                lblquan3.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan3.Text) > 75 && Convert.ToInt32(txtquan3.Text) < 101)
            {
                lblquan3.BackColor = Color.Red;
            }

            // Quận 4
            if (Convert.ToInt32(txtquan4.Text) >= 0 && Convert.ToInt32(txtquan4.Text) < 26)
            {
                lblquan4.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan4.Text) > 25 && Convert.ToInt32(txtquan4.Text) < 51)
            {
                lblquan4.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan4.Text) > 50 && Convert.ToInt32(txtquan4.Text) < 76)
            {
                lblquan4.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan4.Text) > 75 && Convert.ToInt32(txtquan4.Text) < 101)
            {
                lblquan4.BackColor = Color.Red;
            }

            // Quận 5
            if (Convert.ToInt32(txtquan5.Text) >= 0 && Convert.ToInt32(txtquan5.Text) < 26)
            {
                lblquan5.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan5.Text) > 25 && Convert.ToInt32(txtquan5.Text) < 51)
            {
                lblquan5.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan5.Text) > 50 && Convert.ToInt32(txtquan5.Text) < 76)
            {
                lblquan5.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan5.Text) > 75 && Convert.ToInt32(txtquan5.Text) < 101)
            {
                lblquan5.BackColor = Color.Red;
            }

            // Quận 6
            if (Convert.ToInt32(txtquan6.Text) >= 0 && Convert.ToInt32(txtquan6.Text) < 26)
            {
                lblquan6.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan6.Text) > 25 && Convert.ToInt32(txtquan6.Text) < 51)
            {
                lblquan6.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan6.Text) > 50 && Convert.ToInt32(txtquan6.Text) < 76)
            {
                lblquan6.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan6.Text) > 75 && Convert.ToInt32(txtquan6.Text) < 101)
            {
                lblquan6.BackColor = Color.Red;
            }

            // Quận 7
            if (Convert.ToInt32(txtquan7.Text) >= 0 && Convert.ToInt32(txtquan7.Text) < 26)
            {
                lblquan7.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan7.Text) > 25 && Convert.ToInt32(txtquan7.Text) < 51)
            {
                lblquan7.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan7.Text) > 50 && Convert.ToInt32(txtquan7.Text) < 76)
            {
                lblquan7.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan7.Text) > 75 && Convert.ToInt32(txtquan7.Text) < 101)
            {
                lblquan7.BackColor = Color.Red;
            }

            // Quận 8
            if (Convert.ToInt32(txtquan8.Text) >= 0 && Convert.ToInt32(txtquan8.Text) < 26)
            {
                lblquan8.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan8.Text) > 25 && Convert.ToInt32(txtquan8.Text) < 51)
            {
                lblquan8.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan8.Text) > 50 && Convert.ToInt32(txtquan8.Text) < 76)
            {
                lblquan8.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan8.Text) > 75 && Convert.ToInt32(txtquan8.Text) < 101)
            {
                lblquan8.BackColor = Color.Red;
            }

            // Quận 9
            if (Convert.ToInt32(txtquan9.Text) >= 0 && Convert.ToInt32(txtquan9.Text) < 26)
            {
                lblquan9.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan9.Text) > 25 && Convert.ToInt32(txtquan9.Text) < 51)
            {
                lblquan9.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan9.Text) > 50 && Convert.ToInt32(txtquan9.Text) < 76)
            {
                lblquan9.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan9.Text) > 75 && Convert.ToInt32(txtquan9.Text) < 101)
            {
                lblquan9.BackColor = Color.Red;
            }

            // Quận 10
            if (Convert.ToInt32(txtquan10.Text) >= 0 && Convert.ToInt32(txtquan10.Text) < 26)
            {
                lblquan10.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan10.Text) > 25 && Convert.ToInt32(txtquan10.Text) < 51)
            {
                lblquan10.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan10.Text) > 50 && Convert.ToInt32(txtquan10.Text) < 76)
            {
                lblquan10.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan10.Text) > 75 && Convert.ToInt32(txtquan10.Text) < 101)
            {
                lblquan10.BackColor = Color.Red;
            }

            // Quận 11
            if (Convert.ToInt32(txtquan11.Text) >= 0 && Convert.ToInt32(txtquan11.Text) < 26)
            {
                lblquan11.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan11.Text) > 25 && Convert.ToInt32(txtquan11.Text) < 51)
            {
                lblquan11.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan11.Text) > 50 && Convert.ToInt32(txtquan11.Text) < 76)
            {
                lblquan11.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan11.Text) > 75 && Convert.ToInt32(txtquan11.Text) < 101)
            {
                lblquan11.BackColor = Color.Red;
            }

            // Quận 12
            if (Convert.ToInt32(txtquan12.Text) >= 0 && Convert.ToInt32(txtquan12.Text) < 26)
            {
                lblquan12.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan12.Text) > 25 && Convert.ToInt32(txtquan12.Text) < 51)
            {
                lblquan12.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan12.Text) > 50 && Convert.ToInt32(txtquan12.Text) < 76)
            {
                lblquan12.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan12.Text) > 75 && Convert.ToInt32(txtquan12.Text) < 101)
            {
                lblquan12.BackColor = Color.Red;
            }

            // Quận bình thạnh
            if (Convert.ToInt32(txtbinhthanh.Text) >= 0 && Convert.ToInt32(txtbinhthanh.Text) < 26)
            {
                lblbinhthanh.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtbinhthanh.Text) > 25 && Convert.ToInt32(txtbinhthanh.Text) < 51)
            {
                lblbinhthanh.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtbinhthanh.Text) > 50 && Convert.ToInt32(txtbinhthanh.Text) < 76)
            {
                lblbinhthanh.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtbinhthanh.Text) > 75 && Convert.ToInt32(txtbinhthanh.Text) < 101)
            {
                lblbinhthanh.BackColor = Color.Red;
            }

            // Quận thủ đức
            if (Convert.ToInt32(txtthuduc.Text) >= 0 && Convert.ToInt32(txtthuduc.Text) < 26)
            {
                lblthuduc.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtthuduc.Text) > 25 && Convert.ToInt32(txtthuduc.Text) < 51)
            {
                lblthuduc.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtthuduc.Text) > 50 && Convert.ToInt32(txtthuduc.Text) < 76)
            {
                lblthuduc.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtthuduc.Text) > 75 && Convert.ToInt32(txtthuduc.Text) < 101)
            {
                lblthuduc.BackColor = Color.Red;
            }

            // Quận gò vấp
            if (Convert.ToInt32(txtgovap.Text) >= 0 && Convert.ToInt32(txtgovap.Text) < 26)
            {
                lblgovap.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtgovap.Text) > 25 && Convert.ToInt32(txtgovap.Text) < 51)
            {
                lblgovap.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtgovap.Text) > 50 && Convert.ToInt32(txtgovap.Text) < 76)
            {
                lblgovap.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtgovap.Text) > 75 && Convert.ToInt32(txtgovap.Text) < 101)
            {
                lblgovap.BackColor = Color.Red;
            }

            // Quận phú nhuận
            if (Convert.ToInt32(txtphunhuan.Text) >= 0 && Convert.ToInt32(txtphunhuan.Text) < 26)
            {
                lblphunhuan.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtphunhuan.Text) > 25 && Convert.ToInt32(txtphunhuan.Text) < 51)
            {
                lblphunhuan.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtphunhuan.Text) > 50 && Convert.ToInt32(txtphunhuan.Text) < 76)
            {
                lblphunhuan.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtphunhuan.Text) > 75 && Convert.ToInt32(txtphunhuan.Text) < 101)
            {
                lblphunhuan.BackColor = Color.Red;
            }

            // Quận tân bình
            if (Convert.ToInt32(txttanbinh.Text) >= 0 && Convert.ToInt32(txttanbinh.Text) < 26)
            {
                lbltanbinh.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txttanbinh.Text) > 25 && Convert.ToInt32(txttanbinh.Text) < 51)
            {
                lbltanbinh.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txttanbinh.Text) > 50 && Convert.ToInt32(txttanbinh.Text) < 76)
            {
                lbltanbinh.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txttanbinh.Text) > 75 && Convert.ToInt32(txttanbinh.Text) < 101)
            {
                lbltanbinh.BackColor = Color.Red;
            }

            // Quận tân phú
            if (Convert.ToInt32(txttanphu.Text) >= 0 && Convert.ToInt32(txttanphu.Text) < 26)
            {
                lbltanphu.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txttanphu.Text) > 25 && Convert.ToInt32(txttanphu.Text) < 51)
            {
                lbltanphu.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txttanphu.Text) > 50 && Convert.ToInt32(txttanphu.Text) < 76)
            {
                lbltanphu.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txttanphu.Text) > 75 && Convert.ToInt32(txttanphu.Text) < 101)
            {
                lbltanphu.BackColor = Color.Red;
            }

            // Quận bình tân
            if (Convert.ToInt32(txtbinhtan.Text) >= 0 && Convert.ToInt32(txtbinhtan.Text) < 26)
            {
                lblbinhtan.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtbinhtan.Text) > 25 && Convert.ToInt32(txtbinhtan.Text) < 51)
            {
                lblbinhtan.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtbinhtan.Text) > 50 && Convert.ToInt32(txtbinhtan.Text) < 76)
            {
                lblbinhtan.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtbinhtan.Text) > 75 && Convert.ToInt32(txtbinhtan.Text) < 101)
            {
                lblbinhtan.BackColor = Color.Red;
            }

            // huyện nhà bè
            if (Convert.ToInt32(txtnhabe.Text) >= 0 && Convert.ToInt32(txtnhabe.Text) < 26)
            {
                lblnhabe.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtnhabe.Text) > 25 && Convert.ToInt32(txtnhabe.Text) < 51)
            {
                lblnhabe.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtnhabe.Text) > 50 && Convert.ToInt32(txtnhabe.Text) < 76)
            {
                lblnhabe.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtnhabe.Text) > 75 && Convert.ToInt32(txtnhabe.Text) < 101)
            {
                lblnhabe.BackColor = Color.Red;
            }

            // huyện hóc môn
            if (Convert.ToInt32(txthocmon1.Text) >= 0 && Convert.ToInt32(txthocmon1.Text) < 26)
            {
                lblhocmon1.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txthocmon1.Text) > 25 && Convert.ToInt32(txthocmon1.Text) < 51)
            {
                lblhocmon1.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txthocmon1.Text) > 50 && Convert.ToInt32(txthocmon1.Text) < 76)
            {
                lblhocmon1.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txthocmon1.Text) > 75 && Convert.ToInt32(txthocmon1.Text) < 101)
            {
                lblhocmon1.BackColor = Color.Red;
            }

            // huyện bình chánh
            if (Convert.ToInt32(txtbinhchanh.Text) >= 0 && Convert.ToInt32(txtbinhchanh.Text) < 26)
            {
                lblbinhchanh.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtbinhchanh.Text) > 25 && Convert.ToInt32(txtbinhchanh.Text) < 51)
            {
                lblbinhchanh.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtbinhchanh.Text) > 50 && Convert.ToInt32(txtbinhchanh.Text) < 76)
            {
                lblbinhchanh.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtbinhchanh.Text) > 75 && Convert.ToInt32(txtbinhchanh.Text) < 101)
            {
                lblbinhchanh.BackColor = Color.Red;
            }

            // huyện củ chi
            if (Convert.ToInt32(txtcuchi.Text) >= 0 && Convert.ToInt32(txtcuchi.Text) < 26)
            {
                lblcuchi.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtcuchi.Text) > 25 && Convert.ToInt32(txtcuchi.Text) < 51)
            {
                lblcuchi.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtcuchi.Text) > 50 && Convert.ToInt32(txtcuchi.Text) < 76)
            {
                lblcuchi.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtcuchi.Text) > 75 && Convert.ToInt32(txtcuchi.Text) < 101)
            {
                lblcuchi.BackColor = Color.Red;
            }

            // huyện cần giờ
            if (Convert.ToInt32(txtcangio.Text) >= 0 && Convert.ToInt32(txtcangio.Text) < 26)
            {
                lblcangio.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtcangio.Text) > 25 && Convert.ToInt32(txtcangio.Text) < 51)
            {
                lblcangio.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtcangio.Text) > 50 && Convert.ToInt32(txtcangio.Text) < 76)
            {
                lblcangio.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtcangio.Text) > 75 && Convert.ToInt32(txtcangio.Text) < 101)
            {
                lblcangio.BackColor = Color.Red;
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // đổ data vào datagrid view
            dgvquan1.DataSource = TongQuan1().Tables[0];
            dgvquan2.DataSource = TongQuan2().Tables[0];
            dgvquan3.DataSource = TongQuan3().Tables[0];
            dgvquan4.DataSource = TongQuan4().Tables[0];
            dgvquan5.DataSource = TongQuan5().Tables[0];
            dgvquan6.DataSource = TongQuan6().Tables[0];
            dgvquan7.DataSource = TongQuan7().Tables[0];
            dgvquan8.DataSource = TongQuan8().Tables[0];
            dgvquan9.DataSource = TongQuan9().Tables[0];
            dgvquan10.DataSource = TongQuan10().Tables[0];
            dgvquan11.DataSource = TongQuan11().Tables[0];
            dgvquan12.DataSource = TongQuan12().Tables[0];
            dgvbinhthanh.DataSource = Tongbinhthanh().Tables[0];
            dgvthuduc.DataSource = Tongthuduc().Tables[0];
            dgvgovap.DataSource = Tonggovap().Tables[0];
            dgvphunhuan.DataSource = Tongphunhuan().Tables[0];
            dgvtanbinh.DataSource = Tongtanbinh().Tables[0];
            dgvtanphu.DataSource = Tongtanphu().Tables[0];
            dgvbinhtan.DataSource = Tongbinhtan().Tables[0];
            dgvnhabe.DataSource = Tongnhabe().Tables[0];
            dgvhocmon.DataSource = Tonghocmon().Tables[0];
            dgvbinhchanh.DataSource = Tongbinhchanh().Tables[0];
            dgvcuchi.DataSource = Tongcuchi().Tables[0];
            dgvcangio.DataSource = Tongcangio().Tables[0];

            // hiển thị lên TextBox
            txtquan1.DataBindings.Clear();
            txtquan1.DataBindings.Add("Text", dgvquan1.DataSource, "Tong");
            txtquan2.DataBindings.Clear();
            txtquan2.DataBindings.Add("Text", dgvquan2.DataSource, "Tong");
            txtquan3.DataBindings.Clear();
            txtquan3.DataBindings.Add("Text", dgvquan3.DataSource, "Tong");
            txtquan4.DataBindings.Clear();
            txtquan4.DataBindings.Add("Text", dgvquan4.DataSource, "Tong");
            txtquan5.DataBindings.Clear();
            txtquan5.DataBindings.Add("Text", dgvquan5.DataSource, "Tong");
            txtquan6.DataBindings.Clear();
            txtquan6.DataBindings.Add("Text", dgvquan6.DataSource, "Tong");
            txtquan7.DataBindings.Clear();
            txtquan7.DataBindings.Add("Text", dgvquan7.DataSource, "Tong");
            txtquan8.DataBindings.Clear();
            txtquan8.DataBindings.Add("Text", dgvquan8.DataSource, "Tong");
            txtquan9.DataBindings.Clear();
            txtquan9.DataBindings.Add("Text", dgvquan9.DataSource, "Tong");
            txtquan10.DataBindings.Clear();
            txtquan10.DataBindings.Add("Text", dgvquan10.DataSource, "Tong");
            txtquan11.DataBindings.Clear();
            txtquan11.DataBindings.Add("Text", dgvquan11.DataSource, "Tong");
            txtquan12.DataBindings.Clear();
            txtquan12.DataBindings.Add("Text", dgvquan12.DataSource, "Tong");
            txtbinhthanh.DataBindings.Clear();
            txtbinhthanh.DataBindings.Add("Text", dgvbinhthanh.DataSource, "Tong");
            txtthuduc.DataBindings.Clear();
            txtthuduc.DataBindings.Add("Text", dgvthuduc.DataSource, "Tong");
            txtgovap.DataBindings.Clear();
            txtgovap.DataBindings.Add("Text", dgvgovap.DataSource, "Tong");
            txtphunhuan.DataBindings.Clear();
            txtphunhuan.DataBindings.Add("Text", dgvphunhuan.DataSource, "Tong");
            txttanbinh.DataBindings.Clear();
            txttanbinh.DataBindings.Add("Text", dgvtanbinh.DataSource, "Tong");
            txttanphu.DataBindings.Clear();
            txttanphu.DataBindings.Add("Text", dgvtanphu.DataSource, "Tong");
            txtbinhtan.DataBindings.Clear();
            txtbinhtan.DataBindings.Add("Text", dgvbinhtan.DataSource, "Tong");
            txtnhabe.DataBindings.Clear();
            txtnhabe.DataBindings.Add("Text", dgvnhabe.DataSource, "Tong");
            txthocmon1.DataBindings.Clear();
            txthocmon1.DataBindings.Add("Text", dgvhocmon.DataSource, "Tong");
            txtbinhchanh.DataBindings.Clear();
            txtbinhchanh.DataBindings.Add("Text", dgvbinhchanh.DataSource, "Tong");
            txtcuchi.DataBindings.Clear();
            txtcuchi.DataBindings.Add("Text", dgvcuchi.DataSource, "Tong");
            txtcangio.DataBindings.Clear();
            txtcangio.DataBindings.Add("Text", dgvcangio.DataSource, "Tong");


            // Quận 1
            if (Convert.ToInt32(txtquan1.Text) >= 0 && Convert.ToInt32(txtquan1.Text) < 26)
            {
                lblquan1.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan1.Text) > 25 && Convert.ToInt32(txtquan1.Text) < 51)
            {
                lblquan1.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan1.Text) > 50 && Convert.ToInt32(txtquan1.Text) < 76)
            {
                lblquan1.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan1.Text) > 75 && Convert.ToInt32(txtquan1.Text) < 101)
            {
                lblquan1.BackColor = Color.Red;
            }

            // Quận 2
            if (Convert.ToInt32(txtquan2.Text) >= 0 && Convert.ToInt32(txtquan2.Text) < 26)
            {
                lblquan2.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan2.Text) > 25 && Convert.ToInt32(txtquan2.Text) < 51)
            {
                lblquan2.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan2.Text) > 50 && Convert.ToInt32(txtquan2.Text) < 76)
            {
                lblquan2.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan2.Text) > 75 && Convert.ToInt32(txtquan2.Text) < 101)
            {
                lblquan2.BackColor = Color.Red;
            }

            // Quận 3
            if (Convert.ToInt32(txtquan3.Text) >= 0 && Convert.ToInt32(txtquan3.Text) < 26)
            {
                lblquan3.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan3.Text) > 25 && Convert.ToInt32(txtquan3.Text) < 51)
            {
                lblquan3.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan3.Text) > 50 && Convert.ToInt32(txtquan3.Text) < 76)
            {
                lblquan3.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan3.Text) > 75 && Convert.ToInt32(txtquan3.Text) < 101)
            {
                lblquan3.BackColor = Color.Red;
            }

            // Quận 4
            if (Convert.ToInt32(txtquan4.Text) >= 0 && Convert.ToInt32(txtquan4.Text) < 26)
            {
                lblquan4.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan4.Text) > 25 && Convert.ToInt32(txtquan4.Text) < 51)
            {
                lblquan4.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan4.Text) > 50 && Convert.ToInt32(txtquan4.Text) < 76)
            {
                lblquan4.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan4.Text) > 75 && Convert.ToInt32(txtquan4.Text) < 101)
            {
                lblquan4.BackColor = Color.Red;
            }

            // Quận 5
            if (Convert.ToInt32(txtquan5.Text) >= 0 && Convert.ToInt32(txtquan5.Text) < 26)
            {
                lblquan5.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan5.Text) > 25 && Convert.ToInt32(txtquan5.Text) < 51)
            {
                lblquan5.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan5.Text) > 50 && Convert.ToInt32(txtquan5.Text) < 76)
            {
                lblquan5.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan5.Text) > 75 && Convert.ToInt32(txtquan5.Text) < 101)
            {
                lblquan5.BackColor = Color.Red;
            }

            // Quận 6
            if (Convert.ToInt32(txtquan6.Text) >= 0 && Convert.ToInt32(txtquan6.Text) < 26)
            {
                lblquan6.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan6.Text) > 25 && Convert.ToInt32(txtquan6.Text) < 51)
            {
                lblquan6.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan6.Text) > 50 && Convert.ToInt32(txtquan6.Text) < 76)
            {
                lblquan6.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan6.Text) > 75 && Convert.ToInt32(txtquan6.Text) < 101)
            {
                lblquan6.BackColor = Color.Red;
            }

            // Quận 7
            if (Convert.ToInt32(txtquan7.Text) >= 0 && Convert.ToInt32(txtquan7.Text) < 26)
            {
                lblquan7.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan7.Text) > 25 && Convert.ToInt32(txtquan7.Text) < 51)
            {
                lblquan7.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan7.Text) > 50 && Convert.ToInt32(txtquan7.Text) < 76)
            {
                lblquan7.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan7.Text) > 75 && Convert.ToInt32(txtquan7.Text) < 101)
            {
                lblquan7.BackColor = Color.Red;
            }

            // Quận 8
            if (Convert.ToInt32(txtquan8.Text) >= 0 && Convert.ToInt32(txtquan8.Text) < 26)
            {
                lblquan8.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan8.Text) > 25 && Convert.ToInt32(txtquan8.Text) < 51)
            {
                lblquan8.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan8.Text) > 50 && Convert.ToInt32(txtquan8.Text) < 76)
            {
                lblquan8.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan8.Text) > 75 && Convert.ToInt32(txtquan8.Text) < 101)
            {
                lblquan8.BackColor = Color.Red;
            }

            // Quận 9
            if (Convert.ToInt32(txtquan9.Text) >= 0 && Convert.ToInt32(txtquan9.Text) < 26)
            {
                lblquan9.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan9.Text) > 25 && Convert.ToInt32(txtquan9.Text) < 51)
            {
                lblquan9.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan9.Text) > 50 && Convert.ToInt32(txtquan9.Text) < 76)
            {
                lblquan9.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan9.Text) > 75 && Convert.ToInt32(txtquan9.Text) < 101)
            {
                lblquan9.BackColor = Color.Red;
            }

            // Quận 10
            if (Convert.ToInt32(txtquan10.Text) >= 0 && Convert.ToInt32(txtquan10.Text) < 26)
            {
                lblquan10.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan10.Text) > 25 && Convert.ToInt32(txtquan10.Text) < 51)
            {
                lblquan10.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan10.Text) > 50 && Convert.ToInt32(txtquan10.Text) < 76)
            {
                lblquan10.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan10.Text) > 75 && Convert.ToInt32(txtquan10.Text) < 101)
            {
                lblquan10.BackColor = Color.Red;
            }

            // Quận 11
            if (Convert.ToInt32(txtquan11.Text) >= 0 && Convert.ToInt32(txtquan11.Text) < 26)
            {
                lblquan11.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan11.Text) > 25 && Convert.ToInt32(txtquan11.Text) < 51)
            {
                lblquan11.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan11.Text) > 50 && Convert.ToInt32(txtquan11.Text) < 76)
            {
                lblquan11.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan11.Text) > 75 && Convert.ToInt32(txtquan11.Text) < 101)
            {
                lblquan11.BackColor = Color.Red;
            }

            // Quận 12
            if (Convert.ToInt32(txtquan12.Text) >= 0 && Convert.ToInt32(txtquan12.Text) < 26)
            {
                lblquan12.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtquan12.Text) > 25 && Convert.ToInt32(txtquan12.Text) < 51)
            {
                lblquan12.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtquan12.Text) > 50 && Convert.ToInt32(txtquan12.Text) < 76)
            {
                lblquan12.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtquan12.Text) > 75 && Convert.ToInt32(txtquan12.Text) < 101)
            {
                lblquan12.BackColor = Color.Red;
            }

            // Quận bình thạnh
            if (Convert.ToInt32(txtbinhthanh.Text) >= 0 && Convert.ToInt32(txtbinhthanh.Text) < 26)
            {
                lblbinhthanh.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtbinhthanh.Text) > 25 && Convert.ToInt32(txtbinhthanh.Text) < 51)
            {
                lblbinhthanh.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtbinhthanh.Text) > 50 && Convert.ToInt32(txtbinhthanh.Text) < 76)
            {
                lblbinhthanh.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtbinhthanh.Text) > 75 && Convert.ToInt32(txtbinhthanh.Text) < 101)
            {
                lblbinhthanh.BackColor = Color.Red;
            }

            // Quận thủ đức
            if (Convert.ToInt32(txtthuduc.Text) >= 0 && Convert.ToInt32(txtthuduc.Text) < 26)
            {
                lblthuduc.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtthuduc.Text) > 25 && Convert.ToInt32(txtthuduc.Text) < 51)
            {
                lblthuduc.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtthuduc.Text) > 50 && Convert.ToInt32(txtthuduc.Text) < 76)
            {
                lblthuduc.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtthuduc.Text) > 75 && Convert.ToInt32(txtthuduc.Text) < 101)
            {
                lblthuduc.BackColor = Color.Red;
            }

            // Quận gò vấp
            if (Convert.ToInt32(txtgovap.Text) >= 0 && Convert.ToInt32(txtgovap.Text) < 26)
            {
                lblgovap.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtgovap.Text) > 25 && Convert.ToInt32(txtgovap.Text) < 51)
            {
                lblgovap.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtgovap.Text) > 50 && Convert.ToInt32(txtgovap.Text) < 76)
            {
                lblgovap.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtgovap.Text) > 75 && Convert.ToInt32(txtgovap.Text) < 101)
            {
                lblgovap.BackColor = Color.Red;
            }

            // Quận phú nhuận
            if (Convert.ToInt32(txtphunhuan.Text) >= 0 && Convert.ToInt32(txtphunhuan.Text) < 26)
            {
                lblphunhuan.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtphunhuan.Text) > 25 && Convert.ToInt32(txtphunhuan.Text) < 51)
            {
                lblphunhuan.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtphunhuan.Text) > 50 && Convert.ToInt32(txtphunhuan.Text) < 76)
            {
                lblphunhuan.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtphunhuan.Text) > 75 && Convert.ToInt32(txtphunhuan.Text) < 101)
            {
                lblphunhuan.BackColor = Color.Red;
            }

            // Quận tân bình
            if (Convert.ToInt32(txttanbinh.Text) >= 0 && Convert.ToInt32(txttanbinh.Text) < 26)
            {
                lbltanbinh.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txttanbinh.Text) > 25 && Convert.ToInt32(txttanbinh.Text) < 51)
            {
                lbltanbinh.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txttanbinh.Text) > 50 && Convert.ToInt32(txttanbinh.Text) < 76)
            {
                lbltanbinh.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txttanbinh.Text) > 75 && Convert.ToInt32(txttanbinh.Text) < 101)
            {
                lbltanbinh.BackColor = Color.Red;
            }

            // Quận tân phú
            if (Convert.ToInt32(txttanphu.Text) >= 0 && Convert.ToInt32(txttanphu.Text) < 26)
            {
                lbltanphu.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txttanphu.Text) > 25 && Convert.ToInt32(txttanphu.Text) < 51)
            {
                lbltanphu.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txttanphu.Text) > 50 && Convert.ToInt32(txttanphu.Text) < 76)
            {
                lbltanphu.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txttanphu.Text) > 75 && Convert.ToInt32(txttanphu.Text) < 101)
            {
                lbltanphu.BackColor = Color.Red;
            }

            // Quận bình tân
            if (Convert.ToInt32(txtbinhtan.Text) >= 0 && Convert.ToInt32(txtbinhtan.Text) < 26)
            {
                lblbinhtan.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtbinhtan.Text) > 25 && Convert.ToInt32(txtbinhtan.Text) < 51)
            {
                lblbinhtan.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtbinhtan.Text) > 50 && Convert.ToInt32(txtbinhtan.Text) < 76)
            {
                lblbinhtan.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtbinhtan.Text) > 75 && Convert.ToInt32(txtbinhtan.Text) < 101)
            {
                lblbinhtan.BackColor = Color.Red;
            }

            // huyện nhà bè
            if (Convert.ToInt32(txtnhabe.Text) >= 0 && Convert.ToInt32(txtnhabe.Text) < 26)
            {
                lblnhabe.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtnhabe.Text) > 25 && Convert.ToInt32(txtnhabe.Text) < 51)
            {
                lblnhabe.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtnhabe.Text) > 50 && Convert.ToInt32(txtnhabe.Text) < 76)
            {
                lblnhabe.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtnhabe.Text) > 75 && Convert.ToInt32(txtnhabe.Text) < 101)
            {
                lblnhabe.BackColor = Color.Red;
            }

            // huyện hóc môn
            if (Convert.ToInt32(txthocmon1.Text) >= 0 && Convert.ToInt32(txthocmon1.Text) < 26)
            {
                lblhocmon1.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txthocmon1.Text) > 25 && Convert.ToInt32(txthocmon1.Text) < 51)
            {
                lblhocmon1.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txthocmon1.Text) > 50 && Convert.ToInt32(txthocmon1.Text) < 76)
            {
                lblhocmon1.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txthocmon1.Text) > 75 && Convert.ToInt32(txthocmon1.Text) < 101)
            {
                lblhocmon1.BackColor = Color.Red;
            }

            // huyện bình chánh
            if (Convert.ToInt32(txtbinhchanh.Text) >= 0 && Convert.ToInt32(txtbinhchanh.Text) < 26)
            {
                lblbinhchanh.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtbinhchanh.Text) > 25 && Convert.ToInt32(txtbinhchanh.Text) < 51)
            {
                lblbinhchanh.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtbinhchanh.Text) > 50 && Convert.ToInt32(txtbinhchanh.Text) < 76)
            {
                lblbinhchanh.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtbinhchanh.Text) > 75 && Convert.ToInt32(txtbinhchanh.Text) < 101)
            {
                lblbinhchanh.BackColor = Color.Red;
            }

            // huyện củ chi
            if (Convert.ToInt32(txtcuchi.Text) >= 0 && Convert.ToInt32(txtcuchi.Text) < 26)
            {
                lblcuchi.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtcuchi.Text) > 25 && Convert.ToInt32(txtcuchi.Text) < 51)
            {
                lblcuchi.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtcuchi.Text) > 50 && Convert.ToInt32(txtcuchi.Text) < 76)
            {
                lblcuchi.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtcuchi.Text) > 75 && Convert.ToInt32(txtcuchi.Text) < 101)
            {
                lblcuchi.BackColor = Color.Red;
            }

            // huyện cần giờ
            if (Convert.ToInt32(txtcangio.Text) >= 0 && Convert.ToInt32(txtcangio.Text) < 26)
            {
                lblcangio.BackColor = Color.Lime;
            }
            if (Convert.ToInt32(txtcangio.Text) > 25 && Convert.ToInt32(txtcangio.Text) < 51)
            {
                lblcangio.BackColor = Color.Yellow;
            }
            if (Convert.ToInt32(txtcangio.Text) > 50 && Convert.ToInt32(txtcangio.Text) < 76)
            {
                lblcangio.BackColor = Color.Orange;
            }
            if (Convert.ToInt32(txtcangio.Text) > 75 && Convert.ToInt32(txtcangio.Text) < 101)
            {
                lblcangio.BackColor = Color.Red;
            }
        }
    }
}
