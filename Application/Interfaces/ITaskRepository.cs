
using Domain.TaskEntity;

namespace Application.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<TaskEntity> GetAll();
        TaskEntity? GetById(int id);
        void Add(TaskEntity task);
        void Update(TaskEntity task);
        void Delete(TaskEntity task);
    }
}
