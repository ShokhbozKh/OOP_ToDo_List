using System;

namespace ToDo_Project_1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            HowTaskWork newTask = new HowTaskWork();

            Console.WriteLine("Welcome to the ToDo Application!");
            Console.WriteLine("===========T=A=S=K=S===============");
            int choice = 0;
            while (true)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Show Tasks");
                Console.WriteLine("3. Remove Task");
                Console.WriteLine("4. Update Task");
                Console.WriteLine("5. Show Task By Id");
                Console.WriteLine("0. Exit ToDo");

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 5)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }
                if (choice == 0)
                {
                    Console.WriteLine("Exiting ToDo...");
                    break;
                }
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Adding a new task...");
                        Console.Write("Enter task title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter task price: ");
                        decimal price;
                        while (!decimal.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("Invalid price format. Please enter a valid decimal number:");
                        }
                        Console.Write("Is the task completed? (true/false): ");
                        bool isCompleted;
                        while (!bool.TryParse(Console.ReadLine(), out isCompleted))
                        {
                            Console.WriteLine("Invalid input. Please enter 'true' or 'false':");
                        }
                        Console.Write("Enter task due date (yyyy-mm-dd): ");
                        DateTime dueDate;
                        while (!DateTime.TryParse(Console.ReadLine(), out dueDate))
                        {
                            Console.WriteLine("Invalid date format. Please enter a valid date (yyyy-mm-dd):");
                        }
                        
                        var newTask1 = new HowTaskWork();
                        newTask1.Id = Guid.NewGuid();
                        newTask1.Title = title;
                        newTask1.Description = description;
                        newTask1.Price = price;
                        newTask1.IsCompleted = isCompleted;
                        newTask1.DueDate = dueDate;


                        
                        newTask.AddTask(newTask1);
                        Console.WriteLine("Task added successfully!");
                        Console.WriteLine("====================================");

                        break;
                    case 2:
                        Console.WriteLine("Showing all tasks...");

                        newTask.ShowTasks();
                        Console.WriteLine("====================================");
                        break;
                    case 3:
                        Console.WriteLine("Removing a task...");
                        Console.Write("Enter task ID to remove: ");
                        if (!Guid.TryParse(Console.ReadLine(), out Guid taskId))
                        {
                            Console.WriteLine("Invalid ID format. Please try again.");
                            continue;
                        }
                        HowTaskWork removeTask = new HowTaskWork();
                        removeTask.RemoveTask(taskId);
                        Console.WriteLine("Task removed successfully!");
                        break;
                    case 4:

                        Console.WriteLine("Updating a task...");
                        break;
                    case 5:
                        Console.WriteLine("Showing task by ID...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

            }

            
        }
    }
}