using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public interface IRepo
    {
         Task<IEnumerable<TaskList>> GetTaskLists();
         Task<TaskList> GetTaskList(int id);
         Task<bool> UpdateTaskList(TaskList updatedTaskList);
         Task<bool> DeleteTaskList(int id);
         Task<IEnumerable<TaskObj>> GetTasks();
         Task<TaskObj> GetTask(int id);
         Task<bool> UpdateTask(TaskObj updatedTask);
         Task<bool> DeleteTask(int id);
    }
}