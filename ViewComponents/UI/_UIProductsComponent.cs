using Microsoft.AspNetCore.Mvc;
using ShoppingMongo.Models;
using ShoppingMongo.Services.CategoryServices;
using ShoppingMongo.Services.ProductServices;
using System.Threading.Tasks;

namespace ShoppingMongo.ViewComponents.UI
{
    public class _UIProductsComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public _UIProductsComponent(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new ProductViewModel
            {
                Products = await _productService.GetAllProductAsync(),
                Categories = await _categoryService.GetAllCategoryAsync()
            };


            return View(model);
        }
    }
}
