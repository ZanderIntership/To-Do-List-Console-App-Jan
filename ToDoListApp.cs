using System;


List<string> tasks = new();

Console.WriteLine("Welcome to your to do list");

Console.WriteLine("Enter tasks below will be added to the finale task folder if you ever wish to stop type 'stop' to stop the program\n\n");
Boolean Stopping = false;

int Counter = 1;

while (Stopping == false)
{

    Console.Write($"Please enter task: {Counter} : ");
    string textValue = Console.ReadLine();


    if (textValue != "stop")
    {
        tasks.Add(textValue);
    }
    else
    {
        Stopping = true;
    }

    Counter += 1;

}


Console.WriteLine("\nYour final task list:");
for (int i = 0; i < tasks.Count; i++)
{
    Console.WriteLine($"{i + 1}. {tasks[i]}");
}
