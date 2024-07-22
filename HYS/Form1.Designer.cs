namespace HYS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratuvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturalarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÖdemeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniİlaçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçStoklarınıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemYedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDoktorEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPersonelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniTestEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSonuçlarınıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(925, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastalarToolStripMenuItem,
            this.doktorlarToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.laboratuvarToolStripMenuItem,
            this.muhasebeToolStripMenuItem,
            this.ilaçlarToolStripMenuItem,
            this.reçeToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastalarToolStripMenuItem
            // 
            this.hastalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHastaEkleToolStripMenuItem,
            this.hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem,
            this.randevuYönetimiToolStripMenuItem});
            this.hastalarToolStripMenuItem.Name = "hastalarToolStripMenuItem";
            this.hastalarToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.hastalarToolStripMenuItem.Text = "Hastalar";
            // 
            // doktorlarToolStripMenuItem
            // 
            this.doktorlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniDoktorEkleToolStripMenuItem,
            this.dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem,
            this.randevuListeleToolStripMenuItem});
            this.doktorlarToolStripMenuItem.Name = "doktorlarToolStripMenuItem";
            this.doktorlarToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.doktorlarToolStripMenuItem.Text = "Doktorlar";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniPersonelEkleToolStripMenuItem,
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // laboratuvarToolStripMenuItem
            // 
            this.laboratuvarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniTestEkleToolStripMenuItem,
            this.testSonuçlarınıGörüntüleToolStripMenuItem});
            this.laboratuvarToolStripMenuItem.Name = "laboratuvarToolStripMenuItem";
            this.laboratuvarToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.laboratuvarToolStripMenuItem.Text = "Laboratuvar";
            // 
            // muhasebeToolStripMenuItem
            // 
            this.muhasebeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFaturaOluşturToolStripMenuItem,
            this.faturalarıGörüntüleToolStripMenuItem,
            this.yeniÖdemeEkleToolStripMenuItem});
            this.muhasebeToolStripMenuItem.Name = "muhasebeToolStripMenuItem";
            this.muhasebeToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.muhasebeToolStripMenuItem.Text = "Muhasebe";
            // 
            // ilaçlarToolStripMenuItem
            // 
            this.ilaçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİlaçEkleToolStripMenuItem,
            this.ilaçStoklarınıGörüntüleToolStripMenuItem});
            this.ilaçlarToolStripMenuItem.Name = "ilaçlarToolStripMenuItem";
            this.ilaçlarToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.ilaçlarToolStripMenuItem.Text = "İlaçlar";
            // 
            // reçeToolStripMenuItem
            // 
            this.reçeToolStripMenuItem.Name = "reçeToolStripMenuItem";
            this.reçeToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.reçeToolStripMenuItem.Text = "Raporlar";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıYönetimiToolStripMenuItem,
            this.sistemYedeklemeToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // yeniFaturaOluşturToolStripMenuItem
            // 
            this.yeniFaturaOluşturToolStripMenuItem.Name = "yeniFaturaOluşturToolStripMenuItem";
            this.yeniFaturaOluşturToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.yeniFaturaOluşturToolStripMenuItem.Text = "Yeni Fatura Oluştur";
            // 
            // faturalarıGörüntüleToolStripMenuItem
            // 
            this.faturalarıGörüntüleToolStripMenuItem.Name = "faturalarıGörüntüleToolStripMenuItem";
            this.faturalarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.faturalarıGörüntüleToolStripMenuItem.Text = "Faturaları Görüntüle";
            // 
            // yeniÖdemeEkleToolStripMenuItem
            // 
            this.yeniÖdemeEkleToolStripMenuItem.Name = "yeniÖdemeEkleToolStripMenuItem";
            this.yeniÖdemeEkleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.yeniÖdemeEkleToolStripMenuItem.Text = "Yeni Ödeme Ekle";
            // 
            // yeniİlaçEkleToolStripMenuItem
            // 
            this.yeniİlaçEkleToolStripMenuItem.Name = "yeniİlaçEkleToolStripMenuItem";
            this.yeniİlaçEkleToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.yeniİlaçEkleToolStripMenuItem.Text = "Yeni İlaç Ekle";
            // 
            // ilaçStoklarınıGörüntüleToolStripMenuItem
            // 
            this.ilaçStoklarınıGörüntüleToolStripMenuItem.Name = "ilaçStoklarınıGörüntüleToolStripMenuItem";
            this.ilaçStoklarınıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.ilaçStoklarınıGörüntüleToolStripMenuItem.Text = "İlaç Stoklarını Görüntüle";
            // 
            // kullanıcıYönetimiToolStripMenuItem
            // 
            this.kullanıcıYönetimiToolStripMenuItem.Name = "kullanıcıYönetimiToolStripMenuItem";
            this.kullanıcıYönetimiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kullanıcıYönetimiToolStripMenuItem.Text = "Kullanıcı Yönetimi";
            // 
            // sistemYedeklemeToolStripMenuItem
            // 
            this.sistemYedeklemeToolStripMenuItem.Name = "sistemYedeklemeToolStripMenuItem";
            this.sistemYedeklemeToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sistemYedeklemeToolStripMenuItem.Text = "Sistem Yedekleme";
            // 
            // yeniHastaEkleToolStripMenuItem
            // 
            this.yeniHastaEkleToolStripMenuItem.Name = "yeniHastaEkleToolStripMenuItem";
            this.yeniHastaEkleToolStripMenuItem.Size = new System.Drawing.Size(391, 34);
            this.yeniHastaEkleToolStripMenuItem.Text = "Yeni Hasta Ekle";
            // 
            // hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem
            // 
            this.hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem.Name = "hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem";
            this.hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem.Size = new System.Drawing.Size(391, 34);
            this.hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem.Text = "Hasta Bİlgilerini Görüntüle/Güncelle";
            // 
            // randevuYönetimiToolStripMenuItem
            // 
            this.randevuYönetimiToolStripMenuItem.Name = "randevuYönetimiToolStripMenuItem";
            this.randevuYönetimiToolStripMenuItem.Size = new System.Drawing.Size(391, 34);
            this.randevuYönetimiToolStripMenuItem.Text = "Randevu Yönetimi";
            // 
            // yeniDoktorEkleToolStripMenuItem
            // 
            this.yeniDoktorEkleToolStripMenuItem.Name = "yeniDoktorEkleToolStripMenuItem";
            this.yeniDoktorEkleToolStripMenuItem.Size = new System.Drawing.Size(404, 34);
            this.yeniDoktorEkleToolStripMenuItem.Text = "Yeni Doktor Ekle";
            // 
            // dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem
            // 
            this.dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem.Name = "dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem";
            this.dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem.Size = new System.Drawing.Size(401, 34);
            this.dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem.Text = "Doktor Bilgilerini Görüntüle/Güncelle";
            // 
            // randevuListeleToolStripMenuItem
            // 
            this.randevuListeleToolStripMenuItem.Name = "randevuListeleToolStripMenuItem";
            this.randevuListeleToolStripMenuItem.Size = new System.Drawing.Size(404, 34);
            this.randevuListeleToolStripMenuItem.Text = "Randevu Listele";
            // 
            // yeniPersonelEkleToolStripMenuItem
            // 
            this.yeniPersonelEkleToolStripMenuItem.Name = "yeniPersonelEkleToolStripMenuItem";
            this.yeniPersonelEkleToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.yeniPersonelEkleToolStripMenuItem.Text = "Yeni Personel ekle";
            // 
            // personelBilgileriniGörüntüleGüncelleToolStripMenuItem
            // 
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem.Name = "personelBilgileriniGörüntüleGüncelleToolStripMenuItem";
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.personelBilgileriniGörüntüleGüncelleToolStripMenuItem.Text = "Personel Bilgilerini Görüntüle/Güncelle";
            // 
            // yeniTestEkleToolStripMenuItem
            // 
            this.yeniTestEkleToolStripMenuItem.Name = "yeniTestEkleToolStripMenuItem";
            this.yeniTestEkleToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.yeniTestEkleToolStripMenuItem.Text = "Yeni Test Ekle";
            // 
            // testSonuçlarınıGörüntüleToolStripMenuItem
            // 
            this.testSonuçlarınıGörüntüleToolStripMenuItem.Name = "testSonuçlarınıGörüntüleToolStripMenuItem";
            this.testSonuçlarınıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.testSonuçlarınıGörüntüleToolStripMenuItem.Text = "Test Sonuçlarını Görüntüle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 530);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratuvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muhasebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaBİlgileriniGörüntüleGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniDoktorEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOktorBilgileriniGörüntüleGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturalarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÖdemeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniİlaçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçStoklarınıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemYedeklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelBilgileriniGörüntüleGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniTestEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSonuçlarınıGörüntüleToolStripMenuItem;
    }
}

