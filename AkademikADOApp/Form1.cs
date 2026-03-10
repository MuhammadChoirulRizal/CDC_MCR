using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        string connString =
        "Data Source=LAPTOP-5LMNPAS3\\CHOY;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Connected(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
