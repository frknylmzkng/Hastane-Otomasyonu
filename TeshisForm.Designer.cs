namespace _200255048_Proje2
{
    partial class TeshisForm
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
            teshisNo = new TextBox();
            label2 = new Label();
            hastaTCCmbx = new ComboBox();
            label7 = new Label();
            belirti = new TextBox();
            label1 = new Label();
            konulanTeshis = new TextBox();
            label3 = new Label();
            ilac = new TextBox();
            label4 = new Label();
            label10 = new Label();
            teshisDGV = new DataGridView();
            sil_btn = new Button();
            duzenle_btn = new Button();
            ekle_btn = new Button();
            panel3 = new Panel();
            ilacLbl = new Label();
            teshisLbl = new Label();
            belirtiLbl = new Label();
            hastaSoyadLbl = new Label();
            hastaAdLbl = new Label();
            label5 = new Label();
            hastaSoyad = new TextBox();
            label14 = new Label();
            hastaAd = new TextBox();
            label15 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teshisDGV).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(geri_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 68);
            panel1.TabIndex = 2;
            // 
            // geri_btn
            // 
            geri_btn.BackgroundImage = Properties.Resources.back_button;
            geri_btn.BackgroundImageLayout = ImageLayout.Stretch;
            geri_btn.Location = new Point(12, 12);
            geri_btn.Name = "geri_btn";
            geri_btn.Size = new Size(40, 40);
            geri_btn.TabIndex = 0;
            geri_btn.UseVisualStyleBackColor = true;
            geri_btn.Click += geri_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 735);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 68);
            panel2.TabIndex = 3;
            // 
            // teshisNo
            // 
            teshisNo.Location = new Point(98, 157);
            teshisNo.Name = "teshisNo";
            teshisNo.Size = new Size(145, 23);
            teshisNo.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 129);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "TEŞHİS NO";
            // 
            // hastaTCCmbx
            // 
            hastaTCCmbx.FormattingEnabled = true;
            hastaTCCmbx.Items.AddRange(new object[] { "ERKEK", "KADIN" });
            hastaTCCmbx.Location = new Point(98, 234);
            hastaTCCmbx.Name = "hastaTCCmbx";
            hastaTCCmbx.Size = new Size(117, 23);
            hastaTCCmbx.TabIndex = 36;
            hastaTCCmbx.SelectionChangeCommitted += hastaTCCmbx_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 204);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 35;
            label7.Text = "HASTA TC";
            // 
            // belirti
            // 
            belirti.Location = new Point(98, 420);
            belirti.Name = "belirti";
            belirti.Size = new Size(145, 23);
            belirti.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 392);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 37;
            label1.Text = "BELİRTİLER";
            // 
            // konulanTeshis
            // 
            konulanTeshis.Location = new Point(98, 497);
            konulanTeshis.Name = "konulanTeshis";
            konulanTeshis.Size = new Size(145, 23);
            konulanTeshis.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 469);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 39;
            label3.Text = "KONULAN TEŞHİS";
            // 
            // ilac
            // 
            ilac.Location = new Point(98, 572);
            ilac.Name = "ilac";
            ilac.Size = new Size(145, 23);
            ilac.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 544);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 41;
            label4.Text = "VERİLECEK İLAÇ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(702, 98);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 44;
            label10.Text = "TEŞHİS LİSTESİ";
            // 
            // teshisDGV
            // 
            teshisDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teshisDGV.Location = new Point(449, 129);
            teshisDGV.Name = "teshisDGV";
            teshisDGV.RowTemplate.Height = 25;
            teshisDGV.Size = new Size(591, 217);
            teshisDGV.TabIndex = 43;
            teshisDGV.CellContentClick += teshisDGV_CellContentClick;
            // 
            // sil_btn
            // 
            sil_btn.Location = new Point(316, 642);
            sil_btn.Name = "sil_btn";
            sil_btn.Size = new Size(96, 55);
            sil_btn.TabIndex = 47;
            sil_btn.Text = "SİL";
            sil_btn.UseVisualStyleBackColor = true;
            sil_btn.Click += sil_btn_Click;
            // 
            // duzenle_btn
            // 
            duzenle_btn.Location = new Point(186, 642);
            duzenle_btn.Name = "duzenle_btn";
            duzenle_btn.Size = new Size(96, 55);
            duzenle_btn.TabIndex = 46;
            duzenle_btn.Text = "DÜZENLE";
            duzenle_btn.UseVisualStyleBackColor = true;
            duzenle_btn.Click += duzenle_btn_Click;
            // 
            // ekle_btn
            // 
            ekle_btn.Location = new Point(65, 642);
            ekle_btn.Name = "ekle_btn";
            ekle_btn.Size = new Size(96, 55);
            ekle_btn.TabIndex = 45;
            ekle_btn.Text = "EKLE";
            ekle_btn.UseVisualStyleBackColor = true;
            ekle_btn.Click += ekle_btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(ilacLbl);
            panel3.Controls.Add(teshisLbl);
            panel3.Controls.Add(belirtiLbl);
            panel3.Controls.Add(hastaSoyadLbl);
            panel3.Controls.Add(hastaAdLbl);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(451, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(589, 296);
            panel3.TabIndex = 48;
            // 
            // ilacLbl
            // 
            ilacLbl.AutoSize = true;
            ilacLbl.Location = new Point(339, 158);
            ilacLbl.Name = "ilacLbl";
            ilacLbl.Size = new Size(79, 15);
            ilacLbl.TabIndex = 6;
            ilacLbl.Text = "VERİLEN İLAÇ";
            // 
            // teshisLbl
            // 
            teshisLbl.AutoSize = true;
            teshisLbl.Location = new Point(339, 101);
            teshisLbl.Name = "teshisLbl";
            teshisLbl.Size = new Size(101, 15);
            teshisLbl.TabIndex = 5;
            teshisLbl.Text = "KONULAN TEŞHİS";
            // 
            // belirtiLbl
            // 
            belirtiLbl.AutoSize = true;
            belirtiLbl.Location = new Point(54, 187);
            belirtiLbl.Name = "belirtiLbl";
            belirtiLbl.Size = new Size(63, 15);
            belirtiLbl.TabIndex = 4;
            belirtiLbl.Text = "BELİRTİLER";
            // 
            // hastaSoyadLbl
            // 
            hastaSoyadLbl.AutoSize = true;
            hastaSoyadLbl.Location = new Point(54, 142);
            hastaSoyadLbl.Name = "hastaSoyadLbl";
            hastaSoyadLbl.Size = new Size(86, 15);
            hastaSoyadLbl.TabIndex = 3;
            hastaSoyadLbl.Text = "HASTA SOYADI";
            // 
            // hastaAdLbl
            // 
            hastaAdLbl.AutoSize = true;
            hastaAdLbl.Location = new Point(54, 101);
            hastaAdLbl.Name = "hastaAdLbl";
            hastaAdLbl.Size = new Size(65, 15);
            hastaAdLbl.TabIndex = 2;
            hastaAdLbl.Text = "HASTA ADI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 28);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 0;
            label5.Text = "TEŞHİS ÖZET";
            // 
            // hastaSoyad
            // 
            hastaSoyad.Location = new Point(98, 359);
            hastaSoyad.Name = "hastaSoyad";
            hastaSoyad.Size = new Size(145, 23);
            hastaSoyad.TabIndex = 52;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(98, 331);
            label14.Name = "label14";
            label14.Size = new Size(86, 15);
            label14.TabIndex = 51;
            label14.Text = "HASTA SOYADI";
            // 
            // hastaAd
            // 
            hastaAd.Location = new Point(99, 288);
            hastaAd.Name = "hastaAd";
            hastaAd.ReadOnly = true;
            hastaAd.Size = new Size(145, 23);
            hastaAd.TabIndex = 50;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(99, 260);
            label15.Name = "label15";
            label15.Size = new Size(65, 15);
            label15.TabIndex = 49;
            label15.Text = "HASTA ADI";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 86);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 7;
            label6.Text = "Hasta Adı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 125);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 8;
            label8.Text = "Hasta Soyadı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 172);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 9;
            label9.Text = "Belirtiler";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(339, 142);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 10;
            label11.Text = "Verilen İlaç";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(339, 86);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 11;
            label12.Text = "Konulan Teşhis";
            // 
            // TeshisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1182, 803);
            Controls.Add(hastaSoyad);
            Controls.Add(label14);
            Controls.Add(hastaAd);
            Controls.Add(label15);
            Controls.Add(panel3);
            Controls.Add(sil_btn);
            Controls.Add(duzenle_btn);
            Controls.Add(ekle_btn);
            Controls.Add(label10);
            Controls.Add(teshisDGV);
            Controls.Add(ilac);
            Controls.Add(label4);
            Controls.Add(konulanTeshis);
            Controls.Add(label3);
            Controls.Add(belirti);
            Controls.Add(label1);
            Controls.Add(hastaTCCmbx);
            Controls.Add(label7);
            Controls.Add(teshisNo);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TeshisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeshisForm";
            Load += TeshisForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teshisDGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox teshisNo;
        private Label label2;
        private ComboBox hastaTCCmbx;
        private Label label7;
        private TextBox belirti;
        private Label label1;
        private TextBox konulanTeshis;
        private Label label3;
        private TextBox ilac;
        private Label label4;
        private Label label10;
        private DataGridView teshisDGV;
        private Button sil_btn;
        private Button duzenle_btn;
        private Button ekle_btn;
        private Panel panel3;
        private Label ilacLbl;
        private Label teshisLbl;
        private Label belirtiLbl;
        private Label hastaSoyadLbl;
        private Label hastaAdLbl;
        private Label label5;
        private Button geri_btn;
        private TextBox hastaSoyad;
        private Label label14;
        private TextBox hastaAd;
        private Label label15;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label6;
    }
}