

using Domain.Categories;

namespace Application.Interfaces
{
public interface ICategoriesRepository
{

    IEnumerable<Categories> GetAll();

    Categories? GetById(int id);
    void Add(Categories task);
    void Update(Categories task);
    void Delete(Categories task);



}

}