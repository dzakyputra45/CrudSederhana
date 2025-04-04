﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        //Event saat form pertama kali dibuat
        private void Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //Fungsi untuk mengosongkan semua input pada textbox
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNAMA.Clear();
            txtEMAIL.Clear();
            txtTELEPON.Clear();
            txtALAMAT.Clear();

            //Fokus kembali ke NIM agar user siap memasukkan data baru
            txtNIM.Focus();
        }
        

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT NIM AS [NIM], NAMA, EMAIL, TELEPON, ALAMAT FROM Mahasiswa";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMahasiswa.AutoGenerateColumns = true;
                    dgvMahasiswa.DataSource = dt;

                    ClearForm(); //Auto Clear setelah load data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Fungsi untuk menambahkan data
        private void btnTAMBAH_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            { 
                try
                {
                    if (txtNIM.Text == "" || txtNAMA.Text == "" || txtEMAIL.Text == "" || txtTELEPON.Text == "")
                    {
                        MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    conn.Open();
                    string query = "Insert INTO Mahasiswa (NIM, NAMA, EMAIL, TELEPON, ALAMAT) VALUES (@NIM, @NAMA, @EMAIL, @TELEPON, @ALAMAT)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIM", txtNIM.Text.Trim());
                        cmd.Parameters.AddWithValue("@NAMA", txtNAMA.Text.Trim());
                        cmd.Parameters.AddWithValue("@EMAIL", txtEMAIL.Text.Trim());
                        cmd.Parameters.AddWithValue("@TELEPON", txtTELEPON.Text.Trim());
                        cmd.Parameters.AddWithValue("@ALAMAT", txtALAMAT.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearForm(); //auto clear setelah tambah data
                        }
                        else
                        {
                            MessageBox.Show("Data tidak berhasil ditambahkan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHAPUS_Click(object sender, EventArgs e)
        {
            if (dgvMahasiswa.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionstring))
                    {
                        try
                        {
                            string nim = dgvMahasiswa.SelectedRows[0].Cells["NIM"].Value.ToString();
                            conn.Open();
                            string query = "DELETE FROM Mahasiswa WHERE NIM = @NIM";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@NIM, NIM");
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data Berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                    ClearForm(); // Auto clear setelah hapus data
                                }
                                else
                                {
                                    MessageBox.Show("Data tidak ditemukan atau gagal dihapus!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUBAH_Click(object sender, EventArgs e)
        {

        }

        //Fungsi untuk merefresh tampilan DataGridView
        private void btnREFRESH_Click(object sender, EventArgs e)
        {
            LoadData();

            //Debuggging ; Cek jumlah kolom dan baris
            MessageBox.Show($"Jumlah Kolom: {dgvMahasiswa.ColumnCount}\nJumlah Baris: {dgvMahasiswa.RowCount}",
                "Debugging DataGridView", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMahasiswa.Rows[e.RowIndex];

                //coba gunakan indeks jika "NIM" tidak ditemukan
                txtNIM.Text = row.Cells[0].Value.ToString();
                txtNAMA.Text = row.Cells[1].Value?.ToString();
                txtEMAIL.Text = row.Cells[2].Value?.ToString();
                txtTELEPON.Text = row.Cells[3].Value?.ToString();
                txtALAMAT.Text = row.Cells[4].Value?.ToString();
            }
        }
    }
}
