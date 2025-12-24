using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutup
{
    public partial class KitapEkleme : Form
    {
        kitapbaglilist kitapListesi = new kitapbaglilist();
        public KitapEkleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButonKitapEkle_Click(object sender, EventArgs e)
        {
            string ad = textKitapAd.Text;
            string yazar = textKitapYazar.Text;
            string tur = textKitapTur.Text;
            int isbn = textKitapIsbn.Text != "" ? int.Parse(textKitapIsbn.Text) : 0;

            Kitap yeniKitap = new Kitap(ad, yazar, tur, isbn);
            kitapListesi.Ekle(yeniKitap);

        }
    }
}
