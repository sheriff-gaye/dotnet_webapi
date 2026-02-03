namespace Domain.TaskEntity
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }


    public enum Priority
    {
        Low,
        Medium,
        High,
        Critical
    }


    public enum TaskStatus
    {
        Pending,
        InProgress,
        Completed,
        Cancelled
    }
}