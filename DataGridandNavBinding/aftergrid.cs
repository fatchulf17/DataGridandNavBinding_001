using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridandNavBinding
{
    public partial class aftergrid : Form
    {
        public aftergrid()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            DGridView gv = new DGridView();
            gv.Show();
        }

        private void aftergrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mahasiswaTI.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.mahasiswaTI.Mahasiswa);

        }
    }
}
