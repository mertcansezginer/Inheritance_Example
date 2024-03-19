namespace Inheritance_Example
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Lokum");               //Cat classinda Lokum adinda bir nesne olusturduk,
            Animal dog = new Dog("Paşa");                //ve bunu Animal tipinde cat adında bir değişkene atadık.
            Animal bird = new Bird("Cicikus");                     //Cat sinifi Animal sınıfından türemiştir, Animal tipindeki bir değişken
                                                                   //Cat türündeki bir nesneyi tutabilir, bu da Polymorphism oluyor.
            cat.MakeSound(); // Output: Lokum is meowing.
            dog.MakeSound(); // Output: Paşa is barking.
            bird.MakeSound(); // Output: Cicikus is chirping.
        }
    }


}
