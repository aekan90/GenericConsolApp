using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    // GENERİC CLASSLARDA WHERE KULLANIMI
    class kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    class sonuc<T> where T : class
    {
        public string Mesaj { get; set; }
        public string Basarili { get; set; }
        public T? Data { get; set; }
    }

    class GenericClass_1
    {
        private static void Main(string[] args)
        {
            kisi insan1 = new kisi();
            insan1.Ad = "ATIF";
            insan1.Soyad = "KAN";

            var res = new sonuc<kisi>();
            res.Mesaj = "sonuc mesaj";
            res.Basarili = "sonuc başarılı";
            res.Data = insan1;

            Console.WriteLine(res.Data.Ad);
            Console.WriteLine(res.Data.Soyad);

        }
    }

}