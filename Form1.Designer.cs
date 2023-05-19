namespace yas_hesaplama
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
            this.txtDogumtarihi = new System.Windows.Forms.TextBox();
            this.lblDogumtarihi = new System.Windows.Forms.Label();
            this.btnYashesaplayıcı = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDogumtarihi
            // 
            this.txtDogumtarihi.Location = new System.Drawing.Point(324, 90);
            this.txtDogumtarihi.Name = "txtDogumtarihi";
            this.txtDogumtarihi.Size = new System.Drawing.Size(137, 26);
            this.txtDogumtarihi.TabIndex = 0;
            // 
            // lblDogumtarihi
            // 
            this.lblDogumtarihi.AutoSize = true;
            this.lblDogumtarihi.Location = new System.Drawing.Point(139, 96);
            this.lblDogumtarihi.Name = "lblDogumtarihi";
            this.lblDogumtarihi.Size = new System.Drawing.Size(96, 20);
            this.lblDogumtarihi.TabIndex = 1;
            this.lblDogumtarihi.Text = "dogum tarihi";
            this.lblDogumtarihi.Click += new System.EventHandler(this.lblDogumtarihi_Click);
            // 
            // btnYashesaplayıcı
            // 
            this.btnYashesaplayıcı.Location = new System.Drawing.Point(324, 172);
            this.btnYashesaplayıcı.Name = "btnYashesaplayıcı";
            this.btnYashesaplayıcı.Size = new System.Drawing.Size(137, 38);
            this.btnYashesaplayıcı.TabIndex = 2;
            this.btnYashesaplayıcı.Text = "yas hesaplayıcı";
            this.btnYashesaplayıcı.UseVisualStyleBackColor = true;
            this.btnYashesaplayıcı.Click += new System.EventHandler(this.btnYashesaplayıcı_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYashesaplayıcı);
            this.Controls.Add(this.lblDogumtarihi);
            this.Controls.Add(this.txtDogumtarihi);
            this.Name = "Form1";
            this.Text = "yas hesaplayıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDogumtarihi;
        private System.Windows.Forms.Label lblDogumtarihi;
        private System.Windows.Forms.Button btnYashesaplayıcı;
    }
}

