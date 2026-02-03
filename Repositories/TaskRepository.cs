
using Application.Interfaces;
using Domain.TaskEntity;



namespace Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private static List<TaskEntity> _tasks = new()
        {
            new TaskEntity { Id = 1, Title = "Learn .NET", Description = "Study Web API", Priority = Priority.High, Status = Domain.TaskEntity.TaskStatus.Pending },
            new TaskEntity { Id = 2, Title = "Build Project", Description = "Clean Architecture", Priority = Priority.Critical, Status = Domain.TaskEntity.TaskStatus.InProgress },
            new TaskEntity { Id = 3, Title = "Test API", Description = "Use Swagger", Priority = Priority.Medium, Status = Domain.TaskEntity.TaskStatus.Completed }
        };

        public IEnumerable<TaskEntity> GetAll()
            => _tasks;

        public TaskEntity? GetById(int id)
            => _tasks.FirstOrDefault(t => t.Id == id);

        public void Add(TaskEntity task)
        {
            task.Id = _tasks.Max(t => t.Id) + 1;
            _tasks.Add(task);
        }

        public void Update(TaskEntity task) { }

        public void Delete(TaskEntity task)
        {
            _tasks.Remove(task);
        }
    }
}
