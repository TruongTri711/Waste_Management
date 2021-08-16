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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        DataSet laychitietrac()
        {
            DataSet GetDetail = new DataSet();
            string sql = "EXEC dbo.LayChiTietRac N'"+cbcacQH.Text+"', '"+cbnam.Text+"'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql,con);
                dap.Fill(GetDetail);
                con.Close();
                con.Dispose();
            }
            return GetDetail;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            // lấy năm
            var dap = new SqlDataAdapter("EXEC dbo.LayNam",ConnectionString.connection);
            var table = new DataTable();
            dap.Fill(table);
            cbnam.DisplayMember = "Nam";
            cbnam.DataSource = table;

            // lấy ra các QH
            var dap1 = new SqlDataAdapter("EXEC dbo.LayQH", ConnectionString.connection);
            var table1 = new DataTable();
            dap1.Fill(table1);
            cbcacQH.DisplayMember = "TenQH";
            cbcacQH.DataSource = table1;

            // đổ data vào data grid view
            dgvfind.DataSource = laychitietrac().Tables[0];

            // hiển thị lên các Textbox
            txtnam.DataBindings.Clear();
            txtnam.DataBindings.Add("Text", dgvfind.DataSource, "Nam");
            txttenQH.DataBindings.Clear();
            txttenQH.DataBindings.Add("Text", dgvfind.DataSource, "TenQH");
            txtsinhoat.DataBindings.Clear();
            txtsinhoat.DataBindings.Add("Text",dgvfind.DataSource, "RacSinhHoat");
            txtcongngiep.DataBindings.Clear();
            txtcongngiep.DataBindings.Add("Text", dgvfind.DataSource, "RacCongNghiep");
            txtyte.DataBindings.Clear();
            txtyte.DataBindings.Add("Text", dgvfind.DataSource, "RacYTe");
            txtkhac.DataBindings.Clear();
            txtkhac.DataBindings.Add("Text", dgvfind.DataSource, "RacKhac");
            txttong.DataBindings.Clear();
            txttong.DataBindings.Add("Text", dgvfind.DataSource, "Tong");
        }

        private void mnuthongtin_Click(object sender, EventArgs e)
        {
            frm_thong_tin_QH frm = new frm_thong_tin_QH();
            frm.ShowDialog();
        }

        private void mnuthongke_Click(object sender, EventArgs e)
        {
            frm_chi_so_rac frm = new frm_chi_so_rac();
            frm.ShowDialog();
        }

        private void cbnam_SelectedIndexChanged(object sender, EventArgs e)
        {
            // đổ data vào data grid view
            dgvfind.DataSource = laychitietrac().Tables[0];

            // hiển thị lên các Textbox
            txtnam.DataBindings.Clear();
            txtnam.DataBindings.Add("Text", dgvfind.DataSource, "Nam");
            txttenQH.DataBindings.Clear();
            txttenQH.DataBindings.Add("Text", dgvfind.DataSource, "TenQH");
            txtsinhoat.DataBindings.Clear();
            txtsinhoat.DataBindings.Add("Text", dgvfind.DataSource, "RacSinhHoat");
            txtcongngiep.DataBindings.Clear();
            txtcongngiep.DataBindings.Add("Text", dgvfind.DataSource, "RacCongNghiep");
            txtyte.DataBindings.Clear();
            txtyte.DataBindings.Add("Text", dgvfind.DataSource, "RacYTe");
            txtkhac.DataBindings.Clear();
            txtkhac.DataBindings.Add("Text", dgvfind.DataSource, "RacKhac");
            txttong.DataBindings.Clear();
            txttong.DataBindings.Add("Text", dgvfind.DataSource, "Tong");
        }

        private void cbcacQH_SelectedIndexChanged(object sender, EventArgs e)
        {
            // đổ data vào data grid view
            dgvfind.DataSource = laychitietrac().Tables[0];

            // hiển thị lên các Textbox
            txtnam.DataBindings.Clear();
            txtnam.DataBindings.Add("Text", dgvfind.DataSource, "Nam");
            txttenQH.DataBindings.Clear();
            txttenQH.DataBindings.Add("Text", dgvfind.DataSource, "TenQH");
            txtsinhoat.DataBindings.Clear();
            txtsinhoat.DataBindings.Add("Text", dgvfind.DataSource, "RacSinhHoat");
            txtcongngiep.DataBindings.Clear();
            txtcongngiep.DataBindings.Add("Text", dgvfind.DataSource, "RacCongNghiep");
            txtyte.DataBindings.Clear();
            txtyte.DataBindings.Add("Text", dgvfind.DataSource, "RacYTe");
            txtkhac.DataBindings.Clear();
            txtkhac.DataBindings.Add("Text", dgvfind.DataSource, "RacKhac");
            txttong.DataBindings.Clear();
            txttong.DataBindings.Add("Text", dgvfind.DataSource, "Tong");
        }

        private void btntinhtoan_Click(object sender, EventArgs e)
        {
            int kq = Convert.ToInt32(txtsinhoat.Text) + Convert.ToInt32(txtcongngiep.Text) + Convert.ToInt32(txtyte.Text) + Convert.ToInt32(txtkhac.Text);
            txttong.Text = kq.ToString();
        }

        private void mnudubao_Click(object sender, EventArgs e)
        {
            frm_du_bao frm = new frm_du_bao();
            frm.ShowDialog();
        }

        int x = 300;
        int y = 319;

        private void ttrphongto_Click(object sender, EventArgs e)
        {
            ptbha.Size = new Size(x + 20, y + 20);
            x = x + 20;
            y = y + 20;
        }

        private void tttrthunho_Click(object sender, EventArgs e)
        {
            ptbha.Size = new Size(x - 20, y - 20);
            x = x - 20;
            y = y - 20;
        }

        private void tttrbinhthuong_Click(object sender, EventArgs e)
        {
            x = 300;
            y = 319;
            ptbha.Size = new Size(x, y);
        }
    }
}
