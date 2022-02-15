using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConsolApp
{       // Default Costructor'u olan bir class olması için kural belirleme

    class GenericClass_3
    {
        static void Main(String[] args)
        {
            var management = new PersonManagement<Person>();
            var adam = management.GetInstance();

            // açıklamada hata var tam böyle değil öğrenilip açıklama düzeltilecek...
            //normalde Person clasının GetIstance() adında bir costructor'ı yok
            // biz PersonelManagement classımız ile default costructer'ı olmayan PErson classına 
            // GetInstance costructerını eklemiş olduk. 
            // Bu class (PersonelManagement<TSample>) kendisine gönderilen classlara default Costructer eklemesi yaparak
            // GetInstance() metodu ile geriye Default Costructer eklenmiş örnek döndürür

            Person adam1 = new Person();
            // adam1.GetInstance();

            var yeniPerson=new PersonManagement<Person>();
            yeniPerson.GetInstance()

        }
    }

    public class Person
    {
        public string Name { get; set; } = "Atıf Ertuğrul KAN";
    }

    class PersonManagement<TSample> where TSample : class, new()
    {
        public TSample GetInstance() // instance:örnek
        {
            return new TSample();
        }
    }

}
