﻿namespace TelefonRehberi.WFUI
{
    partial class txt_web_site
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_liste = new System.Windows.Forms.ListBox();
            this.grpbox_kayit = new System.Windows.Forms.GroupBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_yeni_kayit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_webSite = new System.Windows.Forms.TextBox();
            this.txt_email_adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_telefonIII = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefonII = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_telefonI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_data_alver_durum = new System.Windows.Forms.Label();
            this.btn_json_ver = new System.Windows.Forms.Button();
            this.btn_csv = new System.Windows.Forms.Button();
            this.btn_xml_ver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpbox_kayit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_liste);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 557);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rehber Liste";
            // 
            // lst_liste
            // 
            this.lst_liste.FormattingEnabled = true;
            this.lst_liste.Location = new System.Drawing.Point(7, 29);
            this.lst_liste.Name = "lst_liste";
            this.lst_liste.Size = new System.Drawing.Size(187, 511);
            this.lst_liste.TabIndex = 0;
            this.lst_liste.DoubleClick += new System.EventHandler(this.lst_liste_DoubleClick);
            // 
            // grpbox_kayit
            // 
            this.grpbox_kayit.Controls.Add(this.btn_sil);
            this.grpbox_kayit.Controls.Add(this.btn_guncelle);
            this.grpbox_kayit.Controls.Add(this.btn_yeni_kayit);
            this.grpbox_kayit.Controls.Add(this.tabControl1);
            this.grpbox_kayit.Location = new System.Drawing.Point(233, 12);
            this.grpbox_kayit.Name = "grpbox_kayit";
            this.grpbox_kayit.Size = new System.Drawing.Size(719, 391);
            this.grpbox_kayit.TabIndex = 1;
            this.grpbox_kayit.TabStop = false;
            this.grpbox_kayit.Text = "Yeni Rehber Kaydı";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(375, 320);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(334, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(10, 321);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(341, 23);
            this.btn_guncelle.TabIndex = 1;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_yeni_kayit
            // 
            this.btn_yeni_kayit.Location = new System.Drawing.Point(10, 292);
            this.btn_yeni_kayit.Name = "btn_yeni_kayit";
            this.btn_yeni_kayit.Size = new System.Drawing.Size(699, 23);
            this.btn_yeni_kayit.TabIndex = 1;
            this.btn_yeni_kayit.Text = "Yeni Kayıt";
            this.btn_yeni_kayit.UseVisualStyleBackColor = true;
            this.btn_yeni_kayit.Click += new System.EventHandler(this.btn_yeni_kayit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 257);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_adres);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_webSite);
            this.tabPage1.Controls.Add(this.txt_email_adres);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_telefonIII);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_telefonII);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_telefonI);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_soyisim);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_isim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kişisel Bilgiler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(365, 59);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(328, 124);
            this.txt_adres.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Web Site";
            // 
            // txt_webSite
            // 
            this.txt_webSite.Location = new System.Drawing.Point(115, 189);
            this.txt_webSite.Name = "txt_webSite";
            this.txt_webSite.Size = new System.Drawing.Size(226, 20);
            this.txt_webSite.TabIndex = 1;
            // 
            // txt_email_adres
            // 
            this.txt_email_adres.Location = new System.Drawing.Point(115, 163);
            this.txt_email_adres.Name = "txt_email_adres";
            this.txt_email_adres.Size = new System.Drawing.Size(226, 20);
            this.txt_email_adres.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adres";
            // 
            // txt_telefonIII
            // 
            this.txt_telefonIII.Location = new System.Drawing.Point(115, 137);
            this.txt_telefonIII.Name = "txt_telefonIII";
            this.txt_telefonIII.Size = new System.Drawing.Size(226, 20);
            this.txt_telefonIII.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TelefonIII";
            // 
            // txt_telefonII
            // 
            this.txt_telefonII.Location = new System.Drawing.Point(115, 111);
            this.txt_telefonII.Name = "txt_telefonII";
            this.txt_telefonII.Size = new System.Drawing.Size(226, 20);
            this.txt_telefonII.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TelefonII";
            // 
            // txt_telefonI
            // 
            this.txt_telefonI.Location = new System.Drawing.Point(115, 85);
            this.txt_telefonI.Name = "txt_telefonI";
            this.txt_telefonI.Size = new System.Drawing.Size(226, 20);
            this.txt_telefonI.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "TelefonI";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(115, 59);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(226, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(115, 33);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(226, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_aciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Açıklama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(7, 16);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(686, 183);
            this.txt_aciklama.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_data_alver_durum);
            this.groupBox3.Controls.Add(this.btn_json_ver);
            this.groupBox3.Controls.Add(this.btn_csv);
            this.groupBox3.Controls.Add(this.btn_xml_ver);
            this.groupBox3.Location = new System.Drawing.Point(233, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 159);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data AL/VER";
            // 
            // lbl_data_alver_durum
            // 
            this.lbl_data_alver_durum.AutoSize = true;
            this.lbl_data_alver_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_data_alver_durum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_data_alver_durum.Location = new System.Drawing.Point(254, 70);
            this.lbl_data_alver_durum.Name = "lbl_data_alver_durum";
            this.lbl_data_alver_durum.Size = new System.Drawing.Size(97, 13);
            this.lbl_data_alver_durum.TabIndex = 1;
            this.lbl_data_alver_durum.Text = "Durum :Beklemede";
            // 
            // btn_json_ver
            // 
            this.btn_json_ver.Location = new System.Drawing.Point(172, 45);
            this.btn_json_ver.Name = "btn_json_ver";
            this.btn_json_ver.Size = new System.Drawing.Size(75, 62);
            this.btn_json_ver.TabIndex = 0;
            this.btn_json_ver.Text = "JSON VER";
            this.btn_json_ver.UseVisualStyleBackColor = true;
            this.btn_json_ver.Click += new System.EventHandler(this.btn_json_ver_Click);
            // 
            // btn_csv
            // 
            this.btn_csv.Location = new System.Drawing.Point(91, 45);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(75, 62);
            this.btn_csv.TabIndex = 0;
            this.btn_csv.Text = "CSV VER";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            // 
            // btn_xml_ver
            // 
            this.btn_xml_ver.Location = new System.Drawing.Point(10, 45);
            this.btn_xml_ver.Name = "btn_xml_ver";
            this.btn_xml_ver.Size = new System.Drawing.Size(75, 62);
            this.btn_xml_ver.TabIndex = 0;
            this.btn_xml_ver.Text = "XML VER";
            this.btn_xml_ver.UseVisualStyleBackColor = true;
            this.btn_xml_ver.Click += new System.EventHandler(this.btn_xml_ver_Click);
            // 
            // txt_web_site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 590);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpbox_kayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "txt_web_site";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.txt_web_site_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpbox_kayit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbox_kayit;
        private System.Windows.Forms.Button btn_yeni_kayit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email_adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_telefonIII;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_telefonII;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_telefonI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.TextBox txt_webSite;
        private System.Windows.Forms.ListBox lst_liste;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_data_alver_durum;
        private System.Windows.Forms.Button btn_json_ver;
        private System.Windows.Forms.Button btn_csv;
        private System.Windows.Forms.Button btn_xml_ver;
        private System.Windows.Forms.Button btn_sil;
    }
}