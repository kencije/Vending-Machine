
namespace OOP_Projekt
{
    using System;
    using System.Collections.Generic;

    using System;
    using System.Collections.Generic;

    // Hanterar produkter, pengar och köp
    public class VendingMachine
    {
        public List<Product> Products = new List<Product>();
        public int MoneyPool = 0;

        // Skapar automaten och lägger in produkter
        public VendingMachine()
        {
            Products.Add(new Drink("Cola", 25));
            Products.Add(new Drink("Fanta", 25));
            Products.Add(new Drink("Water", 15));
            Products.Add(new Snack("Chips", 20));
            Products.Add(new Snack("Chocolate", 20));
            Products.Add(new Toy("Toy Car", 50));
            Products.Add(new Toy("Robot", 45));
        }

        // Tar emot pengar (endast giltiga valörer)
        public void InsertMoney(int amount)
        {
            if (amount == 5 || amount == 10 || amount == 20 || amount == 50)
            {
                MoneyPool += amount;
                Console.WriteLine("Balance: " + MoneyPool + " kr");
            }
            else
            {
                Console.WriteLine("Invalid money!");
            }
        }

        // Visar alla produkter i listan
        public void ShowProducts()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + Products[i].Examine());
            }
        }

        // Köper en produkt med pengar från MoneyPool
        public void Purchase(int choice)
        {
            if (choice < 1 || choice > Products.Count)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }

            Product p = Products[choice - 1];

            if (MoneyPool >= p.Price)
            {
                MoneyPool -= p.Price;
                Console.WriteLine(p.Use());
                Console.WriteLine("Remaining: " + MoneyPool + " kr");
            }
            else
            {
                Console.WriteLine("Not enough money!");
            }
        }

        // Avslutar köpet och returnerar kvarvarande pengar
        public void EndTransaction()
        {
            Console.WriteLine("Returning: " + MoneyPool + " kr");
            MoneyPool = 0;
        }
    }
}
