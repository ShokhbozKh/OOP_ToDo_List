using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Project_1_OOP
{
    public abstract class Task : ITask
    {
        public Guid Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }

        public Task()
        { }
        public Task( int guid, string title, string description, decimal price, bool isCompleted, DateTime dateTime)
        {
            Id = Guid.NewGuid(); //=> new Guid(guid);
            Title = title;
            Description = description;
            Price = price;
            IsCompleted = isCompleted;
            DueDate = dateTime;
        }

        public abstract void AddTask(HowTaskWork task);

        public abstract void RemoveTask(Guid guid);
       
        public abstract void ShowTasks();


        public abstract void ShowTaskById(int id);


        public abstract void UpdateTask(int id, Guid guid);

        
    }
}
