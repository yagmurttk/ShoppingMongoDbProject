using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Services.CategoryServices;
using System.Threading.Tasks;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UICategoriesComponent:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _UICategoriesComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values= await _categoryService.GetAllCategoryAsync();
            return View(values);
        }
    }
}
