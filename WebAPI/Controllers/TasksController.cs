using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private readonly TaskService _service;


        public TasksController(TaskService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new ApiResponse<object>
            {
                Success = true,
                Data = _service.GetAll()
            });
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _service.GetById(id);
            if (task == null) return NotFound();


            return Ok(task);
        }


        [HttpPost]
        public IActionResult Create(CreateTaskDto dto)
        {
            _service.Create(dto);
            return Ok(new { message = "Task created" });
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateTaskDto dto)
        {
            if (!_service.Update(id, dto)) return NotFound();
            return Ok(new { message = "Updated" });
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!_service.Delete(id)) return NotFound();
            return Ok(new { message = "Deleted" });
        }
    }
}