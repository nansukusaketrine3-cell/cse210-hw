using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:

                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("> ");

                    string response = Console.ReadLine();

                    Entry entry = new Entry();

                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;

                    journal.AddEntry(entry);

                    Console.WriteLine("Entry added successfully.");

                    break;

                case 2:

                    journal.DisplayAll();

                    break;

                case 3:

                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();

                    journal.SaveToFile(saveFile);

                    break;

                case 4:

                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();

                    journal.LoadFromFile(loadFile);

                    break;

                case 5:

                    Console.WriteLine("Goodbye!");

                    break;

                default:

                    Console.WriteLine("Invalid choice.");

                    break;
            }
        }
    }
}