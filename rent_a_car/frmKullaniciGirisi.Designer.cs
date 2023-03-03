namespace rent_a_car
{
    partial class frmKullaniciGirisi
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
            this.btn_GİRİS = new System.Windows.Forms.Button();
            this.txt_PAROLA = new System.Windows.Forms.TextBox();
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Kayit_Ol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_GİRİS
            // 
            this.btn_GİRİS.Location = new System.Drawing.Point(208, 234);
            this.btn_GİRİS.Name = "btn_GİRİS";
            this.btn_GİRİS.Size = new System.Drawing.Size(200, 72);
            this.btn_GİRİS.TabIndex = 0;
            this.btn_GİRİS.Text = "GİRİŞ";
            this.btn_GİRİS.UseVisualStyleBackColor = true;
            this.btn_GİRİS.Click += new System.EventHandler(this.btn_GİRİS_Click);
            // 
            // txt_PAROLA
            // 
            this.txt_PAROLA.Location = new System.Drawing.Point(138, 173);
            this.txt_PAROLA.Multiline = true;
            this.txt_PAROLA.Name = "txt_PAROLA";
            this.txt_PAROLA.Size = new System.Drawing.Size(346, 43);
            this.txt_PAROLA.TabIndex = 1;
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(138, 73);
            this.txt_TC.Multiline = true;
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(346, 43);
            this.txt_TC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAROLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC";
            // 
            // lbl_Kayit_Ol
            // 
            this.lbl_Kayit_Ol.AutoSize = true;
            this.lbl_Kayit_Ol.Location = new System.Drawing.Point(283, 323);
            this.lbl_Kayit_Ol.Name = "lbl_Kayit_Ol";
            this.lbl_Kayit_Ol.Size = new System.Drawing.Size(49, 16);
            this.lbl_Kayit_Ol.TabIndex = 3;
            this.lbl_Kayit_Ol.TabStop = true;
            this.lbl_Kayit_Ol.Text = "KayıtOl";
            this.lbl_Kayit_Ol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Kayit_Ol_LinkClicked);
            // 
            // frmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 406);
            this.Controls.Add(this.lbl_Kayit_Ol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TC);
            this.Controls.Add(this.txt_PAROLA);
            this.Controls.Add(this.btn_GİRİS);
            this.Name = "frmKullaniciGirisi";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GİRİS;
        private System.Windows.Forms.TextBox txt_PAROLA;
        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lbl_Kayit_Ol;
    }
}

