

using Application.DTOs;
using Application.Interfaces;
using Domain.Categories;


namespace Application.Services
{
    public class CategoriesService

    {


        private readonly ICategoriesRepository _repository;

        public CategoriesService(ICategoriesRepository repository)
        {
            _repository = repository;
        }


        public IEnumerable<CategoiresDto> GetAll()
        {
            return _repository.GetAll().Select(MapToDto);
        }

        public CategoiresDto? GetById(int id)
        {
            var categories = _repository.GetById(id);
            return categories == null ? null : MapToDto(categories);
        }

        public void Create(CreateCategoiresDto dto)
        {
            var categories = new Categories
            {
                Name = dto.Name
            };

            _repository.Add(categories);
        }


        public bool Update(int id, UpdateCategoiresDto dto)
        {

            var categories = _repository.GetById(id);
            if (categories == null) return false;

            categories.Name = dto.Name;

            _repository.Update(categories);

            return true;

        }


        public bool Delete(int id)
        {
            var categories = _repository.GetById(id);
            if (categories == null) return false;


            _repository.Delete(categories);

            return true;
        }


        public static CategoiresDto MapToDto(Categories categories)
        {
            return new CategoiresDto
            {
                Id = categories.Id,
                Name = categories.Name
            };
        }






    }

}