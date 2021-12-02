using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ornek3
{
    public partial class Form1 : Form
    {

        List<string> SiniflarListesi = new List<string>() { "A Sınıfı", "B Sınıfı" };
        List<Ogrenci> ASinifiOgrencileri = new List<Ogrenci>();
        List<Ogrenci> BSinifiOgrencileri = new List<Ogrenci>();
        List<string> SecilenSecmeliDersler = new List<string>();

        public Form1()
        {
            InitializeComponent();
            foreach (var item in SiniflarListesi)
            {
                comboBoxSinif.Items.Add(item);
            }
            textBoxAd.TabIndex = 0;
            textBoxSoyad.TabIndex = 1;
            dateTimePicker1.TabIndex = 2;
            comboBoxSinif.TabIndex = 3;
            buttonOgrenciEkle.TabIndex = 4;
            listBoxASinifi.TabIndex = 5;
            listBoxBSinifi.TabIndex = 6;

            this.BackColor = Color.CornflowerBlue;
            this.Text = "Öğrenci İşlemleri";

            groupBoxSecmeliDers.Enabled = false;

            //CheckOnClick tıkladığım an listedeki checkbox'ı tiklesin.
            checkedListSecmeliDersler.CheckOnClick = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            // Öğrenci ekleyeceğiz.
            if (string.IsNullOrEmpty(textBoxAd.Text) || string.IsNullOrEmpty(textBoxSoyad.Text))
            {
                MessageBox.Show("Lütfen Ad Soyad giriniz.");
            }
            else
            {
                Ogrenci ogr1 = new Ogrenci()
                {

                    Ad = textBoxAd.Text,
                    Soyad = textBoxSoyad.Text,
                    DTarihi = dateTimePicker1.Value
                };

                if (AsinifindanAyniOgrenciVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci A sınıfına zaten kayıt olmuş");
                }
                else if (BsinifindanAyniOgrenciVarMi(ogr1))
                {
                    MessageBox.Show("Bu öğrenci B sınıfına zaten kayıt olmuş");
                }

                // indexler sıfırdan başladığı için >= 0 olmalıdır.
                else if (comboBoxSinif.SelectedIndex >= 0)
                {
                    //öğrencinin sınıfı comBoxtan gelen seçili değer olacak.
                    ogr1.Sinifi = comboBoxSinif.SelectedItem.ToString();
                    switch (comboBoxSinif.SelectedIndex)
                    {
                        case 0:
                            if (AsinifindanAyniOgrenciVarMi(ogr1) == false)
                            {
                                ASinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case 1:            // B sınıfıdır.
                            if (BsinifindanAyniOgrenciVarMi(ogr1) == false)
                            {
                                BSinifiOgrencileri.Add(ogr1);
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci sistemde zaten bulunuyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        default:
                            break;
                    }

                    //Ogrenci seçmeli ders alıyorsa listesine dersleri eklesin
                    ogr1.SecmeliDersAliyorMu = checkBoxSecmeliDersler.Checked;
                    if (ogr1.SecmeliDersAliyorMu)
                    {
                        ogr1.AldigiSecmeliDersler.AddRange(SecilenSecmeliDersler);
                    }

                    KontrolleriTemizle();
                    ListeleriDoldur();
                }
                else
                {
                    MessageBox.Show("Lütfen sınıf seçiniz.");
                }
            }
        }

        private bool AsinifindanAyniOgrenciVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in ASinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        private bool BsinifindanAyniOgrenciVarMi(Ogrenci ogrenci)
        {
            bool sonuc = false;
            foreach (var item in BSinifiOgrencileri)
            {
                if (item.Ad == ogrenci.Ad && item.Soyad == ogrenci.Soyad && item.DTarihi.ToShortDateString() == ogrenci.DTarihi.ToShortDateString())
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }

        private void KontrolleriTemizle()
        {
            textBoxAd.Text = "";
            textBoxSoyad.Text = string.Empty;
            comboBoxSinif.SelectedIndex = -1;
            comboBoxSinif.Text = "Sınıfınızı seçiniz...";
            dateTimePicker1.Value = DateTime.Now;
            //CheckedList içinde checklenmiş yani tik atılmış olan derslere unchecked yapmalıyız.
            foreach (int item in checkedListSecmeliDersler.CheckedIndices)
            {
                checkedListSecmeliDersler.SetItemCheckState(item, CheckState.Unchecked);
            }

            //checkBoxSecmeliDersler unchecked olsun.
            checkBoxSecmeliDersler.Checked = false;

            //Checked olan dersleri tuttuğumuz dersleri temizlemeliyiz.
            SecilenSecmeliDersler.Clear();

        }

        private void ListeleriDoldur()
        {
            listBoxASinifi.Items.Clear();
            listBoxASinifi.BackColor = Color.AliceBlue;
            listBoxASinifi.Items.AddRange(ASinifiOgrencileri.ToArray());


            listBoxBSinifi.Items.Clear();
            listBoxBSinifi.BackColor = Color.Azure;
            listBoxBSinifi.Items.AddRange(BSinifiOgrencileri.ToArray());
        }

        private void buttontamsag_Click(object sender, EventArgs e)
        {
            foreach (var item in ASinifiOgrencileri)
            {
                item.Sinifi = "B Sınıfı";
            }
            BSinifiOgrencileri.AddRange(ASinifiOgrencileri.ToArray());
            ASinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void buttonsag_Click(object sender, EventArgs e)
        {
            // Kim seçili
            Ogrenci transferEdilecekOgrenci = (Ogrenci)listBoxASinifi.SelectedItem;
            //Ogrenci transferEdilecekOgrenci = listBoxASinifi.SelectedItem as Ogrenci;
            if (transferEdilecekOgrenci!=null)
            {
                ASinifiOgrencileri.Remove(transferEdilecekOgrenci);
                transferEdilecekOgrenci.Sinifi = "B Sınıfı";
                BSinifiOgrencileri.Add(transferEdilecekOgrenci);
                ListeleriDoldur();
            }
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecmeliDersler.Checked)
            {
                groupBoxSecmeliDers.Enabled = true;
            }
            else
            {
                groupBoxSecmeliDers.Enabled = false ;
            }
        }

        private void checkedListSecmeliDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenSecmeliDersler.Clear();
            foreach (var item in checkedListSecmeliDersler.CheckedItems)
            {
                //Eğer SecilenSecmeliDersler listesinde bu ders varsa bir daha eklememesi için koşul yazacağız.
                //Ckeckeditems' ın foreach döngüsündeki var item ile bize sunduğu değişken object tipte geliyor.
                //SecilenSecmeliDersler listemiz string tipte bir listedir. Bu nedenle item.ToString() yaptık.

                if (SecilenSecmeliDersler.Count(x => x==item.ToString()) == 0)
                {
                    SecilenSecmeliDersler.Add(item.ToString());
                }
            }
        }

        private void buttonsol_Click(object sender, EventArgs e)
        {
            Ogrenci transferEdilecekOgrenci = (Ogrenci)listBoxBSinifi.SelectedItem;

            if (transferEdilecekOgrenci != null)
            {
                BSinifiOgrencileri.Remove(transferEdilecekOgrenci);
                transferEdilecekOgrenci.Sinifi = "A Sınıfı";
                ASinifiOgrencileri.Add(transferEdilecekOgrenci);
                ListeleriDoldur();
            }
        }

        private void buttontamsol_Click(object sender, EventArgs e)
        {
            foreach (var item in BSinifiOgrencileri)
            {
                item.Sinifi = "A Sınıfı";
            }
            ASinifiOgrencileri.AddRange(BSinifiOgrencileri.ToArray());
            BSinifiOgrencileri.Clear();
            ListeleriDoldur();
        }

        private void xMLileDisaAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ogrenci> DisariAktarilacaklar = new List<Ogrenci>();
            // A sınıfında öğrenci varsa
            if (ASinifiOgrencileri.Count>0)
            {
                DisariAktarilacaklar.AddRange(ASinifiOgrencileri);
            }
            //B sınıfında öğrenci varsa
            if (BSinifiOgrencileri.Count>0)
            {
                DisariAktarilacaklar.AddRange(BSinifiOgrencileri);
            }
            //Oluşacak xml dosyasını nereye kaydedeceği ile ilgili DİYALOG nesnesine ihtiyaç var.
            //xml'i serialize edecek işlemler

            saveFileDialog1.Title = "Öğrenci XML Dosyası Kaydet";
            saveFileDialog1.Filter = "XML Formatı | *.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Açılan diyalog penceresinde tamam/ok tuşuna basarsa xml dosyasını oluşturabiliriz.
                //xml'i serialize edecek işlemler
                XmlSerializer myXmlSerializer = new XmlSerializer(typeof(List<Ogrenci>));

                using (TextWriter yazar = new StreamWriter(saveFileDialog1.FileName))
                {
                    myXmlSerializer.Serialize(yazar, DisariAktarilacaklar);
                }
                MessageBox.Show($"{DisariAktarilacaklar.Count} adet öğrenci xml dosyası olarak aktarıldı.");
            }
        }

        private void xMLileiceriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pc de olan xml dosyasını açmanıza yardımcı olacak DİYALOG nesnesine ihtiyaç var.
            KontrolleriTemizle();
            openFileDialog1.Title = "XML Dosyanızı Seçiniz";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Ogrenci>));
                // Var olan dosyayı okumak için okuyucuya ihtiyaç olur.
                using (StreamReader okuyucu = new StreamReader(openFileDialog1.FileName))    
                {
                    ASinifiOgrencileri = xmlSerializer.Deserialize(okuyucu) as List<Ogrenci>;
                    MessageBox.Show($"{ASinifiOgrencileri.Count} adet kişi içeri aktarıldı.");
                    ListeleriDoldur();
                }
            }
        }
    }
}
