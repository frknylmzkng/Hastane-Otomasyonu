namespace _200255048_Proje2
{
    partial class DoktorForm
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
            label2 = new Label();
            doktorTC = new TextBox();
            doktorAd = new TextBox();
            label3 = new Label();
            doktorSoyad = new TextBox();
            label4 = new Label();
            doktorDGV = new DataGridView();
            ekle_btn = new Button();
            duzenle_btn = new Button();
            sil_btn = new Button();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doktorDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(geri_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1162, 68);
            panel1.TabIndex = 0;
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
            panel2.Location = new Point(0, 737);
            panel2.Name = "panel2";
            panel2.Size = new Size(1162, 68);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 144);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "DOKTOR TC";
            // 
            // doktorTC
            // 
            doktorTC.Location = new Point(80, 172);
            doktorTC.Name = "doktorTC";
            doktorTC.Size = new Size(145, 23);
            doktorTC.TabIndex = 4;
            // 
            // doktorAd
            // 
            doktorAd.Location = new Point(80, 251);
            doktorAd.Name = "doktorAd";
            doktorAd.Size = new Size(145, 23);
            doktorAd.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 223);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "DOKTOR AD";
            // 
            // doktorSoyad
            // 
            doktorSoyad.Location = new Point(80, 341);
            doktorSoyad.Name = "doktorSoyad";
            doktorSoyad.Size = new Size(145, 23);
            doktorSoyad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 313);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "DOKTOR SOYAD";
            // 
            // doktorDGV
            // 
            doktorDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doktorDGV.Location = new Point(487, 135);
            doktorDGV.Name = "doktorDGV";
            doktorDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            doktorDGV.RowTemplate.Height = 25;
            doktorDGV.Size = new Size(591, 541);
            doktorDGV.TabIndex = 11;
            doktorDGV.CellContentClick += doktorDGV_CellContentClick;
            // 
            // ekle_btn
            // 
            ekle_btn.Location = new Point(55, 424);
            ekle_btn.Name = "ekle_btn";
            ekle_btn.Size = new Size(96, 55);
            ekle_btn.TabIndex = 12;
            ekle_btn.Text = "EKLE";
            ekle_btn.UseVisualStyleBackColor = true;
            ekle_btn.Click += ekle_btn_Click;
            // 
            // duzenle_btn
            // 
            duzenle_btn.Location = new Point(176, 424);
            duzenle_btn.Name = "duzenle_btn";
            duzenle_btn.Size = new Size(96, 55);
            duzenle_btn.TabIndex = 13;
            duzenle_btn.Text = "DÜZENLE";
            duzenle_btn.UseVisualStyleBackColor = true;
            duzenle_btn.Click += duzenle_btn_Click;
            // 
            // sil_btn
            // 
            sil_btn.Location = new Point(306, 424);
            sil_btn.Name = "sil_btn";
            sil_btn.Size = new Size(96, 55);
            sil_btn.TabIndex = 14;
            sil_btn.Text = "SİL";
            sil_btn.UseVisualStyleBackColor = true;
            sil_btn.Click += sil_btn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(700, 100);
            label10.Name = "label10";
            label10.Size = new Size(91, 15);
            label10.TabIndex = 40;
            label10.Text = "DOKTOR LİSTESİ";
            // 
            // DoktorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1162, 805);
            Controls.Add(label10);
            Controls.Add(sil_btn);
            Controls.Add(duzenle_btn);
            Controls.Add(ekle_btn);
            Controls.Add(doktorDGV);
            Controls.Add(doktorSoyad);
            Controls.Add(label4);
            Controls.Add(doktorAd);
            Controls.Add(label3);
            Controls.Add(doktorTC);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoktorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoktorForm";
            Load += DoktorForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)doktorDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox doktorTC;
        private TextBox doktorAd;
        private Label label3;
        private TextBox doktorSoyad;
        private Label label4;
        private DataGridView doktorDGV;
        private Button ekle_btn;
        private Button duzenle_btn;
        private Button sil_btn;
        private Label label10;
        private Button geri_btn;
    }
}