
namespace MCD_N088_KullaniciGirisUygulamasi
{
    partial class AnaForm
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
            this.lblselamla = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.lblsoyisim = new System.Windows.Forms.Label();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.lblaciklama = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtSoyİism = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblselamla
            // 
            this.lblselamla.AutoSize = true;
            this.lblselamla.Location = new System.Drawing.Point(720, 472);
            this.lblselamla.Name = "lblselamla";
            this.lblselamla.Size = new System.Drawing.Size(0, 24);
            this.lblselamla.TabIndex = 0;
            this.lblselamla.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(141, 203);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(50, 24);
            this.lblisim.TabIndex = 1;
            this.lblisim.Text = "İsim:";
            this.lblisim.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsoyisim
            // 
            this.lblsoyisim.AutoSize = true;
            this.lblsoyisim.Location = new System.Drawing.Point(105, 253);
            this.lblsoyisim.Name = "lblsoyisim";
            this.lblsoyisim.Size = new System.Drawing.Size(86, 24);
            this.lblsoyisim.TabIndex = 2;
            this.lblsoyisim.Text = "Soy isim:";
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(74, 301);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(117, 24);
            this.lblkullaniciadi.TabIndex = 3;
            this.lblkullaniciadi.Text = "Kullanici adi:";
            this.lblkullaniciadi.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(125, 356);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(54, 24);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "Sifre:";
            // 
            // lblaciklama
            // 
            this.lblaciklama.AutoSize = true;
            this.lblaciklama.Location = new System.Drawing.Point(92, 404);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(94, 24);
            this.lblaciklama.TabIndex = 5;
            this.lblaciklama.Text = "Aciklama:";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(224, 195);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(172, 32);
            this.txtİsim.TabIndex = 7;
            // 
            // txtSoyİism
            // 
            this.txtSoyİism.Location = new System.Drawing.Point(224, 245);
            this.txtSoyİism.Name = "txtSoyİism";
            this.txtSoyİism.Size = new System.Drawing.Size(172, 32);
            this.txtSoyİism.TabIndex = 8;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(224, 301);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(172, 32);
            this.txtKullaniciAdi.TabIndex = 9;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(224, 356);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(172, 32);
            this.txtSifre.TabIndex = 10;
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(224, 404);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(172, 32);
            this.txtaciklama.TabIndex = 11;
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(171, 462);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(172, 45);
            this.btngüncelle.TabIndex = 12;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 691);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSoyİism);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.lblsoyisim);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.lblselamla);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnaForm";
            this.Text = "Aktif Kullanıcı Bilgisi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblselamla;
        private System.Windows.Forms.Label lblisim;
        private System.Windows.Forms.Label lblsoyisim;
        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Label lblaciklama;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtSoyİism;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Button btngüncelle;
    }
}