﻿namespace _200255048_Proje2
{
    partial class YuklemeEkrani
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            durumCubuk = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 95);
            label1.Name = "label1";
            label1.Size = new Size(486, 50);
            label1.TabIndex = 0;
            label1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(136, 28);
            label2.Name = "label2";
            label2.Size = new Size(422, 50);
            label2.TabIndex = 1;
            label2.Text = "KIRIKKALE ÜNİVERSİTESİ";
            // 
            // durumCubuk
            // 
            durumCubuk.Location = new Point(188, 312);
            durumCubuk.Name = "durumCubuk";
            durumCubuk.Size = new Size(342, 23);
            durumCubuk.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // YuklemeEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(durumCubuk);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YuklemeEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YuklemeEkrani";
            Load += YuklemeEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar durumCubuk;
        private System.Windows.Forms.Timer timer1;
    }
}