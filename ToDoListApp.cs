using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        
        static void PrintTasksToFile(List<string> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("\nYour task list is empty. Nothing to print.\n");
                return;
            }

            string fileName = $"todo_list_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            List<string> output = new();
            output.Add("TO DO LIST");
            output.Add("==========");
            output.Add("");

            for (int i = 0; i < tasks.Count; i++)
            {
                output.Add($"{i + 1}. {tasks[i]}");
            }

            File.WriteAllLines(fileName, output);
            Console.WriteLine($"\nSaved your tasks to: {Path.GetFullPath(fileName)}\n");
        }

        Console.WriteLine(" _____ ___    ____   ___     _     ___ ____ _____ ");
        Console.WriteLine("|_   _/ _ \\  |  _ \\ / _ \\   | |   |_ _/ ___|_   _|");
        Console.WriteLine("  | || | | | | | | | | | |  | |    | |\\___ \\ | |  ");
        Console.WriteLine("  | || |_| | | |_| | |_| |  | |___ | | ___) || |  ");
        Console.WriteLine("  |_| \\___/  |____/ \\___/   |_____|___|____/ |_|  ");
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------");

        List<string> tasks = new();

        Console.WriteLine("Welcome to the to do list application");
        Console.WriteLine("Enter tasks below. Type 'info' to see more commands.\n");

        int counter = 1;

        while (true)
        {
            Console.Write($"Please enter task {counter}: ");
            string? textValue = Console.ReadLine();

            
            if (string.IsNullOrWhiteSpace(textValue))
                continue;

            string command = textValue.Trim().ToLower();

            if (command == "info")
            {
                Console.WriteLine("\nAvailable Commands");
                Console.WriteLine("------------------");
                Console.WriteLine("stop     - Stops the application");
                Console.WriteLine("print    - Prints your current To Do List into a txt file");
                Console.WriteLine("backend  - Shows the more technical information about this application\n");
                continue;
            }
            else if (command == "stop")
            {
                break;
            }
            else if (command == "print")
            {
                PrintTasksToFile(tasks);
                continue;
            }
            else if (command == "backend")
            {
                Console.WriteLine("\nBackend Information");
                Console.WriteLine("-------------------");
                Console.WriteLine("This application uses a simple in-memory backend to manage your tasks.");
                Console.WriteLine();
                Console.WriteLine("How it works:");
                Console.WriteLine("1. Tasks are stored in a List<string> during runtime.");
                Console.WriteLine("2. Each time you enter a task, it is appended to the list.");
                Console.WriteLine("3. The 'print' command exports the list into a .txt file on your computer.");
                Console.WriteLine("4. The 'stop' command ends the program and displays your final task list.");
                Console.WriteLine();
                Console.WriteLine("Important Notes:");
                Console.WriteLine("- Your tasks are not permanently saved unless you use 'print'.");
                Console.WriteLine("- When the program closes, the task list is cleared from memory.");
                Console.WriteLine();
                continue;
            }


            
            tasks.Add(textValue);
            counter++;
        }

        Console.WriteLine("\nYour final task list:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
