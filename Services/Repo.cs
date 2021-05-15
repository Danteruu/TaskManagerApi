using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;

namespace api.Services
{
    public class Repo : IRepo
    {
        public Task<IEnumerable<TaskList>> GetTaskLists()
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskList> GetTaskList(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateTaskList(TaskList updatedTaskList)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteTaskList(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TaskObj>> GetTasks()
        {
            throw new System.NotImplementedException();
        }

        public Task<TaskObj> GetTask(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateTask(TaskObj updatedTask)
        {
            throw new System.NotImplementedException();
        }
        public Task<bool> DeleteTask(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}