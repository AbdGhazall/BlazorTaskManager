// Services/TaskService.cs
using BlazorTaskManager.Models;

namespace BlazorTaskManager.Services
{
    public class TaskService
    {
        private readonly List<TaskItem> _tasks = new();

        public IReadOnlyList<TaskItem> GetTasks() => _tasks;

        public void AddTask(TaskItem task)
        {
            _tasks.Add(task);
        }
    }
}
