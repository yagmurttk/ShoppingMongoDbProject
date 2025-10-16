using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingMongo.Dtos.ProductDtos;
using ShoppingMongo.Models;
using ShoppingMongo.Services.CategoryServices;
using ShoppingMongo.Services.PDImageServices;
using ShoppingMongo.Services.ProductServices;
using System.Threading.Tasks;

namespace ShoppingMongo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IPDImageService _pDImageService;

        public ProductsController(IProductService productService, ICategoryService categoryService, IPDImageService pDImageService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _pDImageService = pDImageService;
        }

        public async Task<IActionResult> ProductList()
        {
            var products = await _productService.GetAllProductAsync();
            var categories = await _categoryService.GetAllCategoryAsync();

            var categoryDict = categories.ToDictionary(x => x.CategoryId, x => x.CategoryName);

            foreach (var product in products)
            {
                if (categoryDict.TryGetValue(product.CategoryId, out var categoryName))
                {
                    product.CategoryName = categoryName;
                }
                else
                {
                    product.CategoryName = "Unknown";
                }
            }

            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.v = categories.Select(c => new SelectListItem
            {
                Text = c.CategoryName,
                Value = c.CategoryId
            }).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            createProductDto.Status = true;
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(string id)
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.v = categories.Select(c => new SelectListItem
            {
                Text = c.CategoryName,
                Value = c.CategoryId
            }).ToList();

            var value = await _productService.GetProductByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            updateProductDto.Status = true;
            await _productService.UpdateProductAsync(updateProductDto);
            return RedirectToAction("ProductList");
        }

        public async Task<IActionResult> Detail(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            var images = await _pDImageService.GetPDImageByProductIdAsync(id);

            var viewModel = new ProductDetailViewModel
            {
                Product = product,
                Images = images
            };

            return View(viewModel);
        }
    }
}
