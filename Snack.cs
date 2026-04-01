
namespace OOP_Projekt
{
    // Representerar snacks (ärver från Product)
    public class Snack : Product
    {
        public Snack(string name, int price) : base(name, price) { }

        // Beskriver hur snackset används
        public override string Use()
        {
            return "You eat the " + Name;
        }
    }
}
