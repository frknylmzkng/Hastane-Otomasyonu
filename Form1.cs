namespace _200255048_Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * G�R�� BUTONU
         * Sadece belirli bir TC-�ifre kombinasyonu i�in izin veriyor
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (TC.Text == "" || Sifre.Text == "") MessageBox.Show("TC K�ML�K NUMARASI VE ��FRE G�R�N�Z.");
            else
            {
                if (TC.Text == "123123123" && Sifre.Text == "123456")
                {
                    AnaSayfa ana = new AnaSayfa();
                    ana.Show();
                    this.Hide();
                }
                else MessageBox.Show("TC K�ML�K NUMARASI YA DA ��FRE HATALI."); //DENEME
            }
        }
        //Girilen bilgileri temizleyen Label
        private void temizleLbl_Click(object sender, EventArgs e)
        {
            TC.Text = "";
            Sifre.Text = "";
        }
    }
}