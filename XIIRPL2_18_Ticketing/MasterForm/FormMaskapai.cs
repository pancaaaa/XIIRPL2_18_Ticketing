using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL2_18_Ticketing.MasterForm
{
    public partial class FormMaskapai : Form
    {

        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FormMaskapai()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMaskapai_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_ticket_xii_rpl1_18.tbl_maskapai" +
                    "(nama, perusahaan,jumlahkru,deskripsi)" +
                    "VALUES" +
                    "('" + textNama.Text + "','" + textPerusahaan.Text + "'," +
                    "'" + textJumlahKru.Text + "','" + textDeskripsi.Text + "')";

                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textJumlahKru_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
