using System.Data;
using TaskManager.domain.repository; 
using Task = TaskManager.Domain.Models.Task;

namespace TaskManager.Domain.Services
{
    internal class TaskService
    {
        private readonly Repository _repository;

        public TaskService()
        {
            _repository = new Repository();
        }

        // Obtener todas las tareas (con filtros opcionales por fecha)
        public List<Task> GetFiltered(DateTime? dateFrom, DateTime? dateTo)
        {
            string query = "SELECT Description, [Date], Status FROM Tasks WHERE 1=1";

            if (dateFrom.HasValue)
                query += $" AND [Date] >= #{dateFrom.Value:MM/dd/yyyy}#";

            if (dateTo.HasValue)
                query += $" AND [Date] <= #{dateTo.Value:MM/dd/yyyy}#";

            DataTable dt = _repository.Get(query);

            return dt.AsEnumerable().Select(row =>
                new Task(
                    row["Description"].ToString(),
                    Convert.ToDateTime(row["Date"]),
                    row["Status"].ToString()
                )
            ).ToList();
        }

        // Obtener tarea por descripción
        public Task? GetByDescription(string description)
        {
            string query = $"SELECT Description, [Date], Status FROM Tasks WHERE Description = '{description.Replace("'", "''")}'";

            DataTable dt = _repository.Get(query);
            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            return new Task(row["Description"].ToString(), Convert.ToDateTime(row["Date"]), row["Status"].ToString());
        }

        // Crear nueva tarea
        public void Create(Task task)
        {
            string query = $"INSERT INTO Tasks (Description, [Date], Status) VALUES ('{task.description.Replace("'", "''")}', #{task.date:MM/dd/yyyy}#, '{task.status}')";
            _repository.Execute(query);
        }

        // Actualizar tarea (ejemplo: por descripción)
        public bool Update(string oldDescription, Task updatedTask)
        {
            string query = $"UPDATE Tasks SET Description='{updatedTask.description.Replace("'", "''")}', [Date]=#{updatedTask.date:MM/dd/yyyy}#, Status='{updatedTask.status}' WHERE Description='{oldDescription.Replace("'", "''")}'";
            return _repository.Execute(query) > 0;
        }

        // Eliminar tarea
        public bool Delete(string description)
        {
            string query = $"DELETE FROM Tasks WHERE Description='{description.Replace("'", "''")}'";
            return _repository.Execute(query) > 0;
        }
    }
}
