namespace OOP_Projekt
{

    using System;

    // Startpunkt för programmet och menyhantering
    class Program
    {
        static void Main()
        {
            VendingMachine vm = new VendingMachine();
            bool running = true;

            // Loop som visar meny tills användaren avslutar
            while (running)
            {
                Console.Clear();

                Console.WriteLine("\n1. Insert Money");
                Console.WriteLine("2. Show Products");
                Console.WriteLine("3. Buy Product");
                Console.WriteLine("4. End Transaction");
                Console.WriteLine("5. Exit");

                string input = Console.ReadLine();
                int choice;

                // Säker inläsning av menyval
                if (!int.TryParse(input, out choice))
                    continue;

                // Från knap 1-5
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Mata in hur mycket pengar du vill lägga in (5, 10, 20, 50):");
                        int money;
                        if (int.TryParse(Console.ReadLine(), out money))
                            vm.InsertMoney(money);
                        else
                            Console.WriteLine("Felaktig inmatning!");
                            Console.ReadKey();
                        break;

                    case 2:
                        vm.ShowProducts();
                        Console.ReadKey();
                        break;

                    case 3:
                        vm.ShowProducts();
                        Console.WriteLine("Välj produkt genom att ange numret:");
                        int productChoice;
                        if (int.TryParse(Console.ReadLine(), out productChoice))
                            vm.Purchase(productChoice);
                        else
                            Console.WriteLine("Felaktigt val!");
                            Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Avslutar köp och returnerar pengar...");
                        vm.EndTransaction();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Avslutar programmet...");
                        vm.EndTransaction();
                        running = false;
                        Console.ReadKey();
                        break;
      
                }
            }
        }
    }
}
