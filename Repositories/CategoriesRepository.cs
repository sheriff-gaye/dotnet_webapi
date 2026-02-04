


using Application.Interfaces;
using Domain.Categories;

namespace Infrastructure.Repositories
{

    public class CategoriesRepository : ICategoriesRepository
    {

        private static List<Categories> _categories = new(){

            new Categories {
            Id = 1, Name = "Learn .NET"
        },
        new Categories {
            Id = 1, Name = "Learn .NET"
        }
        };


        

    }

}