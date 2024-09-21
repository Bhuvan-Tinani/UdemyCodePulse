using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using CodePulse.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    //http://localhost:xxxx/api/Categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepositary categoryRepositary;

        public CategoriesController(ICategoryRepositary categoryRepositary)
        {
            this.categoryRepositary = categoryRepositary;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequest request)
        {
            //DTO to Domain
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };
            await categoryRepositary.createAsync(category);
            //Domain to DTO
            var response = new CategoryDTO
            {
                Id = category.Id,
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };
            return Ok(response);
        }
    }
}
