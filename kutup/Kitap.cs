using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutup
{
    public class Kitap
    {
        public string Adi { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
        public int Isbn { get; set; }
        public bool Kullanilabilir { get; set; }
        public Kitap(string adi, string yazar, string tur, int isbn)
        {
            Adi = adi;
            Yazar = yazar;
            Tur = tur;
            Isbn = isbn;
            Kullanilabilir = false;
        }
        public override string ToString()
        {
            return $"{Adi} by {Yazar}";
        }
    }
    public class kitapNode
    {
        public Kitap veri { get; set; }
        public kitapNode sonraki { get; set; }
        public kitapNode(Kitap kitap)
        {
            veri = kitap;
            sonraki = null;
        }
    }
    public class kitapbaglilist
    {
        private kitapNode head;

        public void Ekle(Kitap kitap)
        {
            kitapNode yeniNode = new kitapNode(kitap);
            if (head == null)
            {
                head = yeniNode;
            }
            else
            {
                kitapNode current = head;
                while (current.sonraki != null)
                {
                    current = current.sonraki;
                }
                current.sonraki = yeniNode;
            }
        }



    }
}
