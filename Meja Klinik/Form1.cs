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

namespace Meja_Klinik
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader rdr = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String constring = @"Data Source = LAPTOP-0N25QPEU; Initial Catalog = meja_klinik; Integrated Security = true";
            conn = new SqlConnection(constring);
            conn.Open();

            tampilkanPasien();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Menampilkan nama dokter berdasarkan poli yang dipilih
        private void comboBoxPoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDaftarDokter.Items.Clear();
            if (comboBoxPoli.SelectedIndex == 0)
            {
                listBoxDaftarDokter.Items.Add("Dr. Yusuf Mukidi");

            }
            else if (comboBoxPoli.SelectedIndex == 1)
            {
                listBoxDaftarDokter.Items.Add("Dr.Suhendra Pulungan");
            }
            else if (comboBoxPoli.SelectedIndex == 2)
            {
                listBoxDaftarDokter.Items.Add("Dr.Gede Artha Astina");
            }
            else if (comboBoxPoli.SelectedIndex == 3)
            {
                listBoxDaftarDokter.Items.Add("Dr. I Made Morena");
            }
        }

        //Simpan Data
        private void buttonSimpan_Click(object sender, EventArgs e)
        {


            if (conn.State == ConnectionState.Closed)
                conn.Open();


            String ssql = "INSERT INTO pasien VALUES ('" +
                    textBoxNama.Text + "','" +
                    comboBoxJK.SelectedItem + "','" +
                    textBoxUmur.Text + "','" +
                    textBoxAlamat.Text + "','" +
                    textBoxNoTelp.Text + "','" +
                    textBoxPekerjaan.Text + "','" +
                    textBoxNIK.Text + "','" +
                    comboBoxGolDarah.SelectedItem + "','" +
                    comboBoxPoli.SelectedItem + "','" +
                    listBoxDaftarDokter.SelectedItem + "')";

            cmd = new SqlCommand(ssql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Berhasil Disimpan");

            tampilkanPasien();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        //Menampilkan Data Pasien
        private void tampilkanPasien() 
        { 
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            String ssql = "SELECT * FROM pasien";
            cmd = new SqlCommand(ssql, conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows) {
                dataGridView1.Columns.Add("id", "ID Rekam Medis");
                dataGridView1.Columns.Add("nama", "Nama Pasien");
                dataGridView1.Columns.Add("jk", "Jenis Kelamin");
                dataGridView1.Columns.Add("umur", "Umur");
                dataGridView1.Columns.Add("alamat", "Alamat");
                dataGridView1.Columns.Add("noTelp", "No.Telp");
                dataGridView1.Columns.Add("pekerjaan", "Pekerjaan");
                dataGridView1.Columns.Add("nik", "NIK");
                dataGridView1.Columns.Add("golDarah", "Gol. Darah");
                dataGridView1.Columns.Add("poli", "Poli Berobat");
                dataGridView1.Columns.Add("dokter", "Dokter Poli");
                while (rdr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rdr["id"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = rdr["namaPasien"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = rdr["jk"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = rdr["umur"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = rdr["alamat"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = rdr["notelp"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = rdr["pekerjaan"].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = rdr["nik"].ToString();
                    dataGridView1.Rows[n].Cells[8].Value = rdr["golDarah"].ToString();
                    dataGridView1.Rows[n].Cells[9].Value = rdr["poli"].ToString();
                    dataGridView1.Rows[n].Cells[10].Value = rdr["dokterPoli"].ToString();


                }
            }
            rdr.Close();
            conn.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {

        }

        //Melakukan pencarian data berdasarkan id
        private void buttonCari_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            String ssql = "SELECT * FROM pasien WHERE id = '" + textBoxCari.Text + "'";
            cmd = new SqlCommand(ssql, conn);
            rdr = cmd.ExecuteReader();
            if (rdr.HasRows) { 
                rdr.Read();
                textBoxNama.Text = rdr["namaPasien"].ToString();
                comboBoxJK.SelectedItem = rdr["jk"].ToString();
                textBoxUmur.Text = rdr["umur"].ToString();
                textBoxAlamat.Text = rdr["alamat"].ToString();
                textBoxNoTelp.Text = rdr["notelp"].ToString();
                textBoxPekerjaan.Text = rdr["pekerjaan"].ToString();
                textBoxNIK.Text = rdr["nik"].ToString();
                comboBoxGolDarah.Text = rdr["golDarah"].ToString();
                comboBoxPoli.SelectedItem = rdr["poli"].ToString() ;
                listBoxDaftarDokter.SelectedItem = rdr["dokterPoli"].ToString();
            }
            rdr.Close();
            conn.Close();
        }

        //Hapus data berdasarkan id
        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (textBoxCari.Text.Length != 0) { 
                if(conn.State == ConnectionState.Closed)
                    conn.Open();

            String ssql = "DELETE FROM pasien WHERE id = '" + textBoxCari.Text + "'";
            cmd = new SqlCommand(ssql, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            textBoxCari.Clear();
            textBoxNama.Clear();
            textBoxUmur.Clear();
            textBoxAlamat.Clear();
            textBoxNoTelp.Clear();
            textBoxPekerjaan.Clear();
            textBoxNIK.Clear();
            listBoxDaftarDokter.Items.Clear();
            MessageBox.Show("Data Berhasil Dihapus");
                tampilkanPasien();
            }
        }

        //Update data berdasarkan id
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCari.Text.Length != 0)
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                String ssql = "UPDATE pasien " +
                              "SET namaPasien = '" +
                              textBoxNama.Text + "', jk = '" +
                              comboBoxJK.SelectedItem + "', umur = '" +
                              textBoxUmur.Text + "', alamat = '" +
                              textBoxAlamat.Text + "', notelp = '" +
                              textBoxNoTelp.Text + "', pekerjaan = '" +
                              textBoxPekerjaan.Text + "', nik = '" +
                              textBoxNIK.Text + "', golDarah = '" +
                              comboBoxGolDarah.SelectedItem + "', poli = '" +
                              comboBoxPoli.SelectedItem + "', dokterPoli = '" +
                              listBoxDaftarDokter.SelectedItem + "'" +
                              "WHERE id = '" + textBoxCari.Text + "'";
                cmd = new SqlCommand(ssql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                textBoxCari.Clear();
                textBoxNama.Clear();
                textBoxUmur.Clear();
                textBoxAlamat.Clear();
                textBoxNoTelp.Clear();
                textBoxPekerjaan.Clear();
                textBoxNIK.Clear();
                listBoxDaftarDokter.Items.Clear();
                MessageBox.Show("Data Berhasil Diubah");
                tampilkanPasien();


            }
        }

        private void comboBoxGolDarah_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
