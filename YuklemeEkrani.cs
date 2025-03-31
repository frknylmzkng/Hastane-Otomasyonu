using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200255048_Proje2
{
    public partial class YuklemeEkrani : Form
    {
        public YuklemeEkrani()
        {
            InitializeComponent();
        }
        int baslangic = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Zamanlayıcı için bir sayaç ayarlayıp 100e kadar arttırdım
            baslangic++;
            durumCubuk.Value = baslangic;
            if (durumCubuk.Value == 100)
            {
                durumCubuk.Value = 0;
                timer1.Stop();
                Form1 giris = new Form1();
                giris.Show();
                this.Hide();
            }
        }
        private void YuklemeEkrani_Load(object sender, EventArgs e)
        {
            //Zamanlayıcıyı başlattım
            this.timer1.Start();
        }
    }
}
