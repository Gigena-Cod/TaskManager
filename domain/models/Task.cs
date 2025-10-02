namespace TaskManager.Domain.Models
{
    internal class Task
    {
        public string description { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }

        public Task(string description, DateTime date, string status)
        {
            this.description = description;
            this.date = date;
            this.status = status;
        }
    }
}
