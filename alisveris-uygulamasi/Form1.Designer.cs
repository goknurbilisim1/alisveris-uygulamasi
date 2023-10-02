namespace alisveris_uygulamasi
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
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BirimFiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(130, 108);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(146, 24);
            this.lblToplamTutar.TabIndex = 2;
            this.lblToplamTutar.Text = "Toplam Tutar: ";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(134, 25);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(113, 29);
            this.txtBirimFiyat.TabIndex = 3;
            // 
            // txtAdet
            // 
            this.txtAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.Location = new System.Drawing.Point(134, 60);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(113, 29);
            this.txtAdet.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(281, 25);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(139, 48);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla:";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(485, 219);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnHesapla;
    }
}

