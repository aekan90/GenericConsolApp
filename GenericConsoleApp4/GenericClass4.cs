
namespace GenericConsolApp
{

    // Base Class Constraint (Temel Sınıf Kısıtlaması)
    // A-->B-->C  şeklinde bir kalıtım alan yapı kurduk
    // D classı A sınıfından kalıtım almıyor.
    // 

    class GenericClass4
    {
        public static void Main(string[] args)
        {
            MyClass<A> myClass = new MyClass<A>();
            MyClass<B> myClass1 = new MyClass<B>(); // B-->A dan türemiştir 
            MyClass<C> myClass2 = new MyClass<C>(); // C-->A dan türemiştir
            MyClass<D> myClass3 = new MyClass<D>(); // D, A tipinde bir class değildir. HATA ALIRIZ OLAMAZ.
        }

        // MyClass parametre olarak class şartımız
        // referans gelen class tipinin A tipi veya A'dan türeyen sınıf  olmasıdır

        class MyClass<T> where T : class,A,new()
        {
            public void x()
            {
                T T1 = new T();  // T : new ile üretilemeyen bir sınıf olabilir bu yüzden engellenir..
                                 // T : static class olabilir, constructor private içeren bi class olabilir
                                 // Bir interface olabilir yani new() komutu ile intance oluşturulamayan bir class olabilir
                                 // bu nedenle T nin ne olduğu belli olmadığı için new() komutu engellenir
                                 // bunu kaldırmak için 
                                 // class MyClass<T> where T : A, new() // new constraint(kısıtlama)  ile kaldırabiliriz
                                 // new() ifadesi eklenince biz parametre gelen classın new() ile instant oluşturulabilir 
                                 // olduğunu garanti ediyoruz.
            }
        }

        class A
        {

        }
        class B : A
        {

        }
        class C : B
        {

        }
        class D
        {

        }

    }
}