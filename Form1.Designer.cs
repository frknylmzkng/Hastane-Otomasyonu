namespace _200255048_Proje2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            TC = new TextBox();
            Sifre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            temizleLbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(315, 32);
            label1.TabIndex = 0;
            label1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // button1
            // 
            button1.Location = new Point(293, 394);
            button1.Name = "button1";
            button1.Size = new Size(172, 71);
            button1.TabIndex = 1;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TC
            // 
            TC.Location = new Point(276, 181);
            TC.Name = "TC";
            TC.Size = new Size(204, 23);
            TC.TabIndex = 2;
            // 
            // Sifre
            // 
            Sifre.Location = new Point(276, 254);
            Sifre.Name = "Sifre";
            Sifre.Size = new Size(204, 23);
            Sifre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 152);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 4;
            label2.Text = "TC KİMLİK NUMARASI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 226);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "ŞİFRE";
            // 
            // temizleLbl
            // 
            temizleLbl.AutoSize = true;
            temizleLbl.Location = new Point(348, 492);
            temizleLbl.Name = "temizleLbl";
            temizleLbl.Size = new Size(52, 15);
            temizleLbl.TabIndex = 6;
            temizleLbl.Text = "TEMİZLE";
            temizleLbl.Click += temizleLbl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(temizleLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Sifre);
            Controls.Add(TC);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox TC;
        private TextBox Sifre;
        private Label label2;
        private Label label3;
        private Label temizleLbl;
    }
}