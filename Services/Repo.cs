using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;
using task_manager;

namespace api.Services
{
    public class Repo : IRepo
    {
        private DataContext _dataContext;

        public Repo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> AddTaskList(TaskList newTaskList)
        {
            try
            {
                await _dataContext.TaskLists.AddAsync(newTaskList);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<TaskList>> GetAllTaskLists()
        {
            try
            {
                var result = await _dataContext.TaskLists.Where(taskList => taskList.Deleted == false).ToListAsync();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<TaskList> GetTaskList(int id)
        {
            try
            {
                var result = await _dataContext.TaskLists.SingleOrDefaultAsync(task => task.Id == id);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public async Task<bool> UpdateTaskList(TaskList updatedTaskList)
        {
            try
            {
                var taskListToUpdate = await _dataContext.TaskLists.SingleOrDefaultAsync(taskList => taskList.Id == updatedTaskList.Id);
                taskListToUpdate.Name = updatedTaskList.Name;
                taskListToUpdate.CreateDate = updatedTaskList.CreateDate;
                taskListToUpdate.Deleted = updatedTaskList.Deleted;
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteTaskList(int id)
        {
            try
            {
                var taskToDelete = await _dataContext.TaskLists.SingleOrDefaultAsync(taskList => taskList.Id == id);
                taskToDelete.Deleted = true;
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddTask(TaskObj newTask)
        {
            try
            {
                await _dataContext.Tasks.AddAsync(newTask);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<TaskObj>> GetAllTasks()
        {
            try
            {
                var result = await _dataContext.Tasks.Where(task => task.Deleted == false).ToListAsync();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<List<TaskObj>> GetTasksFromList(int listId)
        {
            try
            {
                var result = await _dataContext.Tasks.Where(task => task.TaskListId == listId && task.Deleted == false).ToListAsync();
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<TaskObj> GetTask(int id)
        {
            try
            {
                var result = await _dataContext.Tasks.SingleOrDefaultAsync(task => task.Id == id);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> UpdateTask(TaskObj updatedTask)
        {
            try
            {
                var taskToUpdate = await _dataContext.Tasks.SingleOrDefaultAsync(task => task.Id == updatedTask.Id);
                taskToUpdate.Text = updatedTask.Text;
                taskToUpdate.CreateDate = updatedTask.CreateDate;
                taskToUpdate.Deleted = updatedTask.Deleted;
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        public async Task<bool> DeleteTask(int id)
        {
            try
            {
                var taskToDelete = await _dataContext.Tasks.SingleOrDefaultAsync(task => task.Id == id);
                taskToDelete.Deleted = true;
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}