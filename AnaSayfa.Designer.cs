namespace _200255048_Proje2
{
    partial class AnaSayfa
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
            label1 = new Label();
            panel1 = new Panel();
            teshisBtn = new Button();
            hastaBtn = new Button();
            doktorBtn = new Button();
            label2 = new Label();
            panel2 = new Panel();
            kapat_btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 0;
            label1.Text = "KIRIKKALE ÜNİVERSİTESİ";
            // 
            // panel1
            // 
            panel1.Controls.Add(teshisBtn);
            panel1.Controls.Add(hastaBtn);
            panel1.Controls.Add(doktorBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 73);
            panel1.TabIndex = 1;
            // 
            // teshisBtn
            // 
            teshisBtn.Location = new Point(1013, 12);
            teshisBtn.Name = "teshisBtn";
            teshisBtn.Size = new Size(100, 40);
            teshisBtn.TabIndex = 6;
            teshisBtn.Text = "TEŞHİS";
            teshisBtn.UseVisualStyleBackColor = true;
            teshisBtn.Click += teshisBtn_Click;
            // 
            // hastaBtn
            // 
            hastaBtn.Location = new Point(853, 12);
            hastaBtn.Name = "hastaBtn";
            hastaBtn.Size = new Size(100, 40);
            hastaBtn.TabIndex = 5;
            hastaBtn.Text = "HASTA";
            hastaBtn.UseVisualStyleBackColor = true;
            hastaBtn.Click += hastaBtn_Click;
            // 
            // doktorBtn
            // 
            doktorBtn.Location = new Point(684, 12);
            doktorBtn.Name = "doktorBtn";
            doktorBtn.Size = new Size(100, 40);
            doktorBtn.TabIndex = 4;
            doktorBtn.Text = "DOKTOR";
            doktorBtn.UseVisualStyleBackColor = true;
            doktorBtn.Click += doktorBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 34);
            label2.Name = "label2";
            label2.Size = new Size(249, 25);
            label2.TabIndex = 3;
            label2.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // panel2
            // 
            panel2.Controls.Add(kapat_btn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 640);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 73);
            panel2.TabIndex = 2;
            // 
            // kapat_btn
            // 
            kapat_btn.BackColor = SystemColors.Control;
            kapat_btn.BackgroundImage = Properties.Resources.turn_off;
            kapat_btn.BackgroundImageLayout = ImageLayout.Stretch;
            kapat_btn.ForeColor = Color.Transparent;
            kapat_btn.Location = new Point(1089, 12);
            kapat_btn.Name = "kapat_btn";
            kapat_btn.Size = new Size(71, 58);
            kapat_btn.TabIndex = 3;
            kapat_btn.UseVisualStyleBackColor = false;
            kapat_btn.Click += kapat_btn_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._154773;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 713);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaSayfa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button kapat_btn;
        private Button teshisBtn;
        private Button hastaBtn;
        private Button doktorBtn;
    }
}