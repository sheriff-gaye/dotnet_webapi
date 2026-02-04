using Application.DTOs;
using Application.Interfaces;
using Domain.TaskEntity;


namespace Application.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _repo;


        public TaskService(ITaskRepository repo)
        {
            _repo = repo;
        }


        public IEnumerable<TaskDto> GetAll()
        {
            return _repo.GetAll().Select(MapToDto);
        }


        public TaskDto? GetById(int id)
        {
            var task = _repo.GetById(id);
            return task == null ? null : MapToDto(task);
        }

        public void Create(CreateTaskDto dto)
        {
            var task = new TaskEntity
            {
                Title = dto.Title,
                Description = dto.Description,
                Priority = Enum.Parse<Priority>(dto.Priority, true),
                Status = Domain.TaskEntity.TaskStatus.Pending
            };


            _repo.Add(task);
        }


        public bool Update(int id, UpdateTaskDto dto)
        {
            var task = _repo.GetById(id);
            if (task == null) return false;


            task.Title = dto.Title;
            task.Description = dto.Description;
            task.Status = Enum.Parse<Domain.TaskEntity.TaskStatus>(dto.Status, true);


            _repo.Update(task);
            return true;
        }

        public bool Delete(int id)
        {
            var task = _repo.GetById(id);
            if (task == null) return false;


            _repo.Delete(task);
            return true;
        }


        private static TaskDto MapToDto(TaskEntity task)
        {
            return new TaskDto
            {
                Id = task.Id,
                Title = task.Title,
                Description = task.Description,
                Priority = task.Priority.ToString(),
                Status = task.Status.ToString()
            };
        }
    }

}