using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConsolApp
{       // GENERİC CLASSLARDA BİRDEN FAZLA WHERE KULLANIMI

    class GenericClass_2
    {
        static void Main(String[] args)
        {
            var res = new Sonuc<Kisi, bool, string>();
            Kisi Adam = new Kisi();
            Adam.Ad = "Atıf";
            Adam.Soyad = "Kan";

            res.Mesaj = true;
            res.Basarili = "Başarılı";
            res.Data = Adam;

            Console.WriteLine(res.Data.Ad);
            Console.WriteLine(res.Data.Soyad);
            Console.WriteLine(res.Mesaj);
            Console.WriteLine(res.Basarili);
        }
    }

    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    class Sonuc<TData, TBasarili, TMesaj> where TData : class
    {
        public TBasarili Mesaj { get; set; }
        public TMesaj Basarili { get; set; }
        public TData Data { get; set; }
    }
}
