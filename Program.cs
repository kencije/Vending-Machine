namespace OOP_Projekt
{
    using System;

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

                switch (choice)
                {
                    case 1:
                        int money;
                        if (int.TryParse(Console.ReadLine(), out money))
                            vm.InsertMoney(money);
                        break;

                    case 2:
                        vm.ShowProducts();
                        break;

                    case 3:
                        int productChoice;
                        if (int.TryParse(Console.ReadLine(), out productChoice))
                            vm.Purchase(productChoice);
                        break;

                    case 4:
                        vm.EndTransaction();
                        break;

                    case 5:
                        vm.EndTransaction();
                        running = false;
                        break;
                }
            }
        }
    }
}