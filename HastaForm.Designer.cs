namespace _200255048_Proje2
{
    partial class HastaForm
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
            panel1 = new Panel();
            geri_btn = new Button();
            panel2 = new Panel();
            sil_btn = new Button();
            duzenle_btn = new Button();
            ekle_btn = new Button();
            hastaDGV = new DataGridView();
            hastaSoyad = new TextBox();
            label4 = new Label();
            hastaAd = new TextBox();
            label3 = new Label();
            hastaTC = new TextBox();
            label2 = new Label();
            hastaYas = new TextBox();
            label1 = new Label();
            hastaTelefon = new TextBox();
            label5 = new Label();
            hastaAdres = new TextBox();
            label6 = new Label();
            label7 = new Label();
            hastaCinsiyetCmbx = new ComboBox();
            hastaKanCmbx = new ComboBox();
            label8 = new Label();
            hastaKronik = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hastaDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(geri_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 68);
            panel1.TabIndex = 1;
            // 
            // geri_btn
            // 
            geri_btn.BackgroundImage = Properties.Resources.back_button;
            geri_btn.BackgroundImageLayout = ImageLayout.Stretch;
            geri_btn.Location = new Point(12, 12);
            geri_btn.Name = "geri_btn";
            geri_btn.Size = new Size(40, 40);
            geri_btn.TabIndex = 1;
            geri_btn.UseVisualStyleBackColor = true;
            geri_btn.Click += geri_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 724);
            panel2.Name = "panel2";
            panel2.Size = new Size(1198, 68);
            panel2.TabIndex = 2;
            // 
            // sil_btn
            // 
            sil_btn.Location = new Point(304, 623);
            sil_btn.Name = "sil_btn";
            sil_btn.Size = new Size(96, 55);
            sil_btn.TabIndex = 26;
            sil_btn.Text = "SİL";
            sil_btn.UseVisualStyleBackColor = true;
            sil_btn.Click += sil_btn_Click;
            // 
            // duzenle_btn
            // 
            duzenle_btn.Location = new Point(174, 623);
            duzenle_btn.Name = "duzenle_btn";
            duzenle_btn.Size = new Size(96, 55);
            duzenle_btn.TabIndex = 25;
            duzenle_btn.Text = "DÜZENLE";
            duzenle_btn.UseVisualStyleBackColor = true;
            duzenle_btn.Click += duzenle_btn_Click;
            // 
            // ekle_btn
            // 
            ekle_btn.Location = new Point(53, 623);
            ekle_btn.Name = "ekle_btn";
            ekle_btn.Size = new Size(96, 55);
            ekle_btn.TabIndex = 24;
            ekle_btn.Text = "EKLE";
            ekle_btn.UseVisualStyleBackColor = true;
            ekle_btn.Click += ekle_btn_Click;
            // 
            // hastaDGV
            // 
            hastaDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hastaDGV.Location = new Point(509, 126);
            hastaDGV.Name = "hastaDGV";
            hastaDGV.RowTemplate.Height = 25;
            hastaDGV.Size = new Size(591, 541);
            hastaDGV.TabIndex = 23;
            hastaDGV.CellContentClick += hastaDGV_CellContentClick;
            // 
            // hastaSoyad
            // 
            hastaSoyad.Location = new Point(34, 275);
            hastaSoyad.Name = "hastaSoyad";
            hastaSoyad.Size = new Size(145, 23);
            hastaSoyad.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 247);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 19;
            label4.Text = "HASTA SOYAD";
            // 
            // hastaAd
            // 
            hastaAd.Location = new Point(34, 201);
            hastaAd.Name = "hastaAd";
            hastaAd.Size = new Size(145, 23);
            hastaAd.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 164);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 17;
            label3.Text = "HASTA AD";
            // 
            // hastaTC
            // 
            hastaTC.Location = new Point(34, 126);
            hastaTC.Name = "hastaTC";
            hastaTC.Size = new Size(145, 23);
            hastaTC.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 15;
            label2.Text = "HASTA TC";
            // 
            // hastaYas
            // 
            hastaYas.Location = new Point(34, 477);
            hastaYas.Name = "hastaYas";
            hastaYas.Size = new Size(145, 23);
            hastaYas.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 449);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 31;
            label1.Text = "HASTA YAŞ";
            // 
            // hastaTelefon
            // 
            hastaTelefon.Location = new Point(34, 407);
            hastaTelefon.Name = "hastaTelefon";
            hastaTelefon.Size = new Size(145, 23);
            hastaTelefon.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 379);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 29;
            label5.Text = "HASTA TELEFON";
            // 
            // hastaAdres
            // 
            hastaAdres.Location = new Point(34, 341);
            hastaAdres.Name = "hastaAdres";
            hastaAdres.Size = new Size(145, 23);
            hastaAdres.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 313);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 27;
            label6.Text = "HASTA ADRES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 520);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 33;
            label7.Text = "HASTA CİNSİYET";
            // 
            // hastaCinsiyetCmbx
            // 
            hastaCinsiyetCmbx.FormattingEnabled = true;
            hastaCinsiyetCmbx.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            hastaCinsiyetCmbx.Location = new Point(34, 550);
            hastaCinsiyetCmbx.Name = "hastaCinsiyetCmbx";
            hastaCinsiyetCmbx.Size = new Size(117, 23);
            hastaCinsiyetCmbx.TabIndex = 34;
            // 
            // hastaKanCmbx
            // 
            hastaKanCmbx.FormattingEnabled = true;
            hastaKanCmbx.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            hastaKanCmbx.Location = new Point(219, 128);
            hastaKanCmbx.Name = "hastaKanCmbx";
            hastaKanCmbx.Size = new Size(117, 23);
            hastaKanCmbx.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(219, 98);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 35;
            label8.Text = "HASTA KAN GRUBU";
            // 
            // hastaKronik
            // 
            hastaKronik.Location = new Point(219, 201);
            hastaKronik.Name = "hastaKronik";
            hastaKronik.Size = new Size(145, 23);
            hastaKronik.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(219, 173);
            label9.Name = "label9";
            label9.Size = new Size(185, 15);
            label9.TabIndex = 37;
            label9.Text = "HASTANIN KRONİK RAHATSIZLIĞI";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(737, 93);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 39;
            label10.Text = "HASTA LİSTESİ";
            // 
            // HastaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1198, 792);
            Controls.Add(label10);
            Controls.Add(hastaKronik);
            Controls.Add(label9);
            Controls.Add(hastaKanCmbx);
            Controls.Add(label8);
            Controls.Add(hastaCinsiyetCmbx);
            Controls.Add(label7);
            Controls.Add(hastaYas);
            Controls.Add(label1);
            Controls.Add(hastaTelefon);
            Controls.Add(label5);
            Controls.Add(hastaAdres);
            Controls.Add(label6);
            Controls.Add(sil_btn);
            Controls.Add(duzenle_btn);
            Controls.Add(ekle_btn);
            Controls.Add(hastaDGV);
            Controls.Add(hastaSoyad);
            Controls.Add(label4);
            Controls.Add(hastaAd);
            Controls.Add(label3);
            Controls.Add(hastaTC);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HastaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HastaForm";
            Load += HastaForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hastaDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button sil_btn;
        private Button duzenle_btn;
        private Button ekle_btn;
        private DataGridView hastaDGV;
        private TextBox hastaSoyad;
        private Label label4;
        private TextBox hastaAd;
        private Label label3;
        private TextBox hastaTC;
        private Label label2;
        private TextBox hastaYas;
        private Label label1;
        private TextBox hastaTelefon;
        private Label label5;
        private TextBox hastaAdres;
        private Label label6;
        private Label label7;
        private ComboBox hastaCinsiyetCmbx;
        private ComboBox hastaKanCmbx;
        private Label label8;
        private TextBox hastaKronik;
        private Label label9;
        private Label label10;
        private Button geri_btn;
    }
}