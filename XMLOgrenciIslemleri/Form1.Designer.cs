
namespace Ornek3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSinif = new System.Windows.Forms.ComboBox();
            this.buttontamsol = new System.Windows.Forms.Button();
            this.buttonsol = new System.Windows.Forms.Button();
            this.buttontamsag = new System.Windows.Forms.Button();
            this.buttonsag = new System.Windows.Forms.Button();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.listBoxASinifi = new System.Windows.Forms.ListBox();
            this.listBoxBSinifi = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLileDisaAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLileiceriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSecmeliDersler = new System.Windows.Forms.CheckBox();
            this.groupBoxSecmeliDers = new System.Windows.Forms.GroupBox();
            this.checkedListSecmeliDersler = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxSecmeliDers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(189, 37);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(39, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(338, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(250, 27);
            this.textBoxAd.TabIndex = 0;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(338, 107);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(250, 27);
            this.textBoxSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "D Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınıf Seçimi : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBoxSinif
            // 
            this.comboBoxSinif.FormattingEnabled = true;
            this.comboBoxSinif.Location = new System.Drawing.Point(338, 243);
            this.comboBoxSinif.Name = "comboBoxSinif";
            this.comboBoxSinif.Size = new System.Drawing.Size(250, 28);
            this.comboBoxSinif.TabIndex = 7;
            this.comboBoxSinif.Text = "Sınıfınızı Seçiniz...";
            // 
            // buttontamsol
            // 
            this.buttontamsol.Location = new System.Drawing.Point(480, 622);
            this.buttontamsol.Name = "buttontamsol";
            this.buttontamsol.Size = new System.Drawing.Size(111, 39);
            this.buttontamsol.TabIndex = 8;
            this.buttontamsol.Text = "<<";
            this.buttontamsol.UseVisualStyleBackColor = true;
            this.buttontamsol.Click += new System.EventHandler(this.buttontamsol_Click);
            // 
            // buttonsol
            // 
            this.buttonsol.Location = new System.Drawing.Point(480, 567);
            this.buttonsol.Name = "buttonsol";
            this.buttonsol.Size = new System.Drawing.Size(111, 39);
            this.buttonsol.TabIndex = 9;
            this.buttonsol.Text = "<";
            this.buttonsol.UseVisualStyleBackColor = true;
            this.buttonsol.Click += new System.EventHandler(this.buttonsol_Click);
            // 
            // buttontamsag
            // 
            this.buttontamsag.Location = new System.Drawing.Point(480, 509);
            this.buttontamsag.Name = "buttontamsag";
            this.buttontamsag.Size = new System.Drawing.Size(111, 39);
            this.buttontamsag.TabIndex = 10;
            this.buttontamsag.Text = ">>";
            this.buttontamsag.UseVisualStyleBackColor = true;
            this.buttontamsag.Click += new System.EventHandler(this.buttontamsag_Click);
            // 
            // buttonsag
            // 
            this.buttonsag.Location = new System.Drawing.Point(480, 445);
            this.buttonsag.Name = "buttonsag";
            this.buttonsag.Size = new System.Drawing.Size(111, 39);
            this.buttonsag.TabIndex = 11;
            this.buttonsag.Text = ">";
            this.buttonsag.UseVisualStyleBackColor = true;
            this.buttonsag.Click += new System.EventHandler(this.buttonsag_Click);
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(716, 39);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(156, 232);
            this.buttonOgrenciEkle.TabIndex = 12;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // listBoxASinifi
            // 
            this.listBoxASinifi.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxASinifi.FormattingEnabled = true;
            this.listBoxASinifi.ItemHeight = 20;
            this.listBoxASinifi.Location = new System.Drawing.Point(22, 437);
            this.listBoxASinifi.Name = "listBoxASinifi";
            this.listBoxASinifi.Size = new System.Drawing.Size(372, 224);
            this.listBoxASinifi.TabIndex = 15;
            // 
            // listBoxBSinifi
            // 
            this.listBoxBSinifi.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxBSinifi.FormattingEnabled = true;
            this.listBoxBSinifi.ItemHeight = 20;
            this.listBoxBSinifi.Location = new System.Drawing.Point(674, 437);
            this.listBoxBSinifi.Name = "listBoxBSinifi";
            this.listBoxBSinifi.Size = new System.Drawing.Size(378, 224);
            this.listBoxBSinifi.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1525, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLileDisaAktarToolStripMenuItem,
            this.xMLileiceriToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // xMLileDisaAktarToolStripMenuItem
            // 
            this.xMLileDisaAktarToolStripMenuItem.Name = "xMLileDisaAktarToolStripMenuItem";
            this.xMLileDisaAktarToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.xMLileDisaAktarToolStripMenuItem.Text = "XML ile dışarı aktar";
            this.xMLileDisaAktarToolStripMenuItem.Click += new System.EventHandler(this.xMLileDisaAktarToolStripMenuItem_Click);
            // 
            // xMLileiceriToolStripMenuItem
            // 
            this.xMLileiceriToolStripMenuItem.Name = "xMLileiceriToolStripMenuItem";
            this.xMLileiceriToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.xMLileiceriToolStripMenuItem.Text = "XML ile içeri veri al";
            this.xMLileiceriToolStripMenuItem.Click += new System.EventHandler(this.xMLileiceriToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSecmeliDersler);
            this.groupBox1.Controls.Add(this.buttonOgrenciEkle);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBoxSinif);
            this.groupBox1.Location = new System.Drawing.Point(49, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 354);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // checkBoxSecmeliDersler
            // 
            this.checkBoxSecmeliDersler.AutoSize = true;
            this.checkBoxSecmeliDersler.Location = new System.Drawing.Point(252, 302);
            this.checkBoxSecmeliDersler.Name = "checkBoxSecmeliDersler";
            this.checkBoxSecmeliDersler.Size = new System.Drawing.Size(276, 24);
            this.checkBoxSecmeliDersler.TabIndex = 0;
            this.checkBoxSecmeliDersler.Text = "Seçmeli ders almak istiyor musunuz ?";
            this.checkBoxSecmeliDersler.UseVisualStyleBackColor = true;
            this.checkBoxSecmeliDersler.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxSecmeliDers
            // 
            this.groupBoxSecmeliDers.Controls.Add(this.checkedListSecmeliDersler);
            this.groupBoxSecmeliDers.Location = new System.Drawing.Point(1036, 62);
            this.groupBoxSecmeliDers.Name = "groupBoxSecmeliDers";
            this.groupBoxSecmeliDers.Size = new System.Drawing.Size(477, 354);
            this.groupBoxSecmeliDers.TabIndex = 19;
            this.groupBoxSecmeliDers.TabStop = false;
            this.groupBoxSecmeliDers.Text = "Seçmeli Dersler";
            // 
            // checkedListSecmeliDersler
            // 
            this.checkedListSecmeliDersler.FormattingEnabled = true;
            this.checkedListSecmeliDersler.Items.AddRange(new object[] {
            "İnsan kaynakları",
            "Toplum Hizmeti",
            "İtalyanca",
            "Halk Sağlığı",
            "EvrimTeorisi"});
            this.checkedListSecmeliDersler.Location = new System.Drawing.Point(59, 58);
            this.checkedListSecmeliDersler.Name = "checkedListSecmeliDersler";
            this.checkedListSecmeliDersler.Size = new System.Drawing.Size(346, 268);
            this.checkedListSecmeliDersler.TabIndex = 13;
            this.checkedListSecmeliDersler.SelectedIndexChanged += new System.EventHandler(this.checkedListSecmeliDersler_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 685);
            this.Controls.Add(this.groupBoxSecmeliDers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxBSinifi);
            this.Controls.Add(this.listBoxASinifi);
            this.Controls.Add(this.buttonsag);
            this.Controls.Add(this.buttontamsag);
            this.Controls.Add(this.buttonsol);
            this.Controls.Add(this.buttontamsol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxSecmeliDers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxSinif;
        private System.Windows.Forms.Button buttontamsol;
        private System.Windows.Forms.Button buttonsol;
        private System.Windows.Forms.Button buttontamsag;
        private System.Windows.Forms.Button buttonsag;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.ListBox listBoxASinifi;
        private System.Windows.Forms.ListBox listBoxBSinifi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSecmeliDersler;
        private System.Windows.Forms.GroupBox groupBoxSecmeliDers;
        private System.Windows.Forms.CheckedListBox checkedListSecmeliDersler;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLileDisaAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLileiceriToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

