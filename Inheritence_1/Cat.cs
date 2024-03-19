namespace Inheritance_Example
{
    //Class 1
    public class Cat : Animal  //Inheritance
    {
        public Cat(string name) : base(name) { }  //Bird classinin constructor i tanimlandi, Animal classinin constructur ina erisildi
        public override void MakeSound()  //animal classinda belirtilen MakeSound() metodunu override ediyoruz
        {
            Console.WriteLine($"{Name} is meowing.");
        }
    }


}
