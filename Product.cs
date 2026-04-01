
namespace OOP_Projekt
{
    // Basklass för alla produkter i automaten
    public class Product
    {
        public string Name;
        public int Price;

        // Konstruktor som sätter namn och pris
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        // Visar information om produkten
        public virtual string Examine()
        {
            return Name + " costs " + Price + " kr";
        }

        // Standard användning (överskrivs i subklasser)
        public virtual string Use()
        {
            return "Using product";
        }
    }
}
