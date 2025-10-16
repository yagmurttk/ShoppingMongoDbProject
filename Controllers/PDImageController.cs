using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingMongo.Dtos.PDImageDtos;
using ShoppingMongo.Services.PDImageServices;
using ShoppingMongo.Services.ProductServices;
using System.Threading.Tasks;

namespace ShoppingMongo.Controllers
{
    public class PDImageController : Controller
    {
        private readonly IPDImageService _pDImageService;
        private readonly IProductService _productService;


        public PDImageController(IPDImageService pDImageService, IProductService productService)
        {
            _pDImageService = pDImageService;
            _productService = productService;
        }

        public async Task<IActionResult> PDImageList()
        {
            var pdimage = await _pDImageService.GetAllPDImageAsync();
            var products = await _productService.GetAllProductAsync();

            var productDict = products.ToDictionary(x => x.ProductId, x => x.ProductName);

            foreach (var item in pdimage)
            {
                if (productDict.TryGetValue(item.ProductId, out var productName))
                {
                    item.ProductName = productName;
                }
                else
                {
                    item.ProductName = "Unknown";
                }
            }

            return View(pdimage);
        }

        [HttpGet]
        public async Task<IActionResult> CreatePDImage()
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(p => new SelectListItem
            {
                Text = p.ProductName,
                Value = p.ProductId
            }).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePDImage(CreatePDImageDto createPDImageDto)
        {
            await _pDImageService.CreatePDImageAsync(createPDImageDto);
            return RedirectToAction("PDImageList");
        }

        public async Task<IActionResult> DeletePDImage(string id)
        {
            await _pDImageService.DeletePDImageAsync(id);
            return RedirectToAction("PDImageList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePDImage(string id)
        {
            var products = await _productService.GetAllProductAsync();
            ViewBag.v = products.Select(p => new SelectListItem
            {
                Text = p.ProductName,
                Value = p.ProductId
            }).ToList();

            var value = await _pDImageService.GetPDImageByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePDImage(UpdatePDImageDto updatePDImageDto)
        {
            await _pDImageService.UpdatePDImageAsync(updatePDImageDto);
            return RedirectToAction("PDImageList");
        }
    }
}
