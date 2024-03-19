namespace Inheritance_Example
{
    // Class 3
    public class Bird : Animal
    {
        public Bird(string name) : base(name) { } //Bird classinin constructor i tanimlandi, Animal classinin constructur ina erisildi

        public override void MakeSound() //animal classinda belirtilen MakeSound() metodunu override ediyoruz
        {
            Console.WriteLine($"{Name} is chirping.");
        }
    }


}
