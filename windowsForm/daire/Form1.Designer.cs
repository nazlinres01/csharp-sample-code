namespace WindowsFormsApp4
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
            this.sayi = new System.Windows.Forms.Label();
            this.alan = new System.Windows.Forms.Label();
            this.cevre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sayi
            // 
            this.sayi.AutoSize = true;
            this.sayi.Location = new System.Drawing.Point(347, 69);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(85, 13);
            this.sayi.TabIndex = 0;
            this.sayi.Text = "Dairenin yarıçapı";
            this.sayi.Click += new System.EventHandler(this.sayi_Click);
            // 
            // alan
            // 
            this.alan.AutoSize = true;
            this.alan.Location = new System.Drawing.Point(347, 114);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(81, 13);
            this.alan.TabIndex = 1;
            this.alan.Text = "Dairenin Alanı =";
            this.alan.Click += new System.EventHandler(this.label2_Click);
            // 
            // cevre
            // 
            this.cevre.AutoSize = true;
            this.cevre.Location = new System.Drawing.Point(347, 154);
            this.cevre.Name = "cevre";
            this.cevre.Size = new System.Drawing.Size(93, 13);
            this.cevre.TabIndex = 2;
            this.cevre.Text = "Dairenin Çevresi =";
            this.cevre.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(442, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(442, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(442, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cevre);
            this.Controls.Add(this.alan);
            this.Controls.Add(this.sayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayi;
        private System.Windows.Forms.Label alan;
        private System.Windows.Forms.Label cevre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox label4;
        private System.Windows.Forms.TextBox label5;
    }
}

