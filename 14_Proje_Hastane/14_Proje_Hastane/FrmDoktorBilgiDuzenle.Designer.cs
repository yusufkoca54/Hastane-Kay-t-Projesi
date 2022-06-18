namespace _14_Proje_Hastane
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(151, 91);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(240, 31);
            this.txtsoyad.TabIndex = 41;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(151, 43);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(240, 31);
            this.txtad.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Şifre:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(151, 246);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(240, 31);
            this.txtsifre.TabIndex = 35;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(151, 139);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(240, 31);
            this.mskTc.TabIndex = 34;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "TC Kimlik No:";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(151, 192);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(240, 31);
            this.cmbbrans.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Branş:";
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(151, 299);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(240, 44);
            this.btnBilgiGuncelle.TabIndex = 47;
            this.btnBilgiGuncelle.Text = "Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // DoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(410, 389);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "DoktorBilgiDuzenle";
            this.Text = "DoktorBilgiDuzenle";
            this.Load += new System.EventHandler(this.DoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBilgiGuncelle;
    }
}