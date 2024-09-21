using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepositary
    {
        Task<Category> createAsync(Category category);
    }
}
