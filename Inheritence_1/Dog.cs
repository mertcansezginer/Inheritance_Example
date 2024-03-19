namespace Inheritance_Example
{
    // Class 2
    public class Dog : Animal  //Inheritance
    {
        public Dog(string name) : base(name) { }  //Dog classinin constructor i tanimlandi, Animal classinin constructur ina erisildi

        public override void MakeSound() //animal classinda belirtilen MakeSound() metodunu override ediyoruz
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }


}
