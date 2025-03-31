using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Veritabanı işlemleri yapabilmek için ekledim

namespace _200255048_Proje2
{
    public partial class HastaForm : Form
    {
        //Veritabanı ile bağlantı yaptığımız kısım
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        ""C:\Users\FURKAN YILMAZ\Documents\HastaneYonetimSistemi.mdf"";Integrated Security=True;Connect Timeout=30");

        //Kişi sayısını tutmak için bir metot yazdım
        void KisiSayisi()
        {
            baglanti.Open();
            string query = "SELECT * FROM HastaTbl"; //T-SQL kod
            SqlDataAdapter uyumla = new SqlDataAdapter(query, baglanti); //Kodu uyguladık
            SqlCommandBuilder olustur = new SqlCommandBuilder(uyumla);
            var veriKumesi = new DataSet();
            uyumla.Fill(veriKumesi); //Veriyi DataSet'e doldurduk
            hastaDGV.DataSource = veriKumesi.Tables[0];
            baglanti.Close();
        }
        public HastaForm()
        {
            InitializeComponent();
        }
        //Geri butonu
        private void geri_btn_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
        //Hasta eklediğimiz kısım
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            //Eğer herhangi bir veri eksikse hastayı eklemiyoruz
            if (hastaTC.Text == "" || hastaAd.Text == "" || hastaSoyad.Text == "" || hastaAdres.Text == "" || hastaTelefon.Text == ""
                || hastaYas.Text == "" || hastaCinsiyetCmbx.Text == "" || hastaKanCmbx.Text == "" || hastaKronik.Text == "")
                MessageBox.Show("EKSİK VERİ GİRİŞİ. TEKRAR DENEYİNİZ.");
            else
            {
                baglanti.Open();
                string query = "INSERT INTO HastaTbl VALUES (" + hastaTC.Text + ",'" + hastaAd.Text + "','" + hastaSoyad.Text + "'," +
                    "'" + hastaAdres.Text + "','" + hastaTelefon.Text + "', '" + hastaYas.Text + "', '" + hastaCinsiyetCmbx.SelectedItem.ToString() + "', " +
                    "'" + hastaKanCmbx.SelectedItem.ToString() + "', '" + hastaKronik.Text + "')"; //Çalıştırılacak olan T-SQL kodu
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("HASTA BAŞARIYLA EKLENDİ");
                baglanti.Close();
                KisiSayisi();
            }
        }
        //Veritabanında olan verileri göstermek için
        private void HastaForm_Load(object sender, EventArgs e)
        {
            KisiSayisi();
        }
        //Hasta sildiğimiz kısım
        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (hastaTC.Text == "") MessageBox.Show("HASTA TC BOŞ OLAMAZ");
            else
            {
                baglanti.Open();
                string query = "DELETE FROM HastaTbl WHERE HastaTC=" + hastaTC.Text + "";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("HASTA BAŞARIYLA SİLİNDİ.");
                baglanti.Close();
                KisiSayisi();
            }
        }

        private void hastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DVG'den seçilen verileri TextBox'lara otomatik olarak yazmak için
            hastaTC.Text = hastaDGV.CurrentRow.Cells[0].Value.ToString();
            hastaAd.Text = hastaDGV.CurrentRow.Cells[1].Value.ToString();
            hastaSoyad.Text = hastaDGV.CurrentRow.Cells[2].Value.ToString();
            hastaAdres.Text = hastaDGV.CurrentRow.Cells[3].Value.ToString();
            hastaTelefon.Text = hastaDGV.CurrentRow.Cells[4].Value.ToString();
            hastaYas.Text = hastaDGV.CurrentRow.Cells[5].Value.ToString();
            hastaCinsiyetCmbx.SelectedItem = hastaDGV.CurrentRow.Cells[6].Value.ToString();
            hastaKanCmbx.SelectedItem = hastaDGV.CurrentRow.Cells[7].Value.ToString();
            hastaKronik.Text = hastaDGV.CurrentRow.Cells[8].Value.ToString();
        }
        //Teşhis düzenlediğimiz kısım
        private void duzenle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "UPDATE HastaTbl SET HastaAd='" + hastaAd.Text + "', HastaSoyad='" + hastaSoyad.Text + "', HastaAdres='" + hastaAdres.Text + "', " +
                "HastaTelefon='" + hastaTelefon.Text + "', " +
                "HastaYas='" + hastaYas.Text + "', HastaCinsiyet='" + hastaCinsiyetCmbx.SelectedItem.ToString() + "', HastaKan='" + hastaKanCmbx.SelectedItem.ToString() + "', " +
                "HastaKronik='" + hastaKronik.Text + "' WHERE HastaTC='" + hastaTC.Text + "'"; //Öalıştırılacak T-SQL kodu
            SqlCommand komut = new SqlCommand(query, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("HASTA BİLGİLERİ BAŞARIYLA GÜNCELLENDİ");
            baglanti.Close();
            KisiSayisi();
        }
    }
}
