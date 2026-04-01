
namespace OOP_Projekt
{
    // Representerar drycker (ärver från Product)
    public class Drink : Product
    {
        public Drink(string name, int price) : base(name, price) { }

        // Beskriver hur drycken används
        public override string Use()
        {
            return "You drink the " + Name;
        }
    }
}
