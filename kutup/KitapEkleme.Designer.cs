namespace kutup
{
    partial class KitapEkleme
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
            this.label3 = new System.Windows.Forms.Label();
            this.textKitapAd = new System.Windows.Forms.TextBox();
            this.textKitapTur = new System.Windows.Forms.TextBox();
            this.textKitapYazar = new System.Windows.Forms.TextBox();
            this.ButonKitapEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textKitapIsbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tür";
            // 
            // textKitapAd
            // 
            this.textKitapAd.Location = new System.Drawing.Point(173, 55);
            this.textKitapAd.Name = "textKitapAd";
            this.textKitapAd.Size = new System.Drawing.Size(100, 22);
            this.textKitapAd.TabIndex = 3;
            // 
            // textKitapTur
            // 
            this.textKitapTur.Location = new System.Drawing.Point(173, 131);
            this.textKitapTur.Name = "textKitapTur";
            this.textKitapTur.Size = new System.Drawing.Size(100, 22);
            this.textKitapTur.TabIndex = 4;
            // 
            // textKitapYazar
            // 
            this.textKitapYazar.Location = new System.Drawing.Point(173, 93);
            this.textKitapYazar.Name = "textKitapYazar";
            this.textKitapYazar.Size = new System.Drawing.Size(100, 22);
            this.textKitapYazar.TabIndex = 5;
            // 
            // ButonKitapEkle
            // 
            this.ButonKitapEkle.Location = new System.Drawing.Point(91, 198);
            this.ButonKitapEkle.Name = "ButonKitapEkle";
            this.ButonKitapEkle.Size = new System.Drawing.Size(75, 41);
            this.ButonKitapEkle.TabIndex = 6;
            this.ButonKitapEkle.Text = "Ekle";
            this.ButonKitapEkle.UseVisualStyleBackColor = true;
            this.ButonKitapEkle.Click += new System.EventHandler(this.ButonKitapEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textKitapIsbn
            // 
            this.textKitapIsbn.Location = new System.Drawing.Point(173, 169);
            this.textKitapIsbn.Name = "textKitapIsbn";
            this.textKitapIsbn.Size = new System.Drawing.Size(100, 22);
            this.textKitapIsbn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ISBN";
            // 
            // KitapEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 277);
            this.Controls.Add(this.textKitapIsbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButonKitapEkle);
            this.Controls.Add(this.textKitapYazar);
            this.Controls.Add(this.textKitapTur);
            this.Controls.Add(this.textKitapAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapEkleme";
            this.Text = "KitapEkleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKitapAd;
        private System.Windows.Forms.TextBox textKitapTur;
        private System.Windows.Forms.TextBox textKitapYazar;
        private System.Windows.Forms.Button ButonKitapEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textKitapIsbn;
        private System.Windows.Forms.Label label4;
    }
}