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
    public partial class frm_du_bao : Form
    {
        public frm_du_bao()
        {
            InitializeComponent();
        }

        private void frm_du_bao_Load(object sender, EventArgs e)
        {
            txtnamdau.Select();
        }

        private void btnnamdau_Click(object sender, EventArgs e)
        {
            string sql = "SELECT SUM(RacSinhHoat) AS RacSinhHoat,SUM(RacCongNghiep) AS RacCongNghiep,SUM(RacYte) AS RacYTe,SUM(RacKhac) AS RacKhac, Nam FROM dbo.ChiSoRac WHERE Nam = '"+txtnamdau.Text+"' GROUP BY Nam";
            using (SqlConnection con=new SqlConnection(ConnectionString.connection))
            {
                con.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql,con);
                DataTable tb = new DataTable();
                dap.Fill(tb);
                CrystalReport2 rp = new CrystalReport2();
                rp.SetDataSource(tb);
                crtrpdubao.ReportSource = rp;
                con.Close();
                con.Dispose();
            }
        
        }
    }
}
