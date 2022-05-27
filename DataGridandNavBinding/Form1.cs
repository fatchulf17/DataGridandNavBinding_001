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

namespace DataGridandNavBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=FATCHULFAJRI\FATCHULFAJRI;Initial Catalog=ProdiTI;Persist Security Info=True;User ID=sa;Password=Gensu1711");
            SqlDataAdapter sda = new SqlDataAdapter("Select count (*) from UserProfile where NamaUser = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" && checkBox1.Checked)
            {
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();
            }
            else if (checkBox1.Checked == false)
            {
                MessageBox.Show("Setujui ketentuan");
            }
            else
            {
                MessageBox.Show("Isi Username dan Password dengan benar.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
