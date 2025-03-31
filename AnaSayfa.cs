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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        //Logout butonu
        private void kapat_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        //Doktor Form'u açan kısım
        private void doktorBtn_Click(object sender, EventArgs e)
        {
            DoktorForm doktor = new DoktorForm();
            doktor.Show();
            this.Hide();
        }
        //Hasta Form'u açan kısım
        private void hastaBtn_Click(object sender, EventArgs e)
        {
            HastaForm hasta = new HastaForm();
            hasta.Show();
            this.Hide();
        }
        //Teshis Form'u açan kısım
        private void teshisBtn_Click(object sender, EventArgs e)
        {
            TeshisForm teshis = new TeshisForm();
            teshis.Show();
            this.Hide();
        }
    }
}
