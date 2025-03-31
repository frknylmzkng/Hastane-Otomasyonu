using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Veritabanı işlemleri yapabilmek için ekledim

namespace _200255048_Proje2
{
    public partial class DoktorForm : Form
    {
        //Veritabanı ile bağlantı yaptığımız kısım
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        ""C:\Users\FURKAN YILMAZ\Documents\HastaneYonetimSistemi.mdf"";Integrated Security=True;Connect Timeout=30");

        public DoktorForm()
        {
            InitializeComponent();
        }
        //Kişi sayısını tutmak için bir metot yazdım
        void KisiSayisi()
        {
            baglanti.Open();
            string query = "SELECT * FROM DoktorTbl"; //T-SQL kodu
            SqlDataAdapter uyumla = new SqlDataAdapter(query, baglanti); //Kodu uyguladık
            SqlCommandBuilder olustur = new SqlCommandBuilder(uyumla);
            var veriKumesi = new DataSet();
            uyumla.Fill(veriKumesi); //Veriyi DataSet'e doldurduk
            doktorDGV.DataSource = veriKumesi.Tables[0];
            baglanti.Close();
        }
        //Geri butonu
        private void geri_btn_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
        //Doktor eklediğimiz kısım
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            //Eğer herhangi bir veri eksikse doktor eklemiyoruz
            if (doktorTC.Text == "" || doktorAd.Text == "" || doktorSoyad.Text == "")
                MessageBox.Show("EKSİK VERİ GİRİŞİ. TEKRAR DENEYİNİZ.");
            else
            {
                baglanti.Open();
                string query = "INSERT INTO DoktorTbl VALUES (" + doktorTC.Text + ",'" + doktorAd.Text + "','" + doktorSoyad.Text + "')"; //Çalıştırılacak T-SQL kodu
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("DOKTOR BAŞARIYLA EKLENDİ");
                baglanti.Close();
                KisiSayisi();
            }
        }
        //Veritabanında olan verileri yüklemek için
        private void DoktorForm_Load(object sender, EventArgs e)
        {
            KisiSayisi();
        }
        //Doktor silme butonu
        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (doktorTC.Text == "") MessageBox.Show("DOKTOR TC BOŞ OLAMAZ");
            else
            {
                baglanti.Open();
                string query = "DELETE FROM DoktorTbl WHERE DoktorTC=" + doktorTC.Text + "";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("DOKTOR BAŞARIYLA SİLİNDİ.");
                baglanti.Close();
                KisiSayisi();
            }
        }

        private void doktorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DVG'den seçilen verileri TextBox'lara otomatik olarak yazmak için
            doktorTC.Text = doktorDGV.CurrentRow.Cells[0].Value.ToString();
            doktorAd.Text = doktorDGV.CurrentRow.Cells[1].Value.ToString();
            doktorSoyad.Text = doktorDGV.CurrentRow.Cells[2].Value.ToString();
        }
        //Doktor bilgilerini düzenleme kısmı
        private void duzenle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "UPDATE DoktorTbl SET DoktorAd='" + doktorAd.Text + "', DoktorSoyad='" + doktorSoyad.Text + "' " +
                "WHERE DoktorTC='" + doktorTC.Text + "'"; //Çalıştırılacak T-SQL kodu
            SqlCommand komut = new SqlCommand(query, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("DOKTOR BİLGİLERİ BAŞARIYLA GÜNCELLENDİ");
            baglanti.Close();
            KisiSayisi();
        }
    }
}
