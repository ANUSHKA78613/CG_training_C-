class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
class Dog : Animal
{
        public override void Speak()
    {
        Console.WriteLine("The dog barks");
    }
}