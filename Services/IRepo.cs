using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public interface IRepo
    {
         Task<List<TaskList>> GetAllTaskLists();
         Task<TaskList> GetTaskList(int id);
         Task<bool> UpdateTaskList(TaskList updatedTaskList);
         Task<bool> DeleteTaskList(int id);
         Task<List<TaskObj>> GetAllTasks();
         Task<List<TaskObj>> GetTasksFromList(int listId);
         Task<TaskObj> GetTask(int id);
         Task<bool> UpdateTask(TaskObj updatedTask);
         Task<bool> DeleteTask(int id);
    }
}