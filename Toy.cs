
namespace OOP_Projekt
{
    // Representerar leksaker (ärver från Product)
    public class Toy : Product
    {
        public Toy(string name, int price) : base(name, price) { }

        // Beskriver hur leksaken används
        public override string Use()
        {
            return "You play with the " + Name;
        }
    }
}
