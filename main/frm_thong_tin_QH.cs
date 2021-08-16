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
    public partial class frm_thong_tin_QH : Form
    {
        public frm_thong_tin_QH()
        {
            InitializeComponent();
        }

        DataSet GetAllQH()
        {
            DataSet get = new DataSet();
            string sql = "EXEC dbo.getallQH";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql, con);
                dap.Fill(get);
                con.Close();
                con.Dispose();
            }
            return get;

        }

        DataSet findQH()
        {
            DataSet find = new DataSet();
            string sql = "EXEC dbo.InfoQH N'" + cbquanhuyen.Text + "'";
            using (SqlConnection con = new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql,con);
                dap.Fill(find);
                con.Close();
                con.Dispose();
            }
            return find;
            
        }
        private void frm_thong_tin_QH_Load(object sender, EventArgs e)
        {
            var dap = new SqlDataAdapter("EXEC dbo.getallQH", ConnectionString.connection);
            var table = new DataTable();
            dap.Fill(table);
            cbquanhuyen.DisplayMember = "TenQH";
            //cbquanhuyen.ValueMember = "ID";
            cbquanhuyen.DataSource = table;

            dgvfindQH.DataSource = findQH().Tables[0];

            txtmaqh.DataBindings.Clear();
            txtmaqh.DataBindings.Add("Text",dgvfindQH.DataSource,"MaQH");
            txttenqh.DataBindings.Clear();
            txttenqh.DataBindings.Add("Text", dgvfindQH.DataSource, "TenQH");
            txtdientich.DataBindings.Clear();
            txtdientich.DataBindings.Add("Text", dgvfindQH.DataSource, "DienTich");
            txtsophuongxa.DataBindings.Clear();
            txtsophuongxa.DataBindings.Add("Text", dgvfindQH.DataSource, "SoPhuongXa");
            txtdanso.DataBindings.Clear();
            txtdanso.DataBindings.Add("Text", dgvfindQH.DataSource, "DanSo");
        }

        private void cbquanhuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvfindQH.DataSource = findQH().Tables[0];

            txtmaqh.DataBindings.Clear();
            txtmaqh.DataBindings.Add("Text", dgvfindQH.DataSource, "MaQH");
            txttenqh.DataBindings.Clear();
            txttenqh.DataBindings.Add("Text", dgvfindQH.DataSource, "TenQH");
            txtdientich.DataBindings.Clear();
            txtdientich.DataBindings.Add("Text", dgvfindQH.DataSource, "DienTich");
            txtsophuongxa.DataBindings.Clear();
            txtsophuongxa.DataBindings.Add("Text", dgvfindQH.DataSource, "SoPhuongXa");
            txtdanso.DataBindings.Clear();
            txtdanso.DataBindings.Add("Text", dgvfindQH.DataSource, "DanSo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
