namespace _200255048_Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * GÝRÝÞ BUTONU
         * Sadece belirli bir TC-Þifre kombinasyonu için izin veriyor
         */
        private void button1_Click(object sender, EventArgs e)
        {
            if (TC.Text == "" || Sifre.Text == "") MessageBox.Show("TC KÝMLÝK NUMARASI VE ÞÝFRE GÝRÝNÝZ.");
            else
            {
                if (TC.Text == "123123123" && Sifre.Text == "123456")
                {
                    AnaSayfa ana = new AnaSayfa();
                    ana.Show();
                    this.Hide();
                }
                else MessageBox.Show("TC KÝMLÝK NUMARASI YA DA ÞÝFRE HATALI."); //DENEME
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