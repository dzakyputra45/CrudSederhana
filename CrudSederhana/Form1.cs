using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudSederhana
{
    public partial class Form1: Form
    {
        //Ganti "Server" sesuai dengan SQL SERVER 
        private string connectionstring = "Data Source=TUF-DZAKY-1450\\DZAKYPUTRA;" +
        "Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnTAMBAH_Click(object sender, EventArgs e)
        {

        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {

        }

        private void btnUBAH_Click(object sender, EventArgs e)
        {

        }

        private void btnREFRESH_Click(object sender, EventArgs e)
        {

        }

        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
