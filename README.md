📝 C# Console To-Do List Application
Overview

This is a simple C# console-based To-Do List application that allows users to enter tasks interactively and view a final list once they are finished.

The application runs entirely in the terminal and is designed to practice:

Loops and conditionals

Lists (List<string>)

Console input/output

Basic program flow control

Features

➕ Add unlimited tasks

🛑 Stop input by typing stop

📋 Displays a numbered list of all entered tasks

💡 Simple and beginner-friendly logic

Requirements

.NET SDK (any modern version, e.g. .NET 6+)

A terminal or IDE that supports C# console applications
(Visual Studio, VS Code, Rider, etc.)

How to Run

Save the code in a file, for example:

Program.cs


Run using the .NET CLI:

dotnet run


Or run directly from your IDE.

How It Works

The program welcomes the user and explains how to stop input.

Tasks are entered one by one.

Typing stop ends task entry.

The program prints the final task list with numbering.

Example Session
Welcome to your to do list
Enter tasks below will be added to the finale task folder if you ever wish to stop type 'stop' to stop the program

Please enter task: 1 : Buy groceries
Please enter task: 2 : Finish homework
Please enter task: 3 : stop

Your final task list:
1. Buy groceries
2. Finish homework
