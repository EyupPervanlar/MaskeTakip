using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Degiskenler();
           Vatandas vatandas=new Vatandas();
        }
        
        private static void Degiskenler()
        {
            string Mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string Soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;
        }

        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set;}
                public string DogumYili { get; set;}
            public int tcNo { get; set;}

        }
    }
}
