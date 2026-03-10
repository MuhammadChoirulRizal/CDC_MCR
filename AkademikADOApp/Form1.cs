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

        private void Disconnected(object sender, EventArgs e)
        {
            try
            {
                
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
    
                    conn.Close();

                    
                    lblStatus.Text = "Status : Database Disconnected";

                    
                    MessageBox.Show("Koneksi tidak bisa terhubung");
                }
                else
                {
                    MessageBox.Show("Database memang belum terhubung.");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Gagal memutus koneksi: " + ex.Message);
            }
        }
    }
}
