using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data source=MIHRAP-PC\SQLEXPRESS;Initial catalog=DBNotKayit;Integrated security=true;TrustServerCertificate=true");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // SQL sorgusu
            string query = "SELECT * FROM TBLDERS";

            // Bağlantı ve veri çekme işlemleri
            using (SqlConnection connection = new SqlConnection(baglanti.ConnectionString))
            {
                try
                {
                    // Veri adaptörü
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Veri tablosu
                    DataTable dataTable = new DataTable();

                    // Verileri doldur
                    dataAdapter.Fill(dataTable);

                    // DataGridView'e verileri bağla
                    dataGridView1.DataSource = dataTable;

                    // Geçen ve Kalan Öğrenci Sayısını Hesapla
                    SqlCommand gecenSayisiKomut = new SqlCommand("SELECT COUNT(*) FROM TBLDERS WHERE DURUM = 'True'", connection);
                    SqlCommand kalanSayisiKomut = new SqlCommand("SELECT COUNT(*) FROM TBLDERS WHERE DURUM = 'False'", connection);

                    connection.Open();
                    lblGecenSayisi.Text = "Geçen Sayısı: " + gecenSayisiKomut.ExecuteScalar().ToString();
                    lblKalanSayisi.Text = "Kalan Sayısı: " + kalanSayisiKomut.ExecuteScalar().ToString();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO TBLDERS (OGRNUMARA, OGRAD, OGRSOYAD) VALUES (@P1, @P2, @P3)", baglanti);
                komut.Parameters.AddWithValue("@P1", mskNumara.Text);
                komut.Parameters.AddWithValue("@P2", txtAd.Text);
                komut.Parameters.AddWithValue("@P3", txtSoyad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Sisteme Eklendi");
                LoadData(); // Yeni eklenen veriyi yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            mskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            // Ortalama Hesaplama ve Görüntüleme
            double s1 = Convert.ToDouble(txtSinav1.Text);
            double s2 = Convert.ToDouble(txtSinav2.Text);
            double s3 = Convert.ToDouble(txtSinav3.Text);
            double ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text =  ortalama.ToString("0.00");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtSinav1.Text);
            s2 = Convert.ToDouble(txtSinav2.Text);
            s3 = Convert.ToDouble(txtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text =  ortalama.ToString("0.00");

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLDERS SET OGRS1=@P1, OGRS2=@P2, OGRS3=@P3, ORTALAMA=@P4, DURUM=@P5 WHERE OGRNUMARA=@P6", baglanti);
            komut.Parameters.AddWithValue("@P1", txtSinav1.Text);
            komut.Parameters.AddWithValue("@P2", txtSinav2.Text);
            komut.Parameters.AddWithValue("@P3", txtSinav3.Text);
            komut.Parameters.AddWithValue("@P4", ortalama);
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", mskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");

            LoadData();
        }
    }
}
