namespace Meja_Klinik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxJK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUmur = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNoTelp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPekerjaan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNIK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGolDarah = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPoli = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxDaftarDokter = new System.Windows.Forms.ListBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCari = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pasien";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.Location = new System.Drawing.Point(96, 179);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(343, 34);
            this.textBoxNama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenis Kelamin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxJK
            // 
            this.comboBoxJK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxJK.FormattingEnabled = true;
            this.comboBoxJK.Items.AddRange(new object[] {
            "Laki Laki",
            "Perempuan"});
            this.comboBoxJK.Location = new System.Drawing.Point(96, 249);
            this.comboBoxJK.Name = "comboBoxJK";
            this.comboBoxJK.Size = new System.Drawing.Size(343, 33);
            this.comboBoxJK.TabIndex = 3;
            this.comboBoxJK.Text = "- Pilih -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Umur";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxUmur
            // 
            this.textBoxUmur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUmur.Location = new System.Drawing.Point(96, 317);
            this.textBoxUmur.Name = "textBoxUmur";
            this.textBoxUmur.Size = new System.Drawing.Size(343, 34);
            this.textBoxUmur.TabIndex = 5;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.Location = new System.Drawing.Point(96, 384);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(343, 34);
            this.textBoxAlamat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // textBoxNoTelp
            // 
            this.textBoxNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoTelp.Location = new System.Drawing.Point(96, 452);
            this.textBoxNoTelp.Name = "textBoxNoTelp";
            this.textBoxNoTelp.Size = new System.Drawing.Size(343, 34);
            this.textBoxNoTelp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. Telp";
            // 
            // textBoxPekerjaan
            // 
            this.textBoxPekerjaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPekerjaan.Location = new System.Drawing.Point(96, 523);
            this.textBoxPekerjaan.Name = "textBoxPekerjaan";
            this.textBoxPekerjaan.Size = new System.Drawing.Size(343, 34);
            this.textBoxPekerjaan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pekerjaan";
            // 
            // textBoxNIK
            // 
            this.textBoxNIK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIK.Location = new System.Drawing.Point(637, 179);
            this.textBoxNIK.Name = "textBoxNIK";
            this.textBoxNIK.Size = new System.Drawing.Size(343, 34);
            this.textBoxNIK.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "NIK";
            // 
            // comboBoxGolDarah
            // 
            this.comboBoxGolDarah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGolDarah.FormattingEnabled = true;
            this.comboBoxGolDarah.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.comboBoxGolDarah.Location = new System.Drawing.Point(637, 249);
            this.comboBoxGolDarah.Name = "comboBoxGolDarah";
            this.comboBoxGolDarah.Size = new System.Drawing.Size(343, 33);
            this.comboBoxGolDarah.TabIndex = 15;
            this.comboBoxGolDarah.Text = "- Pilih Gol. Darah -";
            this.comboBoxGolDarah.SelectedIndexChanged += new System.EventHandler(this.comboBoxGolDarah_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Golongan Darah";
            // 
            // comboBoxPoli
            // 
            this.comboBoxPoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPoli.FormattingEnabled = true;
            this.comboBoxPoli.Items.AddRange(new object[] {
            "Poli Umum - 16:00:00",
            "Poli Gigi - 18:00:00",
            "Poli THT - 18:00:00",
            "Poli Bedah - 09:00:00"});
            this.comboBoxPoli.Location = new System.Drawing.Point(637, 320);
            this.comboBoxPoli.Name = "comboBoxPoli";
            this.comboBoxPoli.Size = new System.Drawing.Size(343, 33);
            this.comboBoxPoli.TabIndex = 17;
            this.comboBoxPoli.Text = "- Pilih Poli -";
            this.comboBoxPoli.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoli_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(633, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Poli Berobat";
            // 
            // listBoxDaftarDokter
            // 
            this.listBoxDaftarDokter.FormattingEnabled = true;
            this.listBoxDaftarDokter.ItemHeight = 16;
            this.listBoxDaftarDokter.Location = new System.Drawing.Point(637, 372);
            this.listBoxDaftarDokter.Name = "listBoxDaftarDokter";
            this.listBoxDaftarDokter.Size = new System.Drawing.Size(343, 148);
            this.listBoxDaftarDokter.TabIndex = 18;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.Location = new System.Drawing.Point(98, 599);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(247, 50);
            this.buttonSimpan.TabIndex = 19;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 727);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 165);
            this.dataGridView1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 692);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Data Pasien";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCari.Location = new System.Drawing.Point(379, 45);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(343, 34);
            this.textBoxCari.TabIndex = 23;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(508, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Masukan ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // buttonCari
            // 
            this.buttonCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCari.Location = new System.Drawing.Point(739, 43);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(118, 38);
            this.buttonCari.TabIndex = 24;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(739, 599);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(241, 50);
            this.buttonHapus.TabIndex = 25;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(419, 599);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(253, 50);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "Ubah";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(40, 40);
            this.ClientSize = new System.Drawing.Size(1115, 1053);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.listBoxDaftarDokter);
            this.Controls.Add(this.comboBoxPoli);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxGolDarah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxNIK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPekerjaan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNoTelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUmur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxJK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxJK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUmur;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNoTelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPekerjaan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNIK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGolDarah;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPoli;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxDaftarDokter;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

