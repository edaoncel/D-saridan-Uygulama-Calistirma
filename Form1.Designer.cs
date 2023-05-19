namespace dışarıdan_uygulama_çalıştırma
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
            this.txtUygulama = new System.Windows.Forms.TextBox();
            this.btnÇaliştır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUygulama
            // 
            this.txtUygulama.Location = new System.Drawing.Point(48, 61);
            this.txtUygulama.Name = "txtUygulama";
            this.txtUygulama.Size = new System.Drawing.Size(710, 26);
            this.txtUygulama.TabIndex = 0;
            // 
            // btnÇaliştır
            // 
            this.btnÇaliştır.Location = new System.Drawing.Point(646, 127);
            this.btnÇaliştır.Name = "btnÇaliştır";
            this.btnÇaliştır.Size = new System.Drawing.Size(112, 35);
            this.btnÇaliştır.TabIndex = 1;
            this.btnÇaliştır.Text = "çalıştır";
            this.btnÇaliştır.UseVisualStyleBackColor = true;
            this.btnÇaliştır.Click += new System.EventHandler(this.btnÇaliştır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnÇaliştır);
            this.Controls.Add(this.txtUygulama);
            this.Name = "Form1";
            this.Text = "çalıştırmak:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUygulama;
        private System.Windows.Forms.Button btnÇaliştır;
    }
}

