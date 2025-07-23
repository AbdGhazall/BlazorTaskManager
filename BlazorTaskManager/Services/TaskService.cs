using BlazorTaskManager.Models;

namespace BlazorTaskManager.Services
{
    public class TaskService
    {
        private List<TaskItem> _tasks = new();

        public void AddTask(TaskItem task)
        {
            _tasks.Add(task);
        }

        public List<TaskItem> GetTasks()
        {
            return _tasks;
        }

        public void DeleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }
    }
}