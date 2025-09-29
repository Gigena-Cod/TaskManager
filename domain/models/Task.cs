namespace TaskManager.Domain.Models
{
    internal class Task
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public Task(string description, DateTime date, string status)
        {
            Description = description;
            Date = date;
            Status = status;
        }
    }
}
