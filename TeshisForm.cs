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
    public partial class TeshisForm : Form
    {
        //Veritabanı ile bağlantı yaptığımız kısım
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
        ""C:\Users\FURKAN YILMAZ\Documents\HastaneYonetimSistemi.mdf"";Integrated Security=True;Connect Timeout=30");

        //Kişi sayısını tutmak için bir metot yazdım
        void KisiSayisi()
        {
            baglanti.Open();
            string query = "SELECT * FROM TeshisTbl"; //T-SQL kod
            SqlDataAdapter uyumla = new SqlDataAdapter(query, baglanti); //Kodu uyguladık
            SqlCommandBuilder olustur = new SqlCommandBuilder(uyumla);
            var veriKumesi = new DataSet();
            uyumla.Fill(veriKumesi); //Veriyi DataSet'e doldurduk
            teshisDGV.DataSource = veriKumesi.Tables[0];
            baglanti.Close();
        }
        //Hasta TC'lerini ComboBox'ta gösterebilmek için
        void KisiSayisiCombo()
        {
            string query = "SELECT * FROM HastaTbl";
            SqlCommand komut = new SqlCommand(query, baglanti);
            SqlDataReader okuyucu;
            try
            {
                baglanti.Open();
                DataTable tablo = new DataTable();
                tablo.Columns.Add("HastaTC", typeof(int));
                okuyucu = komut.ExecuteReader();
                tablo.Load(okuyucu);
                hastaTCCmbx.ValueMember = "HastaTC";
                hastaTCCmbx.DataSource = tablo;
                baglanti.Close();

            }
            catch (Exception ex) //en genel istisnayı yakalamak için
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        string hastaAdi;
        void CBIsımGoster() //hastaTC'sini seçtikten sonra hasta adını göstermek için
        {
            baglanti.Open();
            string query = "SELECT * FROM HastaTbl WHERE HastaTC='" + hastaTCCmbx.SelectedValue.ToString() + "'";
            SqlCommand komut = new SqlCommand(query, baglanti); ;
            DataTable tablo = new DataTable();
            SqlDataAdapter uyumla = new SqlDataAdapter(komut);
            uyumla.Fill(tablo);
            foreach (DataRow sutun in tablo.Rows)
            {
                hastaAdi = sutun["HastaAd"].ToString();
                hastaAd.Text = hastaAdi;
            }
            baglanti.Close();
        }
        public TeshisForm()
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

        //Teşhis eklediğimiz kısım
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            //Eğer herhangi bir veri eksikse teşhisi eklemiyoruz
            if (teshisNo.Text == "" || hastaAd.Text == "" || hastaSoyad.Text == "" || belirti.Text == "" || konulanTeshis.Text == "" || ilac.Text == "")
                MessageBox.Show("EKSİK VERİ GİRİŞİ. TEKRAR DENEYİNİZ.");
            else
            {
                baglanti.Open();
                string query = "INSERT INTO TeshisTbl VALUES (" + teshisNo.Text + ",'" + hastaTCCmbx.SelectedValue.ToString() + "','" + hastaAd.Text + "','" + hastaSoyad.Text + "'," +
                    "'" + belirti.Text + "','" + konulanTeshis.Text + "', '" + ilac.Text + "')"; //Çalıştıracağımız T-SQL kodu
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("TEŞHİS BAŞARIYLA EKLENDİ");
                baglanti.Close();
                KisiSayisi();
            }
        }
        //Veritabanında olan bilgileri göstermek için
        private void TeshisForm_Load(object sender, EventArgs e)
        {
            KisiSayisiCombo();
            KisiSayisi();
        }
        //Ekli olan hastaları görmek için
        private void hastaTCCmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CBIsımGoster();
        }

        //Teşhis silme kısmı
        private void sil_btn_Click(object sender, EventArgs e)
        {
            if (teshisNo.Text == "") MessageBox.Show(" TEŞHİS NO BOŞ OLAMAZ");
            else
            {
                baglanti.Open();
                string query = "DELETE FROM TeshisTbl WHERE TeshisNo=" + teshisNo.Text + "";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("TEŞHİS BAŞARIYLA SİLİNDİ.");
                baglanti.Close();
                KisiSayisi();
            }
        }

        private void teshisDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DVG'den seçilen verileri TextBox'lara ve panel içine otomatik olarak yazmak için
            teshisNo.Text = teshisDGV.CurrentRow.Cells[0].Value.ToString();
            hastaTCCmbx.SelectedValue = teshisDGV.CurrentRow.Cells[1].Value.ToString();
            hastaAd.Text = teshisDGV.CurrentRow.Cells[2].Value.ToString();
            hastaSoyad.Text = teshisDGV.CurrentRow.Cells[3].Value.ToString();
            belirti.Text = teshisDGV.CurrentRow.Cells[4].Value.ToString();
            konulanTeshis.Text = teshisDGV.CurrentRow.Cells[5].Value.ToString();
            ilac.Text = teshisDGV.CurrentRow.Cells[6].Value.ToString();

            hastaAdLbl.Text = teshisDGV.CurrentRow.Cells[2].Value.ToString();
            hastaSoyadLbl.Text = teshisDGV.CurrentRow.Cells[3].Value.ToString();
            belirtiLbl.Text = teshisDGV.CurrentRow.Cells[4].Value.ToString();
            teshisLbl.Text = teshisDGV.CurrentRow.Cells[5].Value.ToString();
            ilacLbl.Text = teshisDGV.CurrentRow.Cells[6].Value.ToString();

        }

        //Teşhis düzenlediğimiz kısım
        private void duzenle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "UPDATE TeshisTbl SET Belirti='" + belirti.Text + "', Teshis='" + konulanTeshis.Text + "', İlac='" + ilac.Text + "' WHERE TeshisNo='" + teshisNo.Text + "'";
            SqlCommand komut = new SqlCommand(query, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("TEŞHİS BİLGİLERİ BAŞARIYLA GÜNCELLENDİ");
            baglanti.Close();
            KisiSayisi();
        }
    }
}
