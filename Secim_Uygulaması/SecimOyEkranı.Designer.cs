namespace Secim_Uygulaması
{
    partial class SecimOyEkranı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecimOyEkranı));
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.txtEP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(157, 38);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(291, 48);
            this.txtIlce.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEP);
            this.groupBox1.Controls.Add(this.txtDP);
            this.groupBox1.Controls.Add(this.txtCP);
            this.groupBox1.Controls.Add(this.txtBP);
            this.groupBox1.Controls.Add(this.txtAP);
            this.groupBox1.Controls.Add(this.txtIlce);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçim Oy Ekranı";
            // 
            // txtAP
            // 
            this.txtAP.Location = new System.Drawing.Point(157, 92);
            this.txtAP.Name = "txtAP";
            this.txtAP.Size = new System.Drawing.Size(291, 48);
            this.txtAP.TabIndex = 1;
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(157, 146);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(291, 48);
            this.txtBP.TabIndex = 2;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(157, 200);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(291, 48);
            this.txtCP.TabIndex = 3;
            // 
            // txtDP
            // 
            this.txtDP.Location = new System.Drawing.Point(157, 254);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(291, 48);
            this.txtDP.TabIndex = 4;
            // 
            // txtEP
            // 
            this.txtEP.Location = new System.Drawing.Point(157, 308);
            this.txtEP.Name = "txtEP";
            this.txtEP.Size = new System.Drawing.Size(291, 48);
            this.txtEP.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "İlçe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "A Partisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "B Partisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "C Partisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "D Partisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "E Partisi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnGrafikler);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(13, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(15, 38);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(163, 46);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Location = new System.Drawing.Point(195, 38);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(163, 46);
            this.btnGrafikler.TabIndex = 1;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(374, 38);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 46);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SecimOyEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(604, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "SecimOyEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Oy Giriş Ekranı";
            this.Load += new System.EventHandler(this.SecimOyEkranı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEP;
        private System.Windows.Forms.TextBox txtDP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.TextBox txtAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGrafikler;
    }
}

