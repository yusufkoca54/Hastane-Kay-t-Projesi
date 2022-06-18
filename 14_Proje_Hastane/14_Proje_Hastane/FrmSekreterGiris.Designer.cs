namespace _14_Proje_Hastane
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.BtnGirisYao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGirisYao
            // 
            this.BtnGirisYao.Location = new System.Drawing.Point(162, 275);
            this.BtnGirisYao.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGirisYao.Name = "BtnGirisYao";
            this.BtnGirisYao.Size = new System.Drawing.Size(243, 56);
            this.BtnGirisYao.TabIndex = 19;
            this.BtnGirisYao.Text = "Giriş Yap";
            this.BtnGirisYao.UseVisualStyleBackColor = true;
            this.BtnGirisYao.Click += new System.EventHandler(this.BtnGirisYao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(162, 203);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(243, 31);
            this.txtsifre.TabIndex = 17;
            this.txtsifre.Text = "6666";
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(162, 128);
            this.mskTc.Margin = new System.Windows.Forms.Padding(5);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(243, 31);
            this.mskTc.TabIndex = 16;
            this.mskTc.Text = "66666666666";
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 53);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.BtnGirisYao;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(464, 386);
            this.Controls.Add(this.BtnGirisYao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.Text = "Sekreter Girisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGirisYao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}