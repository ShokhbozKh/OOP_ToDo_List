using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Project_1_OOP
{
    public interface ITask
    {
         void AddTask(HowTaskWork task);
         void ShowTasks();
         void RemoveTask(Guid guid);
         void ShowTaskById(int id);
         void UpdateTask(int id, Guid guid);
    }
}
