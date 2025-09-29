using Task = TaskManager.Domain.Models.Task;

namespace TaskManager.Domain.Services
{
    internal class TaskService
    {
        private readonly List<Task> _tasks;

        public TaskService()
        {
            // Mock de tareas iniciales
            _tasks = new List<Task>
            {
                new Task("Buy groceries", DateTime.Now.AddDays(-2), "Completed"),
                new Task("Finish project report", DateTime.Now.AddDays(-1), "In Progress"),
                new Task("Call the doctor", DateTime.Now, "Pending"),
                new Task("Prepare presentation", DateTime.Now.AddDays(1), "Pending"),
                new Task("Go to the gym", DateTime.Now.AddDays(2), "In Progress"),
                new Task("Read a book", DateTime.Now.AddDays(3), "Pending"),
                new Task("Pay bills", DateTime.Now.AddDays(-3), "Completed"),
                new Task("Team meeting", DateTime.Now.AddHours(5), "In Progress")
            };
        }

        // Get all tasks
        public List<Task> GetFiltered(DateTime? dateFrom, DateTime? dateTo)
        {
            var query = _tasks.AsEnumerable();

            if (dateFrom.HasValue)
                query = query.Where(t => t.Date.Date >= dateFrom.Value.Date);

            if (dateTo.HasValue)
                query = query.Where(t => t.Date.Date <= dateTo.Value.Date);

            return query.ToList();
        }


        // Get task by description (simple ejemplo de búsqueda)
        public Task? GetByDescription(string description)
        {
            return _tasks.FirstOrDefault(t => t.Description.Equals(description, StringComparison.OrdinalIgnoreCase));
        }

        // Create new task
        public void Create(Task task)
        {
            _tasks.Add(task);
        }

        // Update task (by description en este mock)
        public bool Update(string description, Task updatedTask)
        {
            var task = GetByDescription(description);
            if (task == null) return false;

            task.Description = updatedTask.Description;
            task.Date = updatedTask.Date;
            task.Status = updatedTask.Status;

            return true;
        }

        // Delete task (by description en este mock)
        public bool Delete(string description)
        {
            var task = GetByDescription(description);
            if (task == null) return false;

            _tasks.Remove(task);
            return true;
        }
    }
}
