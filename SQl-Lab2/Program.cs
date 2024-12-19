using Microsoft.EntityFrameworkCore;
using SQl_Lab2.Models;

namespace SQl_Lab2
{
    class Program
    {
        public static List<BookInfo> inventoryBooks;

        public static List<Butiker> butiker;

        static void Main(string[] args)
        {
            using var dbContext = new Lab1DbContext();

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jones Bokhandel\n");
                Console.ResetColor();
                Console.WriteLine("1. Butiker");
                Console.WriteLine("2. Exit");
                Console.Write("\nVälj ett alternativ: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListStores(dbContext);
                        break;
                    case "2":
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

                Console.WriteLine("\nTryck på Enter för att fortsätta");
                Console.ReadKey();
            }
        }

        static void ListStores(Lab1DbContext dbContext)
        {
            butiker = dbContext.Butikers.ToList();
            Console.Clear();
            Console.WriteLine("Antal Butiker " + butiker.Count);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tillgängliga butiker: \n");
            Console.ResetColor();

            foreach (var butik in butiker)
            {
                Console.WriteLine(butik.ButiksNamn);
            }

            Console.Write("\nVälj en butik: ");
            if (!int.TryParse(Console.ReadLine(), out int storeChoice) || storeChoice < 1 || storeChoice > butiker.Count)
            {
                Console.WriteLine("Ogiltigt val.");
                return;
            }

            var chosenStore = butiker[storeChoice - 1];
            ManageStore(dbContext, chosenStore);
        }

        static void ManageStore(Lab1DbContext dbContext, Butiker store)
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Hantera butik: {store.ButiksNamn}\n");
                Console.ResetColor();
                Console.WriteLine("1. Visa lagersaldo");
                Console.WriteLine("2. Lägg till en bok");
                Console.WriteLine("3. Ta bort en bok");
                Console.WriteLine("4. Gå tillbaka");
                Console.Write("\nVälj ett alternativ: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowInventory(dbContext, store);
                        break;
                    case "2":
                        AddBookToStore(dbContext, store);
                        break;
                    case "3":
                        RemoveBookFromStore(dbContext, store);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

                Console.WriteLine("\nTryck på Enter för att gå tillbaka");
                Console.ReadKey();
            }
        }

        static void ShowInventory(Lab1DbContext dbContext, Butiker store)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Lagersaldo i Sortimentet: {store.ButiksNamn}\n");
            Console.ResetColor();

            inventoryBooks = dbContext.LagerSaldos

                .Include(ls => ls.IsbnNavigation)
                .Include(butik => butik.Butik)

                .Where(lagersaldo => lagersaldo.ButikId == store.ButikId && lagersaldo.Antal > 0)
                .Select(lagersaldo => new BookInfo
                {
                    Titel = lagersaldo.IsbnNavigation.Titel,
                    ISBN = lagersaldo.Isbn,
                    Antal = lagersaldo.Antal,
                    Butiksnamn = store.ButiksNamn
                })
                .ToList();

            if (!inventoryBooks.Any())
            {
                Console.WriteLine("Inga böcker finns i lagersaldo.");
            }
            else
            {
                foreach (var item in inventoryBooks)
                {
                    Console.WriteLine($"Titel: {item.Titel}, ISBN: {item.ISBN}, Antal: {item.Antal}");
                }
            }
        }

        static void AddBookToStore(Lab1DbContext dbContext, Butiker store)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Lägg till bok i butik: {store.ButiksNamn}");
            Console.ResetColor();

            var books = dbContext.Böckers.ToList();

            Console.WriteLine("Tillgängliga böcker i sortimentet:");
            for (int i = 0; i < books.Count; i++)
            {
                var book = books[i];
                Console.WriteLine($"{i + 1}. {book.Titel} (ISBN: {book.Isbn})");
            }

            Console.Write("\nAnge nummer för att välja bok: ");
            if (!int.TryParse(Console.ReadLine(), out int bookChoice) || bookChoice < 1 || bookChoice > books.Count)
            {
                Console.WriteLine("Ogiltigt val.");
                return;
            }

            var chosenBook = books[bookChoice - 1];
            Console.Write("Ange antal att lägga till: ");
            if (!int.TryParse(Console.ReadLine(), out int antal) || antal < 1)
            {
                Console.WriteLine("Ogiltigt antal.");
                return;
            }

            var existingSaldo = dbContext.LagerSaldos.FirstOrDefault(ls => ls.Isbn == chosenBook.Isbn && ls.ButikId == store.ButikId);
            if (existingSaldo != null)
            {
                existingSaldo.Antal += antal;
            }
            else
            {
                dbContext.LagerSaldos.Add(new LagerSaldo
                {
                    ButikId = store.ButikId,
                    Isbn = chosenBook.Isbn,
                    Antal = antal
                });
            }

            dbContext.SaveChanges();
            Console.WriteLine($"\n{antal} böcker har lagts till i lagersaldo.");
        }

        static void RemoveBookFromStore(Lab1DbContext dbContext, Butiker store)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ta bort bok/böcker från butik: {store.ButiksNamn}");
            Console.ResetColor();

            var inventory = dbContext.LagerSaldos
                .Where(ls => ls.ButikId == store.ButikId)
                .Include(book => book.IsbnNavigation)
                .ToList();

            if (!inventory.Any())
            {
                Console.WriteLine("Finns inga böcker att ta bort.");
                return;
            }

            Console.WriteLine("Böcker i lagersaldo: ");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i].IsbnNavigation.Titel} (ISBN: {inventory[i].Isbn}), Antal: {inventory[i].Antal}");
            }

            Console.Write("\nVälj en bok genom att ange nummer: ");
            if (!int.TryParse(Console.ReadLine(), out int bookChoice) || bookChoice < 1 || bookChoice > inventory.Count)
            {
                Console.WriteLine("Ogiltigt val. Ange ett korrekt nummer.");
                return;
            }

            var chosenSaldo = inventory[bookChoice - 1];

            Console.Write($"Hur många böcker vill du ta bort? (Max: {chosenSaldo.Antal}): ");
            if (!int.TryParse(Console.ReadLine(), out int antal) || antal < 1 || antal > chosenSaldo.Antal)
            {
                Console.WriteLine("Ogiltigt antal. Försök igen.");
                return;
            }

            if (antal == chosenSaldo.Antal)
            {
                dbContext.LagerSaldos.Remove(chosenSaldo);
            }
            else
            {
                chosenSaldo.Antal -= antal;
            }

            dbContext.SaveChanges();
            Console.WriteLine($"\n{antal} böcker har tagits bort från lagersaldo.");
        }
    }
}
