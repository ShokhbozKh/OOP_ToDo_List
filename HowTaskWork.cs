using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Project_1_OOP
{
    public class HowTaskWork :Task
    {
        protected  List<HowTaskWork> tasks;
        public HowTaskWork()
        {
            tasks = new List<HowTaskWork>();
        }
        public override void AddTask(HowTaskWork task)
        {
            tasks.Add(task);
        }
        public override void ShowTasks()
        {
            int count = 0;

            foreach (var t in tasks)
            {
                Console.WriteLine($"{++count}. ID {t.Id} Title: {t.Title}, Description: {t.Description}, Price: {t.Price}, IsCompleted: {t.IsCompleted}, DueDate: {t.DueDate}");
            }
        }
        public override void RemoveTask(Guid guid)
        {
            if(guid == Guid.Empty)
            {
                Console.WriteLine("Invalid task ID.");
                return;
            }

            var taskToRemove = tasks.FirstOrDefault(t => t.Id == guid);

            if (taskToRemove == null)
            {
                Console.WriteLine("Task not found.");
                return;
            }
            tasks.Remove(taskToRemove);
            Console.WriteLine($"Task with ID {guid} has been removed.");

        }

        public override void ShowTaskById(int id)
        {
            throw new NotImplementedException();
        }
        public override void UpdateTask(int id, Guid guid)
        {
            var fountToUpdate = tasks.FirstOrDefault(t => t.Id == guid);
            if (fountToUpdate == null)
            {
                Console.WriteLine("Task not found.");
                return;
            }
            Console.WriteLine("Enter new title:");
            string newTitle = Console.ReadLine();
            Console.WriteLine("Enter new description:");
            string newDescription = Console.ReadLine();
            Console.WriteLine("Enter new price:");
            decimal newPrice;
            while (!decimal.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine("Invalid price format. Please enter a valid decimal number:");
            }

            Console.WriteLine("Is the task completed? (true/false)");

            bool newIsCompleted = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter new due date (yyyy-MM-dd):");
            DateTime newDueDate;
            while (!DateTime.TryParse(Console.ReadLine(), out newDueDate))
            {
                Console.WriteLine("Invalid date format. Please enter the date in the format yyyy-MM-dd:");
            }
            fountToUpdate.Title = newTitle;
            fountToUpdate.Description = newDescription;
            fountToUpdate.Price = newPrice;
            fountToUpdate.IsCompleted = newIsCompleted;
            fountToUpdate.DueDate = newDueDate;
            Console.WriteLine($"Task with ID {guid} has been updated.");


        }

    }
}
