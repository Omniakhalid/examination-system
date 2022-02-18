using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;
namespace crystalReport
{
    public partial class frmHome : Form
    {
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter dataAdapter;
        DataTable dt;
        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=DESKTOP-P84ETB9\\MSSQLSERVER01;Initial Catalog=Northwind; " +
                "Integrated Security = true ; TrustServerCertificate=true ";


        }
        frmReport1 report1 = new frmReport1();
        frmReport2 report2 = new frmReport2();
        frmReport3 report3 = new frmReport3();
        frmReport4 report4 = new frmReport4();
        frmReport5 report5 = new frmReport5();
        frmReport6 report6 = new frmReport6();

        private void btn_report_Click(object sender, EventArgs e)
        {
            //this.Hide();
            report1.Show();
        }
        private void btn_report2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            report2.Show();
        }

        private void btn_report3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            report3.Show();
        }

        private void btn_report4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            report4.Show();
        }

        private void btn_report5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            report5.Show();
        }

        private void btn_repor6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            report6.Show();
        }
    }
}
