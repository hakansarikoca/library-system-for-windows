
namespace GorselProgramlama1
{
    partial class Uygulama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uygulama));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "İSİM SOYİSİM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(718, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "GEÇİRİLEN SÜRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(925, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(95, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kitap Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(299, 174);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(204, 31);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kitabı Kiralama Süresi";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(385, 577);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Küçük Prens (Antoine de Saint-Exupery) [çıkarıldı]",
            "Şeker Portakalı (Jose Mauro de Vasconcelos)",
            "Oliver Twist (Charles Dickens)",
            "Alice Harikalar Ülkesinde (Lewis Carroll)",
            "Gülliver’in Gezileri (Jonathan Swift)",
            "Define Adası (Robert Louis Stevenson)",
            "Robin Hood (Howard Pyle)",
            "Tom Sawyer (Mark Twain)",
            "Ezop Masalları",
            "Andersen Masalları I-II",
            "Üç Silahşörler (Alexandre Dumas, père)",
            "La Fontaine’den Seçmeler",
            "Pinokyo (Carlo Collodi)",
            "Seksen Günde Devr-i Âlem (Jules Verne)",
            "İnci (roman) (John Steinbeck)",
            "Beyaz Yele (René Guillot)",
            "Peter Pan (James Matthew Barrie)",
            "Uçan Sınıf (Erich Kastner)",
            "Yağmur Yağdıran Kedi (Marcel Aymé)",
            "Ölümsüz Aile (Natalie Babbitt)",
            "Yaşlı Adam ve Deniz (Ernest Hemingway)",
            "Mutlu Prens (Oscar Wilde)",
            "Şamatalı Köy (Astrid Lindgren)",
            "Momo (Michael Ende)",
            "Heidi (Johanna Spyri)",
            "İnsan Ne İle Yaşar (Leo Tolstoy)",
            "Sol Ayağım (Christy Brown)",
            "Hikayeler (Anton Çehov)",
            "Değirmenimden Mektuplar (Alphonse Daudet)",
            "Pollyanna (Eleanor Porter)",
            "Uluç Reis (Halikarnas Balıkçısı)",
            "Damla Damla (Ruşen Eşref Ünaydın)",
            "Bağrıyanık Ömer (Mahmut Yesari)",
            "Domaniç Dağlarının Yolcusu (Şükûfe Nihal)",
            "Evvel Zaman İçinde (Eflatun Cem Güney)",
            "Cumhuriyet Öncesi Yazarlardan Çocuklara Hikayeler (Mehmet Seyda)",
            "Gururlu Peri (Mehmet Seyda)",
            "Akın (Faruk Nafiz Çamlıbel)",
            "Havaya Uçan At (Peyami Safa)",
            "Benim Küçük Dostlarım (Halide Nusret Zorlutuna)",
            "Sevdalı Bulut (Nâzım Hikmet)",
            "Kuklacı (Kemalettin Tuğcu)",
            "Yer Altında Bir Şehir (Kemalettin Tuğcu)",
            "Arif Nihat Asya’dan Seçme Şiirler (Arif Nihat Asya)",
            "Sait Faik Abasıyanık’tan Seçme Hikayeler",
            "Koçyiğit Köroğlu (Ahmet Kutsi Tecer)",
            "Az Gittik Uz Gittik (Pertev Naili Boratav)",
            "Aritmetik İyi Kuşlar Pekiyi (Cemal Süreya)",
            "Çocuklara Şiirler (Vehbi Cem Aşkun)",
            "87 Oğuz (Rakım Çalapala)",
            "Yonca Kız (Kemal Bilbaşar)[**çıkarıldı]",
            "Bitmeyen Gece (Mithat Enç)",
            "Halime Kaptan (Rıfat Ilgaz)",
            "Gümüş Kanat (Cahit Uçuk)",
            "Vatan Toprağı (Mükerrem Kamil Su)",
            "Barbaros Hayrettin Geliyor (Feridun Fazıl Tülbentçi)[*çıkarıldı]",
            "Eşref Saati (Şevket Rado)",
            "Nasreddin Hoca Hikayeleri (Orhan Veli)",
            "İnci’nin Maceraları (Orhan Kemal)",
            "Allı ile Fırfırı (Oğuz Tansel)",
            "Tiryaki Sözleri (Cenap Şahabettin)",
            "Keloğlan Masalları (Tahir Alangu)",
            "Billur Köşk Masalları (Tahir Alangu)",
            "Osmancık (Tarık Buğra)",
            "Balım Kız Dalım Oğul (Ceyhun Atuf Kansu)",
            "Falaka (Ahmet Rasim)",
            "Bir Gemi Yelken Açtı (Ali Mümtaz Arolat)",
            "Üç Minik Serçem (Necati Cumalı)",
            "Memleket Şiirleri Antolojisi (Osman Atilla)",
            "Ülkemin Efsaneleri (İbrahim Zeki Burdurlu)",
            "Anılarda Öyküler (İbrahim Zeki Burdurlu) [çıkarıldı]",
            "Aldı Sözü Anadolu (Mehmet Önder)",
            "Göl Çocukları (İbrahim Örs)",
            "Miskinler Tekkesi (Reşat Nuri Güntekin)",
            "Tanrı Misafiri (Reşat Nuri Güntekin)",
            "Ötleğen Kuşu (Halil Karagöz)",
            "Arılar Ordusu (Bekir Yıldız)",
            "Yankılı Kayalar (Yılmaz Boyunağa)",
            "Yürekdede ile Padişah (Cahit Zarifoğlu)",
            "Serçe Kuş (Cahit Zarifoğlu)",
            "Bir Küçük Osmancık Vardı (Hasan Nail Canat)"});
            this.comboBox1.Location = new System.Drawing.Point(192, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(696, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kitap Seçiniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(519, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(422, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kitaplar Maximum 14 Gün Kiralanabilir.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(380, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 1;
            // 
            // Uygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Uygulama";
            this.Text = "HS Kütüphane Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}