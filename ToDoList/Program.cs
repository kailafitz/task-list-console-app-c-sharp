// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the To Do List App!");

List<string> taskList = new List<string>();
string option = "";

while(option != "e") {
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("a - Add a task");
    Console.WriteLine("r - Remove task");
    Console.WriteLine("v - View tasks");
    Console.WriteLine("e - Exit");

    option = Console.ReadLine() ?? "";

    if (option == "a")
    {
        Console.WriteLine("Enter a task:");
        string task = Console.ReadLine();
        taskList.Add(task);
    }
    else if (option == "r")
    {
        Console.WriteLine("Enter the task number to remove:");
        int taskNumber = Convert.ToInt32(Console.ReadLine());
        taskList.RemoveAt(taskNumber);
    }
    else if (option == "v")
    {
        Console.WriteLine("Tasks:");
        for (int i = 0; i < taskList.Count; i++)
        {
            Console.WriteLine($"{i}: {taskList[i]}");
        }
    }
    else if (option == "e")
    {
        Console.WriteLine("Exiting program!");
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }

    Console.WriteLine("Thank you for using the To Do List App!");
}