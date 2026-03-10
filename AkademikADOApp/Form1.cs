using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        string connString =
        "Data Source=LAPTOP-5LMNPAS3\\CHOY;Initial Catalog=DBAkademikADO;Integrated Security=True";
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connected(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                lblStatus.Text = "Status : Database Connected";
                MessageBox.Show("Koneksi ke database berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal :" + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
