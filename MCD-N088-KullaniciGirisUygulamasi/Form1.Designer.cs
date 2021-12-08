
namespace MCD_N088_KullaniciGirisUygulamasi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifresi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kulanıcı şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(346, 141);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(157, 32);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Enter += new System.EventHandler(this.txtKullaniciAdi_Enter);
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // txtKullaniciSifresi
            // 
            this.txtKullaniciSifresi.Location = new System.Drawing.Point(346, 192);
            this.txtKullaniciSifresi.Name = "txtKullaniciSifresi";
            this.txtKullaniciSifresi.PasswordChar = '*';
            this.txtKullaniciSifresi.Size = new System.Drawing.Size(157, 32);
            this.txtKullaniciSifresi.TabIndex = 3;
            this.txtKullaniciSifresi.Enter += new System.EventHandler(this.txtKullaniciSifresi_Enter);
            this.txtKullaniciSifresi.Leave += new System.EventHandler(this.txtKullaniciSifresi_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKullaniciSifresi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciSifresi;
        private System.Windows.Forms.Button button1;
    }
}

