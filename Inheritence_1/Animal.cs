namespace Inheritance_Example
{
    public class Animal   //Base class olusturduk
    {
        public string Name { get; set; } 
        public Animal(string name)  //constructur method
        {
            Name = name;
            Console.WriteLine($"{Name} has been created."); // Name + "has been created." seklinde de yazilabilir.
        }

        public virtual void MakeSound() //MakeSound metodunu belirttik, virtual olmasına dikkat ettik
        {
            Console.WriteLine($"{Name} is making a sound.");
        }
    }


}
