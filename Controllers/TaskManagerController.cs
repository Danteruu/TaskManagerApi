using System.Threading.Tasks;
using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagerController : ControllerBase
    {
        private IRepo _repo;

        public TaskManagerController(IRepo repo)
        {
            _repo = repo;
        }

        #region TaskList CRUD

        [HttpPost, Route("tasklist")]
        public async Task<IActionResult> AddTaskList(TaskList newTaskList){
            var result = await _repo.AddTaskList(newTaskList);
            return Ok(result);
        }

        [HttpGet, Route("tasklists")]
        public async Task<IActionResult> GetAllTaskLists()
        {
            var result = await _repo.GetAllTaskLists();
            return Ok(result);
        }

        [HttpGet, Route("tasklist/{id}")]
        public async Task<IActionResult> GetTaskList(int id)
        {
            var result = await _repo.GetTaskList(id);
            return Ok(result);
        }

        [HttpPut, Route("tasklist")]
        public async Task<IActionResult> UpdateTaskList(TaskList updatedTaskList)
        {
            var result = await _repo.UpdateTaskList(updatedTaskList);
            return Ok(result);
        }

        [HttpDelete, Route("tasklist/{id}")]
        public async Task<IActionResult> DeleteTasklist(int id)
        {
            var result = await _repo.DeleteTaskList(id);
            return Ok(result);
        }

        #endregion

        #region Task CRUD
        
        [HttpPost, Route("task")]
        public async Task<IActionResult> AddTask(TaskObj newTask)
        {
            var result = await _repo.AddTask(newTask);
            return Ok(result);
        }

        [HttpGet, Route("tasks")]
        public async Task<IActionResult> GetAllTasks()
        {
            var result = await _repo.GetAllTasks();
            return Ok(result);
        }

        [HttpGet, Route("tasklist/{listId}/tasks")]
        public async Task<IActionResult> GetTasksFromList(int listId)
        {
            var result = await _repo.GetTasksFromList(listId);
            return Ok(result);
        }

        [HttpGet, Route("task/{id}")]
        public async Task<IActionResult> GetTask(int id)
        {
            var result = await _repo.GetTask(id);
            return Ok(result);
        }

        [HttpPut, Route("task")]
        public async Task<IActionResult> UpdateTask(TaskObj updatedTask)
        {
            var result = await _repo.UpdateTask(updatedTask);
            return Ok(result);
        }

        [HttpDelete, Route("task/{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var result = await _repo.DeleteTask(id);
            return Ok(result);
        }

        #endregion
    }
}