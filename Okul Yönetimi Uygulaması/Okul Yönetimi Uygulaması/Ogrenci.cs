using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimiUygulamasi
{
    //uygulamamıza bir ögrencinin özelliklerini tutacak class ile başlıyoruz.
    class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public DateTime DogumTarihi;
        public CINSIYET Cinsiyet;  //cinsiyet özelliğini kendine özel bir veri tipi yapmak içi enum yapısını kullanıyoruz.
        public SUBE Sube;     //sube özelliğini kendine özel bir veri tipi yapmak içi enum yapısını kullanıyoruz.
        public string Aciklama;
        public Adres Adresi;
        public List<string> Kitaplar;
        public List<DersNotu> Notlar = new List<DersNotu>();
        public double Ortalama
        {
            get
            {
                double ort = this.Notlar.Sum(a => a.Not);

                if (ort == 0)
                {
                    return 0;
                }
                else
                {
                    return ort / this.Notlar.Count;
                }

            }
        }

        public int KitapSayisi
        {
            get
            {
                return this.Kitaplar == null ? 0 : this.Kitaplar.Count;
            }
        }


        public void AdresEkle(string il, string ilce, string mahalle)  
        {
            if (this.Adresi == null)
            {
                this.Adresi = new Adres();
            }
            this.Adresi.Il = il;
            this.Adresi.Ilce = ilce;
            this.Adresi.Mahalle = mahalle;
        }


        public void KitapEkle(string kitap)
        {
            if (this.Kitaplar == null)
            {
                this.Kitaplar = new List<string>();
            }
            this.Kitaplar.Add(kitap);
        }
    }
    public enum SUBE
    {
        Empty, A, B, C
    }
    public enum CINSIYET
    {
        Empty,
        Kiz,
        Erkek
    }
}
