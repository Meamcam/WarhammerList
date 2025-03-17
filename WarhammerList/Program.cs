using System;
using System.Collections.Generic;

namespace WarhammerCollections
{
    class Program
    {
        static void Main()
        {
            int choice = Menu();
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        UseQueue();
                        break;
                    case 2:
                        UseStack();
                        break;
                    case 3:
                        UseLinkedList();
                        break;
                    case 4:
                        UseDictionary();
                        break;
                    case 5:
                        UseHashSet();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                choice = Menu();
            }
        }

        static int Menu()
        {
            Console.WriteLine("Warhammer 40K Army Collections");
            Console.WriteLine("1. Queue");
            Console.WriteLine("2. Stack");
            Console.WriteLine("3. LinkedList");
            Console.WriteLine("4. Dictionary");
            Console.WriteLine("5. HashSet");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");
            return int.TryParse(Console.ReadLine(), out int input) ? input : 0;
        }

        static void UseQueue()
        {
            Queue<string> factions = new Queue<string>(new[] { "Space Marines", "Orks", "Eldar", "Necrons", "Tyranids" });
            Console.WriteLine("Queue contains 'Eldar': " + factions.Contains("Eldar"));
            factions.Dequeue();
            Console.WriteLine("Queue count after dequeue: " + factions.Count);
            Console.WriteLine("Queue contents:");
            foreach (var faction in factions) Console.WriteLine(faction);
            Console.ReadKey(); Console.Clear();
        }

        static void UseStack()
        {
            Stack<string> factions = new Stack<string>(new[] { "Adeptus Mechanicus", "Tau Empire", "Dark Eldar", "Chaos Space Marines", "Imperial Guard" });
            Console.WriteLine("Stack contains 'Tau Empire': " + factions.Contains("Tau Empire"));
            factions.Pop();
            Console.WriteLine("Stack count after pop: " + factions.Count);
            Console.WriteLine("Stack contents:");
            foreach (var faction in factions) Console.WriteLine(faction);
            Console.ReadKey(); Console.Clear();
        }

        static void UseLinkedList()
        {
            LinkedList<string> factions = new LinkedList<string>(new[] { "Sisters of Battle", "Death Guard", "Harlequins", "Thousand Sons", "Grey Knights" });
            Console.WriteLine("First Node: " + factions.First.Value);
            Console.WriteLine("Last Node: " + factions.Last.Value);
            factions.AddAfter(factions.Find("Harlequins"), "Genestealer Cults");
            factions.Remove("Death Guard");
            Console.WriteLine("LinkedList count after removal: " + factions.Count);
            Console.WriteLine("LinkedList contents:");
            foreach (var faction in factions) Console.WriteLine(faction);
            Console.ReadKey(); Console.Clear();
        }

        static void UseDictionary()
        {
            Dictionary<int, string> factions = new Dictionary<int, string>
            {
                {1, "Black Templars"}, {2, "Blood Angels"}, {3, "Dark Angels"}, {4, "Ultramarines"}, {5, "White Scars"}
            };
            Console.WriteLine("Dictionary Keys: " + string.Join(", ", factions.Keys));
            Console.WriteLine("Dictionary Values: " + string.Join(", ", factions.Values));
            foreach (var kvp in factions) Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            factions.Remove(3);
            Console.WriteLine("Dictionary count after removal: " + factions.Count);
            Console.ReadKey(); Console.Clear();
        }

        static void UseHashSet()
        {
            HashSet<string> set1 = new HashSet<string> { "Alpha Legion", "Iron Warriors", "Night Lords", "Word Bearers", "World Eaters" };
            HashSet<string> set2 = new HashSet<string> { "Emperor's Children", "Death Guard", "Thousand Sons", "Black Legion", "Alpha Legion" };
            HashSet<string> set3 = new HashSet<string> { "Dark Angels", "Space Wolves", "Blood Angels", "Alpha Legion", "Iron Warriors" };

            set1.UnionWith(set2);
            set1.UnionWith(set3);

            Console.WriteLine("Combined HashSet contents:");
            foreach (var faction in set1) Console.WriteLine(faction);
            Console.ReadKey(); Console.Clear();
        }
    }
}
